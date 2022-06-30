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
    public partial class loginadmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS5OAOK;initial Catalog=projectakhir;User ID=sa;Password=123");
        public loginadmin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectakhirDataSet4.AdminLog' table. You can move, or remove it, as needed.
            

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string user = "kila";
            //String pwd = "123";

            //if (username.Text == user && password.Text == pwd)
            //{
            //  this.Hide();
            //MessageBox.Show("Login Berhasil");
            //home home = new home();
            //home.Show();
            //}
            //else
            //{
            //  MessageBox.Show("Login Gagal!");
            //}



            try
            {
                //String querry = "SELECT * FROM AdminLog WHERE username = '" + username.Text + "' AND '" + password.Text + "'";
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS5OAOK;initial Catalog=projectakhir;User ID=sa;Password=123");
                SqlCommand cmd = new SqlCommand("SELECT * FROM AdminLog WHERE username = @username AND password = @password ",con);
                cmd.Parameters.AddWithValue("@username",username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Login Berhasil");

                    home listdrakor = new home();
                    listdrakor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Gagal");
                }
            }
            catch
            {
                MessageBox.Show("Login Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formPilih pilih = new formPilih();
            pilih.Show();
        }
    }
}
