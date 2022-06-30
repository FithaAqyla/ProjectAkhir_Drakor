using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasakhirpasbd
{
    public partial class transaksi : Form
    {
        public transaksi()
        {
            InitializeComponent();
            Fill_ComboBox_Pelanggan();
            Fill_ComboBox_Film();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS5OAOK;initial Catalog=projectakhir;User ID=sa;Password=123");

        void Fill_ComboBox_Pelanggan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM pelanggan", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            con.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);

            id_pelanggan.DisplayMember = "IdPelanggan";
            id_pelanggan.DataSource = dt;
            con.Close();
        }

        void Fill_ComboBox_Film()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM listdrakor", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            con.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);

            id_film.DisplayMember = "IDFilm";
            id_film.DataSource = dt;
            con.Close();
        }

        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("SELECT * FROM transaksi", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeKasir kasir = new homeKasir();
            kasir.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void transaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectakhirDataSet3.transaksi' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'projectakhirDataSetTransaksi.transaksi' table. You can move, or remove it, as needed.
            LoadAllRecords();

            no_kwitansi.Focus();

            textBox_namapelanggan.Enabled = false;
            judul.Enabled = false;
            textBox_hargabarang.Enabled = false;

        }

        private void hitung_Click(object sender, EventArgs e)
        {
            int hitung1, hitung2, hasil;

            hitung1 = int.Parse(textBox_jumlahbarang.Text);
            hitung2 = int.Parse(textBox_hargabarang.Text);

            hasil = hitung1 * hitung2;

            total.Text = hasil.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                no_kwitansi.Text = dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                dateTimePicker1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                id_pelanggan.Text = dataGridView2.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                textBox_namapelanggan.Text = dataGridView2.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                id_film.Text = dataGridView2.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                judul.Text = dataGridView2.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                textBox_hargabarang.Text = dataGridView2.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                textBox_jumlahbarang.Text = dataGridView2.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                total.Text = dataGridView2.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            }
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO transaksi (NoKwitansi, TglKwitansi,IdPelanggan, Nama_Pelanggan, IDFilm, Judul, Harga, Jumlah, TotalHarga) Values " +
                "('" + no_kwitansi.Text + "', '" + dateTimePicker1.Text + "', '" + id_pelanggan.Text + "', '" + textBox_namapelanggan.Text + "', '" + id_film.Text + "', '" + judul.Text + "', '" + textBox_hargabarang.Text + "'" +
                ",'" + textBox_jumlahbarang.Text + "', '" + total.Text + "') ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadAllRecords();
            MessageBox.Show("Sukses Pesan Tiket");
        }

        private void id_pelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS5OAOK;initial Catalog=projectakhir;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("SELECT * FROM pelanggan where IdPelanggan = '" + id_pelanggan.Text + "'", con);
            SqlDataReader sdr;

            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                textBox_namapelanggan.Text = sdr.GetString(1);
            }
        }

        private void id_film_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS5OAOK;initial Catalog=projectakhir;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand("SELECT * FROM listdrakor where IDFilm = '" + id_film.Text + "'", con);
            SqlDataReader sdr;

            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                judul.Text = sdr.GetString(1);
                textBox_hargabarang.Text = sdr.GetInt32(3).ToString();
            }
        }

        private void textBox_jumlahbarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            no_kwitansi.Text = "";
            dateTimePicker1.Text = "";
            id_pelanggan.Text = "";
            textBox_namapelanggan.Text = "";
            id_film.Text = "";
            judul.Text = "";
            textBox_hargabarang.Text = "";
            textBox_jumlahbarang.Text = "";
            total.Text = "";

            no_kwitansi.Focus();
        }
    }
}
