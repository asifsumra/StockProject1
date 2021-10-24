namespace qasimpos
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.NameeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareekhColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.EditColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.iconcerrar);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 44);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH PRODUCT BY NAME";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(24, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(659, 29);
            this.textBox1.TabIndex = 0;
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(1252, 11);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 3;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(51, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(659, 29);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView11
            // 
            this.dataGridView11.AllowUserToAddRows = false;
            this.dataGridView11.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView11.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView11.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView11.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView11.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameeColumn,
            this.tareekhColumn,
            this.CompanyColumn,
            this.PartyColumn,
            this.HukamColumn,
            this.KgColumn,
            this.PcsColumn,
            this.PpriceColumn,
            this.CpriceColumn,
            this.WpriceColumn,
            this.RpriceColumn,
            this.BillnColumn,
            this.EditColumnButton,
            this.DeleteColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView11.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView11.EnableHeadersVisualStyles = false;
            this.dataGridView11.Location = new System.Drawing.Point(2, 89);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView11.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView11.Size = new System.Drawing.Size(1270, 625);
            this.dataGridView11.TabIndex = 8;
            this.dataGridView11.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView11_CellClick);
            this.dataGridView11.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView11_CellContentClick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label22.Location = new System.Drawing.Point(716, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(249, 37);
            this.label22.TabIndex = 13;
            this.label22.Text = "Total Records: ";
            // 
            // NameeColumn
            // 
            this.NameeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameeColumn.DataPropertyName = "namee";
            this.NameeColumn.FillWeight = 15F;
            this.NameeColumn.Frozen = true;
            this.NameeColumn.HeaderText = "نام";
            this.NameeColumn.Name = "NameeColumn";
            this.NameeColumn.ReadOnly = true;
            this.NameeColumn.Width = 105;
            // 
            // tareekhColumn
            // 
            this.tareekhColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tareekhColumn.DataPropertyName = "tareekh";
            this.tareekhColumn.FillWeight = 15F;
            this.tareekhColumn.Frozen = true;
            this.tareekhColumn.HeaderText = "تاریخ";
            this.tareekhColumn.Name = "tareekhColumn";
            this.tareekhColumn.ReadOnly = true;
            this.tareekhColumn.Width = 110;
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
            this.CompanyColumn.Width = 95;
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
            this.PartyColumn.Width = 90;
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
            this.HukamColumn.Width = 75;
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
            this.KgColumn.Width = 75;
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
            this.PcsColumn.Width = 75;
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
            this.PpriceColumn.Width = 75;
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
            this.CpriceColumn.Width = 75;
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
            this.WpriceColumn.Width = 75;
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
            this.RpriceColumn.Width = 75;
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
            this.BillnColumn.Width = 75;
            // 
            // EditColumnButton
            // 
            this.EditColumnButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditColumnButton.FillWeight = 11.90609F;
            this.EditColumnButton.Frozen = true;
            this.EditColumnButton.HeaderText = "Edit";
            this.EditColumnButton.Name = "EditColumnButton";
            this.EditColumnButton.ReadOnly = true;
            this.EditColumnButton.Text = "Edit";
            this.EditColumnButton.UseColumnTextForButtonValue = true;
            this.EditColumnButton.Width = 75;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteColumn.FillWeight = 11.90609F;
            this.DeleteColumn.Frozen = true;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 75;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dataGridView11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            this.Activated += new System.EventHandler(this.Form7_Activated);
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareekhColumn;
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
        private System.Windows.Forms.DataGridViewButtonColumn EditColumnButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}