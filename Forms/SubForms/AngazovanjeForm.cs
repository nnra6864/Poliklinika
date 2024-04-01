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

namespace Poliklinika
{
    public partial class AngazovanjeForm : Form
    {
        NnraScripts nnraScripts = new NnraScripts();

        public string conString;
        BindingList<string> specijalizacije = new BindingList<string>();
        BindingList<Lekar> lekari = new BindingList<Lekar>();
        BindingList<Angazovanja> angazovanja = new BindingList<Angazovanja>();

        PopulateDataGrid pdg = new PopulateDataGrid();

        #region Functions

        #endregion

        public AngazovanjeForm()
        {
            InitializeComponent();
            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
            conString = Properties.Settings.Default.ConString;

            dgvDoktori.AutoGenerateColumns = false;

            comBoxSpecijalizacija.DataSource = specijalizacije;
            comBoxLekar.DataSource = lekari;
            dgvDoktori.DataSource = angazovanja;

            pdg.PopulateSpecijalizacije(conString, specijalizacije);
            pdg.PopulateLekari(conString, comBoxSpecijalizacija.SelectedIndex, lekari);
            pdg.PopulateGrid(conString, lekari[comBoxLekar.SelectedIndex].ID, angazovanja);
        }

        private void FormAngazovanje_Load(object sender, EventArgs e)
        {
            nnraScripts.ChangeMode(this);
            conString = Properties.Settings.Default.ConString;
        }

        private void Default_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            nnraScripts.ChangeMode(this);
        }

        private void FormAngazovanje_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comBoxSpecijalizacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { pdg.PopulateLekari(conString, comBoxSpecijalizacija.SelectedIndex, lekari); } catch { }
        }

        private void comBoxLekar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { pdg.PopulateGrid(conString, lekari[comBoxLekar.SelectedIndex].ID, angazovanja); } catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pdg.UpdateDatabase(conString, angazovanja, comBoxLekar.SelectedIndex, comBoxSpecijalizacija.SelectedIndex);
        }
    }
}
