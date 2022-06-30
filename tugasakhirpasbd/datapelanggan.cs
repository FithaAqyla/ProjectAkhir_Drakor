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
    public partial class datapelanggan : Form
    {
        public datapelanggan()
        {
            InitializeComponent();
        }

        private void datapelanggan_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
            // TODO: This line of code loads data into the 'projectakhirDataSet.pelanggan' table. You can move, or remove it, as needed.
            //this.pelangganTableAdapter.Fill(this.projectakhirDataSet.pelanggan);

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS5OAOK;initial Catalog=projectakhir;User ID=sa;Password=123");

        private void btnhapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string idpelanggn = idpelanggan.Text;
            SqlCommand com = new SqlCommand("exec SP_pelanggan_Delete '" +  idpelanggan.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            LoadAllRecords();
            MessageBox.Show("Successfully Delete");
        }
        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec SP_pelanggan_View ", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_pelanggan.DataSource = dt;

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec SP_pelanggan_Update '" + idpelanggan.Text + "','" + namapelanggan.Text + "','" + notelepon.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            LoadAllRecords();
            MessageBox.Show("Successfully Update");
        }

        private void bttninsert_Click(object sender, EventArgs e)
        {
            int idplnggn = int.Parse(idpelanggan.Text);
            string nmplnggn = namapelanggan.Text, no = notelepon.Text;
            con.Open();
            SqlCommand com = new SqlCommand("exec SP_pelanggan_Insert '" + idplnggn + "','" + nmplnggn + "','" + no + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            LoadAllRecords();
            MessageBox.Show("Successfully Saved");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home backhome = new home();
            backhome.Show();
        }

        private void dataGridView_pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_pelanggan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView_pelanggan.CurrentRow.Selected = true;
                idpelanggan.Text = dataGridView_pelanggan.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                namapelanggan.Text = dataGridView_pelanggan.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                notelepon.Text = dataGridView_pelanggan.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            idpelanggan.Text = "";
            namapelanggan.Text = "";
            notelepon.Text = "";

            idpelanggan.Focus();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM pelanggan Where IdPelanggan LIKE ' %" + search.Text + "% ' OR NamaPelanggan LIKE ' % " + search.Text + " % ' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_pelanggan.DataSource = dt;
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
