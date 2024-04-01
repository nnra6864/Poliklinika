using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poliklinika.Forms.SubForms
{
    public partial class OpcijeForm : Form
    {
        public OpcijeForm()
        {
            InitializeComponent();
            SetMode(false);
        }

        #region Funkcije

        public void SetMode(bool shouldChange) 
        {
            if (shouldChange) 
            {
            Properties.Settings.Default.DarkMode = !Properties.Settings.Default.DarkMode;
            }

            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.DarkMode)
            {
                this.BackColor = Color.FromArgb(20, 20, 20);
                btnDarkMode.Text = "Tamna Tema";
                btnDarkMode.Image = Image.FromFile("Art/Settings/Dark Mode.png");
            }
            else if (!Properties.Settings.Default.DarkMode) 
            {
                this.BackColor = Color.White;
                btnDarkMode.Text = "Svetla Tema";
                btnDarkMode.Image = Image.FromFile("Art/Settings/Light Mode.png");
            }
        }

        public void ClearLogin() 
        {
            Properties.Settings.Default.Server = "";
            Properties.Settings.Default.Database = "";
            Properties.Settings.Default.Name = "";
            Properties.Settings.Default.Password = "";

            Properties.Settings.Default.Save();
        }

        public void ReLogin() 
        {
            ConnectToDatabaseForm conToDB = new ConnectToDatabaseForm();

            conToDB.Show();
            ((Form)this.Parent.Parent).Close();
        }

        #endregion

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            SetMode(true);
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearLogin();
        }

        private void btnReconnect_Click(object sender, EventArgs e)
        {
            ReLogin();
        }

        private void OpcijeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
