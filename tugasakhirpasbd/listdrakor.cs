using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasakhirpasbd
{
    public partial class listdrakor : Form
    {
        public listdrakor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS5OAOK;initial Catalog=projectakhir;User ID=sa;Password=123");

        string imglocation = "";
        SqlCommand cmd;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listdrakor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectakhirDataSet3.listdrakor' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'projectakhirDataSet2.listdrakor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'projectakhirDataSet1.listdrakor' table. You can move, or remove it, as needed.
            //this.listdrakorTableAdapter1.Fill(this.projectakhirDataSet1.listdrakor);
            // TODO: This line of code loads data into the 'exeCRUDDataSet.listdrakor' table. You can move, or remove it, as needed.
            //this.listdrakorTableAdapter.Fill(this.exeCRUDDataSet.listdrakor);
            LoadAllRecords();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = int.Parse(harga.Text);
            con.Open();
            SqlCommand com = new SqlCommand("exec SP_listdrakor_Insert '" + id_film.Text + "','" + judul.Text + "','" + genre.Text+"','" + harga.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            LoadAllRecords();
            MessageBox.Show("Successfully Saved");

            

            //string sqlQuery = "insert into "
        }
        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec SP_listdrakor_View ", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec SP_listdrakor_Update '" + id_film.Text + "','" + judul.Text + "','" + genre.Text + "','" + harga.Text +"'", con);
            com.ExecuteNonQuery();
            con.Close();
            LoadAllRecords();
            MessageBox.Show("Successfully Update");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec SP_listdrakor_Delete '" + id_film.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            LoadAllRecords();
            MessageBox.Show("Successfully Delete");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home backhome = new home();
            backhome.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files (*.jpg) | *.jpg| png files (*.png)| *.png|All files(*.*)|*.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                id_film.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                judul.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                genre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                harga.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            id_film.Text = "";
            judul.Text = "";
            genre.Text = "";
            harga.Text = "";

            id_film.Focus();
        }
    }
}
