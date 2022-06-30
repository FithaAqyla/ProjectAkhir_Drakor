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
    public partial class loginKasir : Form
    {
        public loginKasir()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AS5OAOK;initial Catalog=projectakhir;User ID=sa;Password=123");

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //String querry = "SELECT * FROM AdminLog WHERE username = '" + username.Text + "' AND '" + password.Text + "'";
               
                SqlCommand cmd = new SqlCommand("SELECT * FROM KasirLog WHERE username = @username AND password = @password ", con);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Login Berhasil");

                    homeKasir listdrakor = new homeKasir();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPilih pilih = new formPilih();
            pilih.Show();
        }

        private void loginKasir_Load(object sender, EventArgs e)
        {

        }
    }
}
