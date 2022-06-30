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
    public partial class homeKasir : Form
    {
        public homeKasir()
        {
            InitializeComponent();
        }

        private void homeKasir_Load(object sender, EventArgs e)
        {

        }

        private void btntransaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaksi transaksi = new transaksi();
            transaksi.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
