
namespace tugasakhirpasbd
{
    partial class datapelanggan
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
            this.btnhapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.bttninsert = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.dataGridView_pelanggan = new System.Windows.Forms.DataGridView();
            this.idPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectakhirDataSet = new tugasakhirpasbd.projectakhirDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notelepon = new System.Windows.Forms.TextBox();
            this.namapelanggan = new System.Windows.Forms.TextBox();
            this.idpelanggan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pelangganTableAdapter = new tugasakhirpasbd.projectakhirDataSetTableAdapters.pelangganTableAdapter();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectakhirDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.btnhapus.Location = new System.Drawing.Point(150, 362);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(81, 34);
            this.btnhapus.TabIndex = 60;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(438, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "Search (ID / Nama)";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(573, 192);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(199, 30);
            this.search.TabIndex = 57;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // bttninsert
            // 
            this.bttninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.bttninsert.Location = new System.Drawing.Point(63, 310);
            this.bttninsert.Name = "bttninsert";
            this.bttninsert.Size = new System.Drawing.Size(81, 34);
            this.bttninsert.TabIndex = 55;
            this.bttninsert.Text = "INSERT";
            this.bttninsert.UseVisualStyleBackColor = false;
            this.bttninsert.Click += new System.EventHandler(this.bttninsert_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.btnedit.Location = new System.Drawing.Point(150, 310);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(81, 34);
            this.btnedit.TabIndex = 54;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // dataGridView_pelanggan
            // 
            this.dataGridView_pelanggan.AutoGenerateColumns = false;
            this.dataGridView_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pelanggan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPelangganDataGridViewTextBoxColumn,
            this.namaPelangganDataGridViewTextBoxColumn,
            this.nohpDataGridViewTextBoxColumn});
            this.dataGridView_pelanggan.DataSource = this.pelangganBindingSource;
            this.dataGridView_pelanggan.Location = new System.Drawing.Point(444, 228);
            this.dataGridView_pelanggan.Name = "dataGridView_pelanggan";
            this.dataGridView_pelanggan.Size = new System.Drawing.Size(344, 187);
            this.dataGridView_pelanggan.TabIndex = 53;
            this.dataGridView_pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pelanggan_CellContentClick);
            // 
            // idPelangganDataGridViewTextBoxColumn
            // 
            this.idPelangganDataGridViewTextBoxColumn.DataPropertyName = "IdPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.HeaderText = "IdPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.Name = "idPelangganDataGridViewTextBoxColumn";
            // 
            // namaPelangganDataGridViewTextBoxColumn
            // 
            this.namaPelangganDataGridViewTextBoxColumn.DataPropertyName = "NamaPelanggan";
            this.namaPelangganDataGridViewTextBoxColumn.HeaderText = "NamaPelanggan";
            this.namaPelangganDataGridViewTextBoxColumn.Name = "namaPelangganDataGridViewTextBoxColumn";
            // 
            // nohpDataGridViewTextBoxColumn
            // 
            this.nohpDataGridViewTextBoxColumn.DataPropertyName = "Nohp";
            this.nohpDataGridViewTextBoxColumn.HeaderText = "Nohp";
            this.nohpDataGridViewTextBoxColumn.Name = "nohpDataGridViewTextBoxColumn";
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataMember = "pelanggan";
            this.pelangganBindingSource.DataSource = this.projectakhirDataSet;
            // 
            // projectakhirDataSet
            // 
            this.projectakhirDataSet.DataSetName = "projectakhirDataSet";
            this.projectakhirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.notelepon);
            this.groupBox1.Controls.Add(this.namapelanggan);
            this.groupBox1.Controls.Add(this.idpelanggan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(52, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 167);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Pelanggan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // notelepon
            // 
            this.notelepon.Location = new System.Drawing.Point(162, 111);
            this.notelepon.Name = "notelepon";
            this.notelepon.Size = new System.Drawing.Size(158, 20);
            this.notelepon.TabIndex = 46;
            // 
            // namapelanggan
            // 
            this.namapelanggan.Location = new System.Drawing.Point(162, 76);
            this.namapelanggan.Name = "namapelanggan";
            this.namapelanggan.Size = new System.Drawing.Size(158, 20);
            this.namapelanggan.TabIndex = 45;
            // 
            // idpelanggan
            // 
            this.idpelanggan.Location = new System.Drawing.Point(162, 36);
            this.idpelanggan.Name = "idpelanggan";
            this.idpelanggan.Size = new System.Drawing.Size(158, 20);
            this.idpelanggan.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(18, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "No Telepon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID Pelanggan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tugasakhirpasbd.Properties.Resources._19_198308_back_icon_png_image_free_download_searchpng_transparent_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::tugasakhirpasbd.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(753, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pelangganTableAdapter
            // 
            this.pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.refresh.Location = new System.Drawing.Point(63, 362);
            this.refresh.Name = "refresh";
            this.refresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.refresh.Size = new System.Drawing.Size(81, 34);
            this.refresh.TabIndex = 62;
            this.refresh.Text = "REFRESH";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // datapelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.bttninsert);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView_pelanggan);
            this.Controls.Add(this.groupBox1);
            this.Name = "datapelanggan";
            this.Text = "datapelanggan";
            this.Load += new System.EventHandler(this.datapelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectakhirDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button bttninsert;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.DataGridView dataGridView_pelanggan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox notelepon;
        private System.Windows.Forms.TextBox namapelanggan;
        private System.Windows.Forms.TextBox idpelanggan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private projectakhirDataSet projectakhirDataSet;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private projectakhirDataSetTableAdapters.pelangganTableAdapter pelangganTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refresh;
    }
}