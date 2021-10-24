namespace qasimpos
{
    partial class Form8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.dataGridView12 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HukamColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PpriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WpriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RpriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView12
            // 
            this.dataGridView12.AllowUserToAddRows = false;
            this.dataGridView12.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView12.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView12.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView12.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView12.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView12.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView12.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView12.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.DateColumn,
            this.CompanyColumn,
            this.PartyColumn,
            this.HukamColumn,
            this.KgColumn,
            this.PcsColumn,
            this.PpriceColumn,
            this.CpriceColumn,
            this.WpriceColumn,
            this.RpriceColumn,
            this.BillnColumn});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView12.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView12.EnableHeadersVisualStyles = false;
            this.dataGridView12.Location = new System.Drawing.Point(12, 70);
            this.dataGridView12.Name = "dataGridView12";
            this.dataGridView12.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView12.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView12.Size = new System.Drawing.Size(1119, 552);
            this.dataGridView12.TabIndex = 9;
            this.dataGridView12.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView11_CellContentClick);
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameColumn.DataPropertyName = "namee";
            this.NameColumn.FillWeight = 30F;
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "نام";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 120;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateColumn.DataPropertyName = "tareekh";
            this.DateColumn.FillWeight = 28F;
            this.DateColumn.Frozen = true;
            this.DateColumn.HeaderText = "تاریخ";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 140;
            // 
            // CompanyColumn
            // 
            this.CompanyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CompanyColumn.DataPropertyName = "company";
            this.CompanyColumn.FillWeight = 11.90609F;
            this.CompanyColumn.Frozen = true;
            this.CompanyColumn.HeaderText = "کمپنی";
            this.CompanyColumn.Name = "CompanyColumn";
            this.CompanyColumn.ReadOnly = true;
            this.CompanyColumn.Width = 78;
            // 
            // PartyColumn
            // 
            this.PartyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PartyColumn.DataPropertyName = "party";
            this.PartyColumn.FillWeight = 11.90609F;
            this.PartyColumn.Frozen = true;
            this.PartyColumn.HeaderText = "پارٹی";
            this.PartyColumn.Name = "PartyColumn";
            this.PartyColumn.ReadOnly = true;
            this.PartyColumn.Width = 78;
            // 
            // HukamColumn
            // 
            this.HukamColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HukamColumn.DataPropertyName = "hukam";
            this.HukamColumn.FillWeight = 11.90609F;
            this.HukamColumn.Frozen = true;
            this.HukamColumn.HeaderText = "مال خرید";
            this.HukamColumn.MinimumWidth = 4;
            this.HukamColumn.Name = "HukamColumn";
            this.HukamColumn.ReadOnly = true;
            this.HukamColumn.Width = 77;
            // 
            // KgColumn
            // 
            this.KgColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KgColumn.DataPropertyName = "kg";
            this.KgColumn.FillWeight = 11.90609F;
            this.KgColumn.Frozen = true;
            this.KgColumn.HeaderText = "نگ وزن";
            this.KgColumn.Name = "KgColumn";
            this.KgColumn.ReadOnly = true;
            this.KgColumn.Width = 78;
            // 
            // PcsColumn
            // 
            this.PcsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PcsColumn.DataPropertyName = "PCS";
            this.PcsColumn.FillWeight = 11.90609F;
            this.PcsColumn.Frozen = true;
            this.PcsColumn.HeaderText = "پیس";
            this.PcsColumn.Name = "PcsColumn";
            this.PcsColumn.ReadOnly = true;
            this.PcsColumn.Width = 78;
            // 
            // PpriceColumn
            // 
            this.PpriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PpriceColumn.DataPropertyName = "pprice";
            this.PpriceColumn.FillWeight = 11.90609F;
            this.PpriceColumn.Frozen = true;
            this.PpriceColumn.HeaderText = "قیمت خرید";
            this.PpriceColumn.Name = "PpriceColumn";
            this.PpriceColumn.ReadOnly = true;
            this.PpriceColumn.Width = 78;
            // 
            // CpriceColumn
            // 
            this.CpriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CpriceColumn.DataPropertyName = "cprice";
            this.CpriceColumn.FillWeight = 11.90609F;
            this.CpriceColumn.Frozen = true;
            this.CpriceColumn.HeaderText = " مجودہ قیمت";
            this.CpriceColumn.Name = "CpriceColumn";
            this.CpriceColumn.ReadOnly = true;
            this.CpriceColumn.Width = 78;
            // 
            // WpriceColumn
            // 
            this.WpriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WpriceColumn.DataPropertyName = "wprice";
            this.WpriceColumn.FillWeight = 11.90609F;
            this.WpriceColumn.Frozen = true;
            this.WpriceColumn.HeaderText = "ھول سیل ریٹ";
            this.WpriceColumn.Name = "WpriceColumn";
            this.WpriceColumn.ReadOnly = true;
            this.WpriceColumn.Width = 77;
            // 
            // RpriceColumn
            // 
            this.RpriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RpriceColumn.DataPropertyName = "rprice";
            this.RpriceColumn.FillWeight = 11.90609F;
            this.RpriceColumn.Frozen = true;
            this.RpriceColumn.HeaderText = "پرچون ریٹ";
            this.RpriceColumn.Name = "RpriceColumn";
            this.RpriceColumn.ReadOnly = true;
            this.RpriceColumn.Width = 78;
            // 
            // BillnColumn
            // 
            this.BillnColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BillnColumn.DataPropertyName = "billn";
            this.BillnColumn.FillWeight = 11.90609F;
            this.BillnColumn.Frozen = true;
            this.BillnColumn.HeaderText = "بل نمبر";
            this.BillnColumn.Name = "BillnColumn";
            this.BillnColumn.ReadOnly = true;
            this.BillnColumn.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "All Products";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(1254, 12);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 10;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(557, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Records: ";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 634);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.dataGridView12);
            this.Name = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView12;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HukamColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KgColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PpriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WpriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RpriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillnColumn;
        private System.Windows.Forms.Label label2;
    }
}