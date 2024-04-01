namespace Poliklinika.Forms.SubForms
{
    partial class StatistikaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistikaForm));
            this.rbGrad = new System.Windows.Forms.RadioButton();
            this.rbSpecijalizacija = new System.Windows.Forms.RadioButton();
            this.rbKlinika = new System.Windows.Forms.RadioButton();
            this.gbShow = new System.Windows.Forms.GroupBox();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.fromDate = new NnraTools.CustomCalendar();
            this.lblFromDatuma = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.toDate = new NnraTools.CustomCalendar();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.comBoxSort = new System.Windows.Forms.ComboBox();
            this.gbShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbGrad
            // 
            this.rbGrad.AutoSize = true;
            this.rbGrad.BackColor = System.Drawing.Color.Transparent;
            this.rbGrad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGrad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbGrad.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbGrad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.rbGrad.Location = new System.Drawing.Point(10, 30);
            this.rbGrad.Margin = new System.Windows.Forms.Padding(0);
            this.rbGrad.Name = "rbGrad";
            this.rbGrad.Size = new System.Drawing.Size(105, 30);
            this.rbGrad.TabIndex = 0;
            this.rbGrad.Text = "Po Gradu";
            this.rbGrad.UseVisualStyleBackColor = false;
            this.rbGrad.CheckedChanged += new System.EventHandler(this.rbGrad_CheckedChanged);
            // 
            // rbSpecijalizacija
            // 
            this.rbSpecijalizacija.AutoSize = true;
            this.rbSpecijalizacija.BackColor = System.Drawing.Color.Transparent;
            this.rbSpecijalizacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSpecijalizacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSpecijalizacija.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSpecijalizacija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.rbSpecijalizacija.Location = new System.Drawing.Point(10, 110);
            this.rbSpecijalizacija.Margin = new System.Windows.Forms.Padding(0);
            this.rbSpecijalizacija.Name = "rbSpecijalizacija";
            this.rbSpecijalizacija.Size = new System.Drawing.Size(160, 30);
            this.rbSpecijalizacija.TabIndex = 1;
            this.rbSpecijalizacija.Text = "Po Specijalizaciji";
            this.rbSpecijalizacija.UseVisualStyleBackColor = false;
            this.rbSpecijalizacija.CheckedChanged += new System.EventHandler(this.rbSpecijalizacija_CheckedChanged);
            // 
            // rbKlinika
            // 
            this.rbKlinika.AutoSize = true;
            this.rbKlinika.BackColor = System.Drawing.Color.Transparent;
            this.rbKlinika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbKlinika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbKlinika.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbKlinika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.rbKlinika.Location = new System.Drawing.Point(10, 70);
            this.rbKlinika.Margin = new System.Windows.Forms.Padding(0);
            this.rbKlinika.Name = "rbKlinika";
            this.rbKlinika.Size = new System.Drawing.Size(135, 30);
            this.rbKlinika.TabIndex = 2;
            this.rbKlinika.Text = "Po Klinikama";
            this.rbKlinika.UseVisualStyleBackColor = false;
            this.rbKlinika.CheckedChanged += new System.EventHandler(this.rbKlinikama_CheckedChanged);
            // 
            // gbShow
            // 
            this.gbShow.BackColor = System.Drawing.Color.Transparent;
            this.gbShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbShow.Controls.Add(this.rbGrad);
            this.gbShow.Controls.Add(this.rbKlinika);
            this.gbShow.Controls.Add(this.rbSpecijalizacija);
            this.gbShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbShow.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.gbShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbShow.Location = new System.Drawing.Point(100, 350);
            this.gbShow.Margin = new System.Windows.Forms.Padding(0);
            this.gbShow.Name = "gbShow";
            this.gbShow.Padding = new System.Windows.Forms.Padding(0);
            this.gbShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbShow.Size = new System.Drawing.Size(200, 150);
            this.gbShow.TabIndex = 3;
            this.gbShow.TabStop = false;
            this.gbShow.Text = "Prikaži Po:";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(450, 49);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(650, 600);
            this.cartesianChart1.TabIndex = 4;
            // 
            // fromDate
            // 
            this.fromDate.BorderColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(125)))));
            this.fromDate.BorderColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.fromDate.BorderGradientAngle = 90;
            this.fromDate.BorderSize = 2;
            this.fromDate.CalendarFont = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromDate.CalendarIcon = ((System.Drawing.Image)(resources.GetObject("fromDate.CalendarIcon")));
            this.fromDate.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.fromDate.DropColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(65)))));
            this.fromDate.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Location = new System.Drawing.Point(100, 75);
            this.fromDate.Margin = new System.Windows.Forms.Padding(0);
            this.fromDate.MinimumSize = new System.Drawing.Size(0, 35);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 35);
            this.fromDate.SkinColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.fromDate.SkinColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(125)))));
            this.fromDate.SkinGradientAngle = 90;
            this.fromDate.TabIndex = 5;
            this.fromDate.TabStop = false;
            this.fromDate.TextColor = System.Drawing.Color.White;
            this.fromDate.Value = new System.DateTime(2022, 1, 1, 12, 0, 0, 0);
            this.fromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // lblFromDatuma
            // 
            this.lblFromDatuma.AutoSize = true;
            this.lblFromDatuma.BackColor = System.Drawing.Color.Transparent;
            this.lblFromDatuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFromDatuma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.lblFromDatuma.Location = new System.Drawing.Point(100, 50);
            this.lblFromDatuma.Margin = new System.Windows.Forms.Padding(0);
            this.lblFromDatuma.Name = "lblFromDatuma";
            this.lblFromDatuma.Size = new System.Drawing.Size(88, 19);
            this.lblFromDatuma.TabIndex = 6;
            this.lblFromDatuma.Text = "Od Datuma:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblToDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblToDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.lblToDate.Location = new System.Drawing.Point(100, 200);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(86, 19);
            this.lblToDate.TabIndex = 8;
            this.lblToDate.Text = "Do Datuma:";
            // 
            // toDate
            // 
            this.toDate.BorderColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(125)))));
            this.toDate.BorderColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.toDate.BorderGradientAngle = 90;
            this.toDate.BorderSize = 2;
            this.toDate.CalendarFont = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDate.CalendarIcon = ((System.Drawing.Image)(resources.GetObject("toDate.CalendarIcon")));
            this.toDate.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.toDate.DropColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(65)))));
            this.toDate.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(100, 225);
            this.toDate.Margin = new System.Windows.Forms.Padding(0);
            this.toDate.MinimumSize = new System.Drawing.Size(0, 35);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(200, 35);
            this.toDate.SkinColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.toDate.SkinColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(125)))));
            this.toDate.SkinGradientAngle = 90;
            this.toDate.TabIndex = 7;
            this.toDate.TabStop = false;
            this.toDate.TextColor = System.Drawing.Color.White;
            this.toDate.Value = new System.DateTime(2023, 1, 1, 12, 0, 0, 0);
            this.toDate.ValueChanged += new System.EventHandler(this.toDate_ValueChanged);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.btnPrikazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrikazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrikazi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnPrikazi.FlatAppearance.BorderSize = 2;
            this.btnPrikazi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnPrikazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrikazi.ForeColor = System.Drawing.Color.White;
            this.btnPrikazi.Location = new System.Drawing.Point(100, 600);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrikazi.Size = new System.Drawing.Size(200, 50);
            this.btnPrikazi.TabIndex = 9;
            this.btnPrikazi.TabStop = false;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // comBoxSort
            // 
            this.comBoxSort.BackColor = System.Drawing.Color.White;
            this.comBoxSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSort.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.comBoxSort.FormattingEnabled = true;
            this.comBoxSort.Items.AddRange(new object[] {
            "Po Broju Naviše",
            "Po Broju Naniže",
            "Po Nazivu Naviše",
            "Po Nazivu Naniže"});
            this.comBoxSort.Location = new System.Drawing.Point(100, 525);
            this.comBoxSort.Margin = new System.Windows.Forms.Padding(0);
            this.comBoxSort.Name = "comBoxSort";
            this.comBoxSort.Size = new System.Drawing.Size(200, 27);
            this.comBoxSort.TabIndex = 10;
            this.comBoxSort.TabStop = false;
            this.comBoxSort.SelectedIndexChanged += new System.EventHandler(this.comBoxSort_SelectedIndexChanged);
            // 
            // StatistikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.ControlBox = false;
            this.Controls.Add(this.comBoxSort);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.lblFromDatuma);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.gbShow);
            this.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatistikaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.StatistikaForm_Load);
            this.gbShow.ResumeLayout(false);
            this.gbShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbGrad;
        private RadioButton rbSpecijalizacija;
        private RadioButton rbKlinika;
        private GroupBox gbShow;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private NnraTools.CustomCalendar fromDate;
        private Label lblFromDatuma;
        private Label lblToDate;
        private NnraTools.CustomCalendar toDate;
        private Button btnPrikazi;
        private ComboBox comBoxSort;
    }
}