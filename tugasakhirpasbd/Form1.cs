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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPilih pilih = new formPilih();
            pilih.Show();
        }

        private void btntransaksi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
