using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poliklinika.Forms.SubForms;

namespace Poliklinika.Forms
{
    public partial class MainForm : Form
    {
        public List<Button> buttons = new List<Button>();
        public void AddButtons() 
        {
            buttons.Add(btnHome);
            buttons.Add(btnAngazovanje);
            buttons.Add(btnStatistika);
            buttons.Add(btnOpcije);
            buttons.Add(btnMinimize);
            buttons.Add(btnClose);
        }
        Form previousForm;
        public HomeForm homeForm = new HomeForm();
        public AngazovanjeForm angazovanjeForm = new AngazovanjeForm();
        public StatistikaForm statistikaForm = new StatistikaForm();
        public OpcijeForm opcijeForm = new OpcijeForm();
        public List<Form> formsList = new List<Form>();


        public MainForm()
        {
            InitializeComponent();
            AddButtons();
            AddFormsToList();
            SelectButton(btnHome);
            previousForm = this;
            LoadFormInPanel(homeForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DarkMode)
            {
                this.BackColor = Color.FromArgb(20, 20, 20);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        #region Functions
        public void LoadFormInPanel(Form form) 
        {
            foreach (Form frm in formsList)
            {
                if (frm == form)
                {
                    if (previousForm != frm)
                    {
                        frm.TopLevel = false;
                        panelForm.Controls.Add(frm);
                        frm.BringToFront();
                        frm.Show();
                        frm.Refresh();
                        previousForm = frm;
                    }
                }
                else
                {
                    frm.Hide();
                }
            }
        }

        public void AddFormsToList() 
        {
            formsList.Add(homeForm);
            formsList.Add(angazovanjeForm);
            formsList.Add(statistikaForm);
            formsList.Add(opcijeForm);
        }
        #endregion


        #region Buttons
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SelectButton(btnHome);
            LoadFormInPanel(homeForm);
        }

        private void btnAngazovanje_Click(object sender, EventArgs e)
        {
            SelectButton(btnAngazovanje);
            LoadFormInPanel(angazovanjeForm);
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            SelectButton(btnStatistika);
            LoadFormInPanel(statistikaForm);
        }

        private void btnOpcije_Click(object sender, EventArgs e)
        {
            SelectButton(btnOpcije);
            LoadFormInPanel(opcijeForm);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Application.DoEvents();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        #region ButtonVFX
        private void SelectButton(Button but)
        {
            foreach (var btn in buttons) 
            {
                if (btn.Name != but.Name)
                {
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 40, 65);
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 30, 55);
                    btn.BackColor = Color.FromArgb(0, 50, 75);

                    btn.Font = new Font(btn.Font.Name, 15.75f, FontStyle.Regular);
                }
                else
                {
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 30, 55);
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 30, 55);
                    btn.BackColor = Color.FromArgb(0, 30, 55);

                    btn.Font = new Font(btn.Font.Name, 20f, FontStyle.Regular);
                }
            }
        }
        #endregion

    }
}
