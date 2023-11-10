using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObejktnoProgramiranjeProjekat
{
    public partial class frmPocetniMeni : Form
    {
        public frmPocetniMeni()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnNazad.Hide();
            lbxUputstvo.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            btnPodesavanja.Hide();
            btnUputstvo.Hide();

        }

        private void btnUputstvo_Click(object sender, EventArgs e)
        {
            btnNazad.Show();
            btnPodesavanja.Hide();
            btnStart.Hide();
            btnUputstvo.Hide();
            lbxUputstvo.Show();
            lbxUputstvo.Focus();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            btnNazad.Hide();
            btnStart.Show();
            btnPodesavanja.Show();
            btnUputstvo.Show();
            lbxUputstvo.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmIgra form = new frmIgra();
            btnNazad.Show();
            btnPodesavanja.Hide();
            btnUputstvo.Hide();
            btnStart.Hide();
            form.Show();
            this.Hide();
        }
    }
}
