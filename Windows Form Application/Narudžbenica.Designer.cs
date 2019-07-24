namespace WindowsFormsApplication2
{
    partial class Narudžbenica
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
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDobavljačaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivProizvodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.količinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivProzvođačaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudženicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudženicaDataSet = new WindowsFormsApplication2.NarudženicaDataSet();
            this.narudženicaTableAdapter = new WindowsFormsApplication2.NarudženicaDataSetTableAdapters.NarudženicaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudženicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudženicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(690, 38);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Gray;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDobavljačaDataGridViewTextBoxColumn,
            this.nazivProizvodaDataGridViewTextBoxColumn,
            this.količinaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.nazivProzvođačaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narudženicaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 377);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nazivDobavljačaDataGridViewTextBoxColumn
            // 
            this.nazivDobavljačaDataGridViewTextBoxColumn.DataPropertyName = "Naziv dobavljača";
            this.nazivDobavljačaDataGridViewTextBoxColumn.HeaderText = "Naziv dobavljača";
            this.nazivDobavljačaDataGridViewTextBoxColumn.Name = "nazivDobavljačaDataGridViewTextBoxColumn";
            // 
            // nazivProizvodaDataGridViewTextBoxColumn
            // 
            this.nazivProizvodaDataGridViewTextBoxColumn.DataPropertyName = "Naziv proizvoda";
            this.nazivProizvodaDataGridViewTextBoxColumn.HeaderText = "Naziv proizvoda";
            this.nazivProizvodaDataGridViewTextBoxColumn.Name = "nazivProizvodaDataGridViewTextBoxColumn";
            // 
            // količinaDataGridViewTextBoxColumn
            // 
            this.količinaDataGridViewTextBoxColumn.DataPropertyName = "Količina";
            this.količinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.količinaDataGridViewTextBoxColumn.Name = "količinaDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // nazivProzvođačaDataGridViewTextBoxColumn
            // 
            this.nazivProzvođačaDataGridViewTextBoxColumn.DataPropertyName = "Naziv prozvođača";
            this.nazivProzvođačaDataGridViewTextBoxColumn.HeaderText = "Naziv prozvođača";
            this.nazivProzvođačaDataGridViewTextBoxColumn.Name = "nazivProzvođačaDataGridViewTextBoxColumn";
            // 
            // narudženicaBindingSource
            // 
            this.narudženicaBindingSource.DataMember = "Narudženica";
            this.narudženicaBindingSource.DataSource = this.narudženicaDataSet;
            // 
            // narudženicaDataSet
            // 
            this.narudženicaDataSet.DataSetName = "NarudženicaDataSet";
            this.narudženicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudženicaTableAdapter
            // 
            this.narudženicaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "ŠTAMPAJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(403, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "NAZAD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(732, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "IZLAZ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Narudžbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(940, 591);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Narudžbenica";
            this.Text = "NARUDŽBENICA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudženicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudženicaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NarudženicaDataSet narudženicaDataSet;
        private System.Windows.Forms.BindingSource narudženicaBindingSource;
        private NarudženicaDataSetTableAdapters.NarudženicaTableAdapter narudženicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDobavljačaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivProizvodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn količinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivProzvođačaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}