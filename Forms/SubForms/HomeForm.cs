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

namespace Poliklinika.Forms.SubForms
{
    public partial class HomeForm : Form
    {
        NnraScripts nnraScripts = new NnraScripts();
        public HomeForm()
        {
            InitializeComponent();
            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            nnraScripts.ChangeMode(this);
        }

        private void Default_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            nnraScripts.ChangeMode(this);
        }

        public void AboutSite() 
        {
            /*System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = Directory.GetCurrentDirectory() + "/Sites/Index.html", UseShellExecute = true });*/
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = "https://poliklinika.netlify.app/", UseShellExecute = true });
        }

        private void pbMainLogo_MouseDown(object sender, MouseEventArgs e)
        {
            AboutSite();
        }
    }
}
