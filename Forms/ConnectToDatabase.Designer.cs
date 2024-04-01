namespace Poliklinika
{
    partial class ConnectToDatabaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectToDatabaseForm));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.lblClearFields = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nnraTextBoxServer = new NnraTools.NnraTextBox();
            this.nnraTextBoxDataBase = new NnraTools.NnraTextBox();
            this.nnraTextBoxName = new NnraTools.NnraTextBox();
            this.nnraTextBoxPassword = new NnraTools.NnraTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(150, 100);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.MaximumSize = new System.Drawing.Size(200, 200);
            this.pbLogo.MinimumSize = new System.Drawing.Size(200, 200);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 200);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            this.pbLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLogo_MouseDown);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(100, 700);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnConnect.MaximumSize = new System.Drawing.Size(305, 35);
            this.btnConnect.MinimumSize = new System.Drawing.Size(300, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(300, 30);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.TabStop = false;
            this.btnConnect.Text = "Poveži Se Na Databazu";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            this.btnConnect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnConnect_MouseDown);
            this.btnConnect.MouseEnter += new System.EventHandler(this.btnConnect_MouseEnter);
            this.btnConnect.MouseLeave += new System.EventHandler(this.btnConnect_MouseLeave);
            this.btnConnect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnConnect_MouseUp);
            // 
            // tbnClose
            // 
            this.tbnClose.BackColor = System.Drawing.Color.Transparent;
            this.tbnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbnClose.BackgroundImage")));
            this.tbnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.tbnClose.FlatAppearance.BorderSize = 0;
            this.tbnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tbnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tbnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnClose.Location = new System.Drawing.Point(475, 5);
            this.tbnClose.Margin = new System.Windows.Forms.Padding(0);
            this.tbnClose.Name = "tbnClose";
            this.tbnClose.Size = new System.Drawing.Size(20, 20);
            this.tbnClose.TabIndex = 8;
            this.tbnClose.TabStop = false;
            this.tbnClose.UseVisualStyleBackColor = false;
            this.tbnClose.Click += new System.EventHandler(this.tbnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(445, 5);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRememberMe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cbRememberMe.FlatAppearance.BorderSize = 0;
            this.cbRememberMe.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRememberMe.ForeColor = System.Drawing.Color.White;
            this.cbRememberMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbRememberMe.Location = new System.Drawing.Point(100, 675);
            this.cbRememberMe.Margin = new System.Windows.Forms.Padding(0);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(132, 23);
            this.cbRememberMe.TabIndex = 10;
            this.cbRememberMe.TabStop = false;
            this.cbRememberMe.Text = "Sačuvaj Podatke";
            this.cbRememberMe.UseVisualStyleBackColor = true;
            this.cbRememberMe.CheckedChanged += new System.EventHandler(this.cbRememberMe_CheckedChanged);
            // 
            // lblClearFields
            // 
            this.lblClearFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClearFields.AutoSize = true;
            this.lblClearFields.BackColor = System.Drawing.Color.Transparent;
            this.lblClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClearFields.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClearFields.ForeColor = System.Drawing.Color.White;
            this.lblClearFields.Location = new System.Drawing.Point(320, 675);
            this.lblClearFields.Margin = new System.Windows.Forms.Padding(0);
            this.lblClearFields.Name = "lblClearFields";
            this.lblClearFields.Size = new System.Drawing.Size(78, 19);
            this.lblClearFields.TabIndex = 11;
            this.lblClearFields.Text = "Očisti Polja";
            this.lblClearFields.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClearFields.Click += new System.EventHandler(this.lblClearFields_Click);
            this.lblClearFields.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblClearFields_MouseDown);
            this.lblClearFields.MouseEnter += new System.EventHandler(this.lblClearFields_MouseEnter);
            this.lblClearFields.MouseLeave += new System.EventHandler(this.lblClearFields_MouseLeave);
            this.lblClearFields.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblClearFields_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 25);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // nnraTextBoxServer
            // 
            this.nnraTextBoxServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.nnraTextBoxServer.BorderColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.nnraTextBoxServer.BorderColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.nnraTextBoxServer.BorderGradientAngle = 0F;
            this.nnraTextBoxServer.BorderRadius = 0;
            this.nnraTextBoxServer.BorderSize = 2;
            this.nnraTextBoxServer.FocusedBorderColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(175)))));
            this.nnraTextBoxServer.FocusedBorderColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.nnraTextBoxServer.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nnraTextBoxServer.ForeColor = System.Drawing.Color.White;
            this.nnraTextBoxServer.Location = new System.Drawing.Point(100, 400);
            this.nnraTextBoxServer.Margin = new System.Windows.Forms.Padding(4);
            this.nnraTextBoxServer.Multiline = false;
            this.nnraTextBoxServer.Name = "nnraTextBoxServer";
            this.nnraTextBoxServer.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nnraTextBoxServer.PasswordChar = false;
            this.nnraTextBoxServer.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.nnraTextBoxServer.PlaceholderText = "Server";
            this.nnraTextBoxServer.Size = new System.Drawing.Size(300, 34);
            this.nnraTextBoxServer.TabIndex = 13;
            this.nnraTextBoxServer.TabStop = false;
            this.nnraTextBoxServer.TBText = "";
            this.nnraTextBoxServer.UnderLinedStyle = true;
            // 
            // nnraTextBoxDataBase
            // 
            this.nnraTextBoxDataBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.nnraTextBoxDataBase.BorderColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.nnraTextBoxDataBase.BorderColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.nnraTextBoxDataBase.BorderGradientAngle = 0F;
            this.nnraTextBoxDataBase.BorderRadius = 0;
            this.nnraTextBoxDataBase.BorderSize = 2;
            this.nnraTextBoxDataBase.FocusedBorderColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(175)))));
            this.nnraTextBoxDataBase.FocusedBorderColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.nnraTextBoxDataBase.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nnraTextBoxDataBase.ForeColor = System.Drawing.Color.White;
            this.nnraTextBoxDataBase.Location = new System.Drawing.Point(100, 475);
            this.nnraTextBoxDataBase.Margin = new System.Windows.Forms.Padding(4);
            this.nnraTextBoxDataBase.Multiline = false;
            this.nnraTextBoxDataBase.Name = "nnraTextBoxDataBase";
            this.nnraTextBoxDataBase.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nnraTextBoxDataBase.PasswordChar = false;
            this.nnraTextBoxDataBase.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.nnraTextBoxDataBase.PlaceholderText = "Databaza";
            this.nnraTextBoxDataBase.Size = new System.Drawing.Size(300, 34);
            this.nnraTextBoxDataBase.TabIndex = 14;
            this.nnraTextBoxDataBase.TabStop = false;
            this.nnraTextBoxDataBase.TBText = "";
            this.nnraTextBoxDataBase.UnderLinedStyle = true;
            // 
            // nnraTextBoxName
            // 
            this.nnraTextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.nnraTextBoxName.BorderColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.nnraTextBoxName.BorderColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.nnraTextBoxName.BorderGradientAngle = 0F;
            this.nnraTextBoxName.BorderRadius = 0;
            this.nnraTextBoxName.BorderSize = 2;
            this.nnraTextBoxName.FocusedBorderColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(175)))));
            this.nnraTextBoxName.FocusedBorderColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.nnraTextBoxName.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nnraTextBoxName.ForeColor = System.Drawing.Color.White;
            this.nnraTextBoxName.Location = new System.Drawing.Point(100, 550);
            this.nnraTextBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.nnraTextBoxName.Multiline = false;
            this.nnraTextBoxName.Name = "nnraTextBoxName";
            this.nnraTextBoxName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nnraTextBoxName.PasswordChar = false;
            this.nnraTextBoxName.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.nnraTextBoxName.PlaceholderText = "Ime";
            this.nnraTextBoxName.Size = new System.Drawing.Size(300, 34);
            this.nnraTextBoxName.TabIndex = 15;
            this.nnraTextBoxName.TabStop = false;
            this.nnraTextBoxName.TBText = "";
            this.nnraTextBoxName.UnderLinedStyle = true;
            // 
            // nnraTextBoxPassword
            // 
            this.nnraTextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.nnraTextBoxPassword.BorderColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.nnraTextBoxPassword.BorderColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.nnraTextBoxPassword.BorderGradientAngle = 0F;
            this.nnraTextBoxPassword.BorderRadius = 0;
            this.nnraTextBoxPassword.BorderSize = 2;
            this.nnraTextBoxPassword.FocusedBorderColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(175)))));
            this.nnraTextBoxPassword.FocusedBorderColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.nnraTextBoxPassword.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nnraTextBoxPassword.ForeColor = System.Drawing.Color.White;
            this.nnraTextBoxPassword.Location = new System.Drawing.Point(100, 625);
            this.nnraTextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.nnraTextBoxPassword.Multiline = false;
            this.nnraTextBoxPassword.Name = "nnraTextBoxPassword";
            this.nnraTextBoxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nnraTextBoxPassword.PasswordChar = true;
            this.nnraTextBoxPassword.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.nnraTextBoxPassword.PlaceholderText = "Šifra";
            this.nnraTextBoxPassword.Size = new System.Drawing.Size(300, 34);
            this.nnraTextBoxPassword.TabIndex = 16;
            this.nnraTextBoxPassword.TabStop = false;
            this.nnraTextBoxPassword.TBText = "";
            this.nnraTextBoxPassword.UnderLinedStyle = true;
            // 
            // ConnectToDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.ControlBox = false;
            this.Controls.Add(this.nnraTextBoxPassword);
            this.Controls.Add(this.nnraTextBoxName);
            this.Controls.Add(this.nnraTextBoxDataBase);
            this.Controls.Add(this.nnraTextBoxServer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblClearFields);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.tbnClose);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.pbLogo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Corbel Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 800);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 800);
            this.Name = "ConnectToDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose DataBase";
            this.Load += new System.EventHandler(this.chooseDbForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbLogo;
        private Button btnConnect;
        private Button tbnClose;
        private Button btnMinimize;
        private CheckBox cbRememberMe;
        private Label lblClearFields;
        private PictureBox pictureBox1;
        private NnraTools.NnraTextBox nnraTextBoxServer;
        private NnraTools.NnraTextBox nnraTextBoxDataBase;
        private NnraTools.NnraTextBox nnraTextBoxName;
        private NnraTools.NnraTextBox nnraTextBoxPassword;
    }
}