using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poliklinika.Classes;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Data.SqlClient;

namespace Poliklinika.Forms.SubForms
{
    public partial class StatistikaForm : Form
    {
        #region Variables
        NnraScripts nnraScripts = new NnraScripts();
        public string connectionString;
        public SqlConnection con;

        public PullAndSortData pasd = new PullAndSortData();
        public List<Zakazivanje> listaZakazivanja = new List<Zakazivanje>();
        public List<RadioButton> rbList = new List<RadioButton>();
        public string sortBy = "Po Gradovima";
        public string sortOrder = "Po Broju";

        List<Axis> XAxes = new List<Axis>();
        List<Axis> YAxes = new List<Axis>();
        LinearGradientPaint chartGradient;
        LinearGradientPaint chartLabelGradient;
        #endregion

        #region Functions
        public void AddRB() 
        {
            rbList.Add(rbGrad);
            rbList.Add(rbKlinika);
            rbList.Add(rbSpecijalizacija);
        }

        public void LoadPreferences()
        {
            try { fromDate.Value = Properties.Settings.Default.FromDate; } catch { }
            try { toDate.Value = Properties.Settings.Default.ToDate; } catch { }
            try { comBoxSort.SelectedIndex = Properties.Settings.Default.SortBy; } catch { }

            foreach (RadioButton rb in rbList) 
            {
                if (rb.Name == Properties.Settings.Default.ShowBy)
                {
                    rb.PerformClick();
                }
            }
        }

        public void PopulateChart() 
        {
            pasd.PopulateList(connectionString, sortBy, sortOrder, fromDate.Text, toDate.Text, listaZakazivanja);
            string[] labels = listaZakazivanja.Select(x => x.Name).ToArray();

            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    MinStep = 0,
                    ForceStepToMin = true,
                    MinLimit = 0,
                    MaxLimit = 11,

                    LabelsPaint = new SolidColorPaint(SKColor.FromHsl(189, 100, 50)),
                    TextSize = 15,

                    SeparatorsPaint = new SolidColorPaint(SKColor.FromHsl(189, 100, 25))
                    {
                        StrokeThickness = 1
                    },

                    Labels = labels,
                    LabelsRotation = -90
                }
            };

            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                    MinStep = 2,
                    MinLimit = 0,
                    MaxLimit = 50,
                    LabelsPaint = new SolidColorPaint(SKColor.FromHsl(291, 100, 50)),
                    TextSize = 15,

                    SeparatorsPaint = new SolidColorPaint(SKColor.FromHsl(291, 100, 25))
                    {
                        StrokeThickness = 1
                    },
                }
            };

            try
            {
                if (sortOrder == "Po Broju Naviše" || sortOrder == "Po Nazivu Naviše")
                {
                    chartGradient = new LinearGradientPaint(SKColor.FromHsl(291, 100, 50), SKColor.FromHsl(191, 100, 50));
                    chartLabelGradient = new LinearGradientPaint(SKColor.FromHsl(291, 100, 75), SKColor.FromHsl(191, 100, 75));
                }
                else
                {
                    chartGradient = new LinearGradientPaint(SKColor.FromHsl(191, 100, 50), SKColor.FromHsl(291, 100, 50));
                    chartLabelGradient = new LinearGradientPaint(SKColor.FromHsl(291, 100, 75), SKColor.FromHsl(191, 100, 75));
                }
                cartesianChart1.Series = new[]
                {
                    new ColumnSeries<Zakazivanje>
                    {
                        Name = "Broj Pacijenata",
                        GroupPadding = 40,
                        Rx = 10,
                        Ry = 10,
                        /*DataLabelsPaint = chartLabelGradient,*/ //Paints numbers above lines (looks bad if it's 0)
                        Fill = chartGradient,
                        TooltipLabelFormatter = (point) => $"Broj Pacijenata: {point.PrimaryValue}",
                        Values = listaZakazivanja,
                        Mapping = (pacijent, point) =>
                        {
                           point.PrimaryValue = (int) pacijent.Count;
                           point.SecondaryValue = point.Context.Index;
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Radio Button
        private void rbGrad_CheckedChanged(object sender, EventArgs e)
        {
            sortBy = "Po Gradovima";
            Properties.Settings.Default.ShowBy = rbGrad.Name;
            Properties.Settings.Default.Save();
        }

        private void rbSpecijalizacija_CheckedChanged(object sender, EventArgs e)
        {
            sortBy = "Po Specijalizacijama";
            Properties.Settings.Default.ShowBy = rbSpecijalizacija.Name;
            Properties.Settings.Default.Save();
        }

        private void rbKlinikama_CheckedChanged(object sender, EventArgs e)
        {
            sortBy = "Po Klinikama";
            Properties.Settings.Default.ShowBy = rbKlinika.Name;
            Properties.Settings.Default.Save();
        }
        
        //Combo Box
        private void comBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortOrder = comBoxSort.Text;
            Properties.Settings.Default.SortBy = comBoxSort.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        //Dates
        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FromDate = fromDate.Value;
            Properties.Settings.Default.Save();
        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ToDate = toDate.Value;
            Properties.Settings.Default.Save();
        }
        #endregion

        public StatistikaForm()
        {
            InitializeComponent();
            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
            connectionString = Properties.Settings.Default.ConString;
        }

        private void StatistikaForm_Load(object sender, EventArgs e)
        {
            nnraScripts.ChangeMode(this);
            connectionString = Properties.Settings.Default.ConString;
            AddRB();
            LoadPreferences();
            sortOrder = comBoxSort.Text;
            PopulateChart();
        }

        private void Default_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            nnraScripts.ChangeMode(this);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PopulateChart();
        }
    }
}
