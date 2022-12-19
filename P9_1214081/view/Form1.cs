using P9_1214081.controller;
using P9_1214081.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static P9_1214081.model.M_Mahasiswa;

namespace P9_1214081
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();
        string id;
        public void tampil()
        {
            //Query Database
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");

            //Mengubah nama header
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNPM.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbAngkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbNoHP.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            tampil();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (tbNPM.Text == "" || tbNama.Text == "" || cbAngkatan.SelectedIndex == -1 || tbAlamat.Text == "" || tbEmail.Text == "" || tbNoHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = tbNPM.Text;
                m_mhs.Nama = tbNama.Text;
                m_mhs.Angkatan = cbAngkatan.Text;
                m_mhs.Alamat = tbAlamat.Text;
                m_mhs.Email = tbEmail.Text;
                m_mhs.Nohp = tbNoHP.Text;

                mhs.Insert(m_mhs);

                tbNPM.Text = "";
                tbNama.Text = "";
                cbAngkatan.SelectedIndex = -1;
                tbAlamat.Text = "";
                tbEmail.Text = "";
                tbNoHP.Text = "";
            }
        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            if (tbNPM.Text == "" || tbNama.Text == "" || cbAngkatan.SelectedIndex == -1 || tbAlamat.Text == "" || tbEmail.Text == "" || tbNoHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = tbNPM.Text;
                m_mhs.Nama = tbNama.Text;
                m_mhs.Angkatan = cbAngkatan.Text;
                m_mhs.Alamat = tbAlamat.Text;
                m_mhs.Email = tbEmail.Text;
                m_mhs.Nohp = tbNoHP.Text;

                mhs.Update(m_mhs, id);

                tbNPM.Text = "";
                tbNama.Text = "";
                cbAngkatan.SelectedIndex = -1;
                tbAlamat.Text = "";
                tbEmail.Text = "";
                tbNoHP.Text = "";
            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus data", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(id);
            }
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT* FROM t_mahasiswa WHERE npm LIKE '%' '" + tbCari.Text + "' '%' OR nama LIKE '%' '" + tbCari.Text + "' '%'");
        }
    }
}
