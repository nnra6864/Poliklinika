namespace Poliklinika
{
    partial class AngazovanjeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comBoxSpecijalizacija = new System.Windows.Forms.ComboBox();
            this.comBoxLekar = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvDoktori = new System.Windows.Forms.DataGridView();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klinika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSpecijalizacija = new System.Windows.Forms.Label();
            this.lblLekar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktori)).BeginInit();
            this.SuspendLayout();
            // 
            // comBoxSpecijalizacija
            // 
            this.comBoxSpecijalizacija.BackColor = System.Drawing.Color.White;
            this.comBoxSpecijalizacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comBoxSpecijalizacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSpecijalizacija.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxSpecijalizacija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.comBoxSpecijalizacija.FormattingEnabled = true;
            this.comBoxSpecijalizacija.Location = new System.Drawing.Point(100, 80);
            this.comBoxSpecijalizacija.Margin = new System.Windows.Forms.Padding(0);
            this.comBoxSpecijalizacija.Name = "comBoxSpecijalizacija";
            this.comBoxSpecijalizacija.Size = new System.Drawing.Size(300, 34);
            this.comBoxSpecijalizacija.TabIndex = 0;
            this.comBoxSpecijalizacija.TabStop = false;
            this.comBoxSpecijalizacija.SelectedIndexChanged += new System.EventHandler(this.comBoxSpecijalizacija_SelectedIndexChanged);
            // 
            // comBoxLekar
            // 
            this.comBoxLekar.BackColor = System.Drawing.Color.White;
            this.comBoxLekar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comBoxLekar.DisplayMember = "ImeIPrezime";
            this.comBoxLekar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLekar.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxLekar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.comBoxLekar.FormattingEnabled = true;
            this.comBoxLekar.Location = new System.Drawing.Point(100, 330);
            this.comBoxLekar.Margin = new System.Windows.Forms.Padding(0);
            this.comBoxLekar.Name = "comBoxLekar";
            this.comBoxLekar.Size = new System.Drawing.Size(300, 34);
            this.comBoxLekar.TabIndex = 1;
            this.comBoxLekar.TabStop = false;
            this.comBoxLekar.SelectedIndexChanged += new System.EventHandler(this.comBoxLekar_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(100, 600);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(300, 50);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvDoktori
            // 
            this.dgvDoktori.AllowUserToAddRows = false;
            this.dgvDoktori.AllowUserToDeleteRows = false;
            this.dgvDoktori.AllowUserToResizeColumns = false;
            this.dgvDoktori.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDoktori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoktori.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.dgvDoktori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoktori.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoktori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoktori.ColumnHeadersHeight = 25;
            this.dgvDoktori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDoktori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grad,
            this.Klinika,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoktori.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoktori.EnableHeadersVisualStyles = false;
            this.dgvDoktori.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.dgvDoktori.Location = new System.Drawing.Point(450, 50);
            this.dgvDoktori.Margin = new System.Windows.Forms.Padding(0);
            this.dgvDoktori.Name = "dgvDoktori";
            this.dgvDoktori.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoktori.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoktori.RowHeadersWidth = 50;
            this.dgvDoktori.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDoktori.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDoktori.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.dgvDoktori.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvDoktori.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDoktori.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.dgvDoktori.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDoktori.RowTemplate.Height = 25;
            this.dgvDoktori.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoktori.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDoktori.Size = new System.Drawing.Size(665, 600);
            this.dgvDoktori.TabIndex = 3;
            this.dgvDoktori.TabStop = false;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.Width = 275;
            // 
            // Klinika
            // 
            this.Klinika.DataPropertyName = "Klinika";
            this.Klinika.HeaderText = "Klinika";
            this.Klinika.Name = "Klinika";
            this.Klinika.ReadOnly = true;
            this.Klinika.Width = 275;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 50;
            // 
            // lblSpecijalizacija
            // 
            this.lblSpecijalizacija.AutoSize = true;
            this.lblSpecijalizacija.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecijalizacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSpecijalizacija.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpecijalizacija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.lblSpecijalizacija.Location = new System.Drawing.Point(100, 50);
            this.lblSpecijalizacija.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpecijalizacija.Name = "lblSpecijalizacija";
            this.lblSpecijalizacija.Size = new System.Drawing.Size(130, 26);
            this.lblSpecijalizacija.TabIndex = 4;
            this.lblSpecijalizacija.Text = "Specijalizacija:";
            // 
            // lblLekar
            // 
            this.lblLekar.AutoSize = true;
            this.lblLekar.BackColor = System.Drawing.Color.Transparent;
            this.lblLekar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLekar.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLekar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.lblLekar.Location = new System.Drawing.Point(100, 300);
            this.lblLekar.Margin = new System.Windows.Forms.Padding(0);
            this.lblLekar.Name = "lblLekar";
            this.lblLekar.Size = new System.Drawing.Size(64, 26);
            this.lblLekar.TabIndex = 5;
            this.lblLekar.Text = "Lekar:";
            // 
            // AngazovanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.ControlBox = false;
            this.Controls.Add(this.lblLekar);
            this.Controls.Add(this.lblSpecijalizacija);
            this.Controls.Add(this.dgvDoktori);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comBoxLekar);
            this.Controls.Add(this.comBoxSpecijalizacija);
            this.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AngazovanjeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Angazovanje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAngazovanje_FormClosed);
            this.Load += new System.EventHandler(this.FormAngazovanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comBoxSpecijalizacija;
        private ComboBox comBoxLekar;
        private Button btnUpdate;
        private DataGridView dgvDoktori;
        private Label lblSpecijalizacija;
        private Label lblLekar;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Klinika;
        private DataGridViewCheckBoxColumn Status;
    }
}