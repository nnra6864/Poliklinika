using Poliklinika.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Poliklinika
{
    public partial class ConnectToDatabaseForm : Form
    {
        public static string connectionString;
        public static SqlConnection sqlConnection;

        //Text Boxes
        NnraTools.NnraTextBox serverTextBox;
        NnraTools.NnraTextBox databaseTextBox;
        NnraTools.NnraTextBox nameTextBox;
        NnraTools.NnraTextBox passwordTextBox;

        public ConnectToDatabaseForm()
        {
            InitializeComponent();

            //Text Boxes
            serverTextBox = nnraTextBoxServer;
            databaseTextBox = nnraTextBoxDataBase;
            nameTextBox = nnraTextBoxName;
            passwordTextBox = nnraTextBoxPassword;

            try { cbRememberMe.Checked = Properties.Settings.Default.RememberMe; } catch { cbRememberMe.Checked = false; }

            if (cbRememberMe.Checked)
            {
                serverTextBox.isPlaceholder = false;
                serverTextBox.TBText = Properties.Settings.Default.Server;
                databaseTextBox.isPlaceholder = false;
                databaseTextBox.TBText = Properties.Settings.Default.Database;
                nameTextBox.isPlaceholder = false;
                nameTextBox.TBText = Properties.Settings.Default.Name;
                passwordTextBox.isPlaceholder = false;
                passwordTextBox.PasswordChar = true;
                passwordTextBox.TBText = Properties.Settings.Default.Password;
            }
        }
        private void chooseDbForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = serverTextBox.TBText;
            Properties.Settings.Default.Database = databaseTextBox.TBText;
            Properties.Settings.Default.Name = nameTextBox.TBText;
            Properties.Settings.Default.Password = passwordTextBox.TBText;

            connectionString = $"Server = {serverTextBox.TBText}; Database = {databaseTextBox.TBText}; User Id = {nameTextBox.TBText}; Password = {passwordTextBox.TBText};";
            Properties.Settings.Default.ConString = connectionString;

            Properties.Settings.Default.Save();

            MainForm formHome = new MainForm();
            try { sqlConnection = new SqlConnection(connectionString); } catch { MessageBox.Show("Konekcija nije uspela, proveri podatke!"); return; }
            try { sqlConnection.Open();  formHome.Show(); sqlConnection.Close(); this.Close(); } catch { MessageBox.Show("Konekcija nije uspela, proveri podatke!"); }
        }

        private void cbRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberMe = cbRememberMe.Checked;
            Properties.Settings.Default.Save();
        }
        private void lblClearFields_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = "";
            Properties.Settings.Default.Database = "";
            Properties.Settings.Default.Name = "";
            Properties.Settings.Default.Password = "";

            Properties.Settings.Default.Save();

            serverTextBox.TBText = "";
            databaseTextBox.TBText = "";
            nameTextBox.TBText = "";
            passwordTextBox.TBText = "";
        }

        // Close/Minimize

        private void tbnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Application.DoEvents();
        }

        // Drag Box

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region VFX
        //Clear Fields
        private void lblClearFields_MouseEnter(object sender, EventArgs e)
        {
            lblClearFields.Font = new Font(lblClearFields.Font.Name, 12.5f, FontStyle.Regular);
        }

        private void lblClearFields_MouseDown(object sender, MouseEventArgs e)
        {
            lblClearFields.Font = new Font(lblClearFields.Font.Name, 13f, FontStyle.Regular);
        }

        private void lblClearFields_MouseUp(object sender, MouseEventArgs e)
        {
            lblClearFields.Font = new Font(lblClearFields.Font.Name, 12.5f, FontStyle.Regular);
        }

        private void lblClearFields_MouseLeave(object sender, EventArgs e)
        {
            lblClearFields.Font = new Font(lblClearFields.Font.Name, 12, FontStyle.Regular);
        }

        //Connect
        private void btnConnect_MouseEnter(object sender, EventArgs e)
        {
            btnConnect.Font = new Font(btnConnect.Font.Name, 17, FontStyle.Regular);
            btnConnect.Size = new Size(btnConnect.Width + 2, btnConnect.Height + 2);
        }

        private void btnConnect_MouseDown(object sender, MouseEventArgs e)
        {
            btnConnect.Font = new Font(btnConnect.Font.Name, 18, FontStyle.Regular);
            btnConnect.Size = new Size(btnConnect.Width + 3, btnConnect.Height + 3);
        }

        private void btnConnect_MouseUp(object sender, MouseEventArgs e)
        {
            btnConnect.Font = new Font(btnConnect.Font.Name, 17, FontStyle.Regular);
            btnConnect.Size = new Size(btnConnect.Width - 3, btnConnect.Height - 3);
        }

        private void btnConnect_MouseLeave(object sender, EventArgs e)
        {
            btnConnect.Font = new Font(btnConnect.Font.Name, 15.75f, FontStyle.Regular);
            btnConnect.Size = new Size(btnConnect.Width - 2, btnConnect.Height - 2);
        }
        #endregion

        public void AboutSite() 
        {
            /*System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = Directory.GetCurrentDirectory() + "/Sites/Index.html", UseShellExecute = true });*/
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = "https://poliklinika.netlify.app/", UseShellExecute = true });
        }

        private void pbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            AboutSite();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}