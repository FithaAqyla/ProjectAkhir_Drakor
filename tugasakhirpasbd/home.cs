using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasakhirpasbd
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            this.Hide();
            listdrakor listDrakor = new listdrakor();
            listDrakor.Show();
        }

        private void btntransaksi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logout Berhasil");
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            datapelanggan lamanpelanggan = new datapelanggan();
            lamanpelanggan.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
