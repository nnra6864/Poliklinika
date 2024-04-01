namespace Poliklinika.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnHome = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnOpcije = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnAngazovanje = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 10);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 90);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnHome);
            this.panelButtons.Controls.Add(this.dragPanel);
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Controls.Add(this.btnMinimize);
            this.panelButtons.Controls.Add(this.btnOpcije);
            this.panelButtons.Controls.Add(this.btnStatistika);
            this.panelButtons.Controls.Add(this.btnAngazovanje);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.MaximumSize = new System.Drawing.Size(1200, 100);
            this.panelButtons.MinimumSize = new System.Drawing.Size(1200, 100);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1200, 100);
            this.panelButtons.TabIndex = 1;
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(1200, 10);
            this.dragPanel.TabIndex = 6;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1100, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 90);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1000, 10);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(100, 90);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnOpcije
            // 
            this.btnOpcije.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpcije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.btnOpcije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpcije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcije.FlatAppearance.BorderSize = 0;
            this.btnOpcije.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnOpcije.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnOpcije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcije.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpcije.ForeColor = System.Drawing.Color.White;
            this.btnOpcije.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcije.Image")));
            this.btnOpcije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcije.Location = new System.Drawing.Point(700, 10);
            this.btnOpcije.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpcije.Name = "btnOpcije";
            this.btnOpcije.Size = new System.Drawing.Size(300, 90);
            this.btnOpcije.TabIndex = 3;
            this.btnOpcije.TabStop = false;
            this.btnOpcije.Text = "Opcije";
            this.btnOpcije.UseMnemonic = false;
            this.btnOpcije.UseVisualStyleBackColor = false;
            this.btnOpcije.Click += new System.EventHandler(this.btnOpcije_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatistika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.btnStatistika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistika.FlatAppearance.BorderSize = 0;
            this.btnStatistika.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnStatistika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistika.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStatistika.ForeColor = System.Drawing.Color.White;
            this.btnStatistika.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistika.Image")));
            this.btnStatistika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistika.Location = new System.Drawing.Point(400, 10);
            this.btnStatistika.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(300, 90);
            this.btnStatistika.TabIndex = 2;
            this.btnStatistika.TabStop = false;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseMnemonic = false;
            this.btnStatistika.UseVisualStyleBackColor = false;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnAngazovanje
            // 
            this.btnAngazovanje.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAngazovanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.btnAngazovanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAngazovanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAngazovanje.FlatAppearance.BorderSize = 0;
            this.btnAngazovanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnAngazovanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnAngazovanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAngazovanje.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAngazovanje.ForeColor = System.Drawing.Color.White;
            this.btnAngazovanje.Image = ((System.Drawing.Image)(resources.GetObject("btnAngazovanje.Image")));
            this.btnAngazovanje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAngazovanje.Location = new System.Drawing.Point(100, 10);
            this.btnAngazovanje.Margin = new System.Windows.Forms.Padding(0);
            this.btnAngazovanje.Name = "btnAngazovanje";
            this.btnAngazovanje.Size = new System.Drawing.Size(300, 90);
            this.btnAngazovanje.TabIndex = 1;
            this.btnAngazovanje.TabStop = false;
            this.btnAngazovanje.Text = "Angažovanje";
            this.btnAngazovanje.UseMnemonic = false;
            this.btnAngazovanje.UseVisualStyleBackColor = false;
            this.btnAngazovanje.Click += new System.EventHandler(this.btnAngazovanje_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelForm.Location = new System.Drawing.Point(0, 100);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1200, 700);
            this.panelForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHome;
        private Panel panelButtons;
        private Button btnAngazovanje;
        private Button btnOpcije;
        private Button btnStatistika;
        private Button btnClose;
        private Button btnMinimize;
        private Panel panelForm;
        private Panel dragPanel;
    }
}