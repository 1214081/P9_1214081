namespace P9_1214081
{
    partial class Form1
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
            this.gbTabel = new System.Windows.Forms.GroupBox();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.cbAngkatan = new System.Windows.Forms.ComboBox();
            this.tbNoHP = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNPM = new System.Windows.Forms.TextBox();
            this.lbNoHP = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAlamat = new System.Windows.Forms.Label();
            this.lbAngkatan = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbNPM = new System.Windows.Forms.Label();
            this.gbPencarian = new System.Windows.Forms.GroupBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.lbCariData = new System.Windows.Forms.Label();
            this.gbTombol = new System.Windows.Forms.GroupBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUbah = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.gbTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.gbForm.SuspendLayout();
            this.gbPencarian.SuspendLayout();
            this.gbTombol.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTabel
            // 
            this.gbTabel.Controls.Add(this.DataMahasiswa);
            this.gbTabel.Location = new System.Drawing.Point(12, 12);
            this.gbTabel.Name = "gbTabel";
            this.gbTabel.Size = new System.Drawing.Size(775, 224);
            this.gbTabel.TabIndex = 1;
            this.gbTabel.TabStop = false;
            this.gbTabel.Text = "Tabel Data Mahasiswa";
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(6, 26);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.Size = new System.Drawing.Size(762, 198);
            this.DataMahasiswa.TabIndex = 0;
            this.DataMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellClick);
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.cbAngkatan);
            this.gbForm.Controls.Add(this.tbNoHP);
            this.gbForm.Controls.Add(this.tbEmail);
            this.gbForm.Controls.Add(this.tbAlamat);
            this.gbForm.Controls.Add(this.tbNama);
            this.gbForm.Controls.Add(this.tbNPM);
            this.gbForm.Controls.Add(this.lbNoHP);
            this.gbForm.Controls.Add(this.lbEmail);
            this.gbForm.Controls.Add(this.lbAlamat);
            this.gbForm.Controls.Add(this.lbAngkatan);
            this.gbForm.Controls.Add(this.lbNama);
            this.gbForm.Controls.Add(this.lbNPM);
            this.gbForm.Location = new System.Drawing.Point(12, 254);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(471, 270);
            this.gbForm.TabIndex = 5;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Form Data Mahasiswa";
            // 
            // cbAngkatan
            // 
            this.cbAngkatan.FormattingEnabled = true;
            this.cbAngkatan.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbAngkatan.Location = new System.Drawing.Point(116, 93);
            this.cbAngkatan.Name = "cbAngkatan";
            this.cbAngkatan.Size = new System.Drawing.Size(280, 21);
            this.cbAngkatan.TabIndex = 11;
            // 
            // tbNoHP
            // 
            this.tbNoHP.Location = new System.Drawing.Point(116, 226);
            this.tbNoHP.Name = "tbNoHP";
            this.tbNoHP.Size = new System.Drawing.Size(280, 20);
            this.tbNoHP.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(116, 192);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(280, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(116, 127);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(280, 47);
            this.tbAlamat.TabIndex = 8;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(116, 59);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(280, 20);
            this.tbNama.TabIndex = 7;
            // 
            // tbNPM
            // 
            this.tbNPM.Location = new System.Drawing.Point(116, 25);
            this.tbNPM.Name = "tbNPM";
            this.tbNPM.Size = new System.Drawing.Size(280, 20);
            this.tbNPM.TabIndex = 6;
            // 
            // lbNoHP
            // 
            this.lbNoHP.AutoSize = true;
            this.lbNoHP.Location = new System.Drawing.Point(6, 229);
            this.lbNoHP.Name = "lbNoHP";
            this.lbNoHP.Size = new System.Drawing.Size(39, 13);
            this.lbNoHP.TabIndex = 5;
            this.lbNoHP.Text = "No HP";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(7, 195);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // lbAlamat
            // 
            this.lbAlamat.AutoSize = true;
            this.lbAlamat.Location = new System.Drawing.Point(6, 130);
            this.lbAlamat.Name = "lbAlamat";
            this.lbAlamat.Size = new System.Drawing.Size(39, 13);
            this.lbAlamat.TabIndex = 3;
            this.lbAlamat.Text = "Alamat";
            // 
            // lbAngkatan
            // 
            this.lbAngkatan.AutoSize = true;
            this.lbAngkatan.Location = new System.Drawing.Point(6, 96);
            this.lbAngkatan.Name = "lbAngkatan";
            this.lbAngkatan.Size = new System.Drawing.Size(53, 13);
            this.lbAngkatan.TabIndex = 2;
            this.lbAngkatan.Text = "Angkatan";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(6, 62);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(35, 13);
            this.lbNama.TabIndex = 1;
            this.lbNama.Text = "Nama";
            // 
            // lbNPM
            // 
            this.lbNPM.AutoSize = true;
            this.lbNPM.Location = new System.Drawing.Point(6, 28);
            this.lbNPM.Name = "lbNPM";
            this.lbNPM.Size = new System.Drawing.Size(31, 13);
            this.lbNPM.TabIndex = 0;
            this.lbNPM.Text = "NPM";
            // 
            // gbPencarian
            // 
            this.gbPencarian.Controls.Add(this.tbCari);
            this.gbPencarian.Controls.Add(this.lbCariData);
            this.gbPencarian.Location = new System.Drawing.Point(516, 257);
            this.gbPencarian.Name = "gbPencarian";
            this.gbPencarian.Size = new System.Drawing.Size(264, 76);
            this.gbPencarian.TabIndex = 6;
            this.gbPencarian.TabStop = false;
            this.gbPencarian.Text = "Pencarian";
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(74, 29);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(172, 20);
            this.tbCari.TabIndex = 1;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // lbCariData
            // 
            this.lbCariData.AutoSize = true;
            this.lbCariData.Location = new System.Drawing.Point(7, 32);
            this.lbCariData.Name = "lbCariData";
            this.lbCariData.Size = new System.Drawing.Size(51, 13);
            this.lbCariData.TabIndex = 0;
            this.lbCariData.Text = "Cari Data";
            // 
            // gbTombol
            // 
            this.gbTombol.Controls.Add(this.btHapus);
            this.gbTombol.Controls.Add(this.btUbah);
            this.gbTombol.Controls.Add(this.btSimpan);
            this.gbTombol.Controls.Add(this.btRefresh);
            this.gbTombol.Location = new System.Drawing.Point(523, 347);
            this.gbTombol.Name = "gbTombol";
            this.gbTombol.Size = new System.Drawing.Size(264, 177);
            this.gbTombol.TabIndex = 13;
            this.gbTombol.TabStop = false;
            this.gbTombol.Text = "Tombol Action";
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(6, 139);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(252, 23);
            this.btHapus.TabIndex = 3;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btUbah
            // 
            this.btUbah.Location = new System.Drawing.Point(6, 102);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(252, 23);
            this.btUbah.TabIndex = 2;
            this.btUbah.Text = "Ubah";
            this.btUbah.UseVisualStyleBackColor = true;
            this.btUbah.Click += new System.EventHandler(this.btUbah_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(6, 65);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(252, 23);
            this.btSimpan.TabIndex = 1;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(6, 28);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(252, 23);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.gbTombol);
            this.Controls.Add(this.gbPencarian);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.gbTabel);
            this.Name = "Form1";
            this.Text = "Data Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.gbPencarian.ResumeLayout(false);
            this.gbPencarian.PerformLayout();
            this.gbTombol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTabel;
        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.ComboBox cbAngkatan;
        private System.Windows.Forms.TextBox tbNoHP;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNPM;
        private System.Windows.Forms.Label lbNoHP;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAlamat;
        private System.Windows.Forms.Label lbAngkatan;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbNPM;
        private System.Windows.Forms.GroupBox gbPencarian;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label lbCariData;
        private System.Windows.Forms.GroupBox gbTombol;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btRefresh;
    }
}

