namespace Poliklinika.Forms.SubForms
{
    partial class HomeForm
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
                Properties.Settings.Default.PropertyChanged -= Default_PropertyChanged;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pbMainLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainLogo
            // 
            this.pbMainLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbMainLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbMainLogo.Image")));
            this.pbMainLogo.Location = new System.Drawing.Point(400, 150);
            this.pbMainLogo.Name = "pbMainLogo";
            this.pbMainLogo.Size = new System.Drawing.Size(400, 400);
            this.pbMainLogo.TabIndex = 0;
            this.pbMainLogo.TabStop = false;
            this.pbMainLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMainLogo_MouseDown);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.ControlBox = false;
            this.Controls.Add(this.pbMainLogo);
            this.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbMainLogo;
    }
}