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
    public partial class formPilih : Form
    {
        public formPilih()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 backawal = new Form1();
            backawal.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginadmin admin = new loginadmin();
            admin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginKasir kasir = new loginKasir();
            kasir.Show();
        }
    }
}
