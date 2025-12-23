namespace MemoWords
{
    partial class Kelime_Listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kelime_Listesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sıraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingilizceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.türkçeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelimelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingilizce_kelimeDataSet = new MemoWords.ingilizce_kelimeDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.kelimelerTableAdapter = new MemoWords.ingilizce_kelimeDataSetTableAdapters.kelimelerTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingilizce_kelimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sıraDataGridViewTextBoxColumn,
            this.ingilizceDataGridViewTextBoxColumn,
            this.türkçeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kelimelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 626);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sıraDataGridViewTextBoxColumn
            // 
            this.sıraDataGridViewTextBoxColumn.DataPropertyName = "sıra";
            this.sıraDataGridViewTextBoxColumn.HeaderText = "sıra";
            this.sıraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sıraDataGridViewTextBoxColumn.Name = "sıraDataGridViewTextBoxColumn";
            this.sıraDataGridViewTextBoxColumn.ReadOnly = true;
            this.sıraDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingilizceDataGridViewTextBoxColumn
            // 
            this.ingilizceDataGridViewTextBoxColumn.DataPropertyName = "ingilizce";
            this.ingilizceDataGridViewTextBoxColumn.HeaderText = "ingilizce";
            this.ingilizceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingilizceDataGridViewTextBoxColumn.Name = "ingilizceDataGridViewTextBoxColumn";
            this.ingilizceDataGridViewTextBoxColumn.Width = 200;
            // 
            // türkçeDataGridViewTextBoxColumn
            // 
            this.türkçeDataGridViewTextBoxColumn.DataPropertyName = "türkçe";
            this.türkçeDataGridViewTextBoxColumn.HeaderText = "türkçe";
            this.türkçeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.türkçeDataGridViewTextBoxColumn.Name = "türkçeDataGridViewTextBoxColumn";
            this.türkçeDataGridViewTextBoxColumn.Width = 250;
            // 
            // kelimelerBindingSource
            // 
            this.kelimelerBindingSource.DataMember = "kelimeler";
            this.kelimelerBindingSource.DataSource = this.ingilizce_kelimeDataSet;
            // 
            // ingilizce_kelimeDataSet
            // 
            this.ingilizce_kelimeDataSet.DataSetName = "ingilizce_kelimeDataSet";
            this.ingilizce_kelimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "İngilizce:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(762, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 36);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(762, 372);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 36);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kelime Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(762, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kelime Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(762, 590);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "Anasayfaya Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "İngilizce:";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // kelimelerTableAdapter
            // 
            this.kelimelerTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MemoWords.Properties.Resources.resim;
            this.pictureBox1.Location = new System.Drawing.Point(678, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(710, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 43);
            this.label4.TabIndex = 10;
            this.label4.Text = "WORDLE";
            // 
            // Kelime_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(996, 650);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kelime_Listesi";
            this.Text = "WORDLE";
            this.Load += new System.EventHandler(this.Kelime_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingilizce_kelimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private ingilizce_kelimeDataSet ingilizce_kelimeDataSet;
        private System.Windows.Forms.BindingSource kelimelerBindingSource;
        private ingilizce_kelimeDataSetTableAdapters.kelimelerTableAdapter kelimelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sıraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingilizceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn türkçeDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}