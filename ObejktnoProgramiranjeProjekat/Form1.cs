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
            pBx1.Hide();
            pBx2.Hide();
            pBx3.Hide();
            pBx4.Hide();
            lblIgrac1.Hide();
            lbl2.Hide();
            chcBx1.Hide();
            chcBx2.Hide();
            chcBx3.Hide();
            chcBx4.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            btnPodesavanja.Hide();
            btnUputstvo.Hide();
            pBx1.Show();    
            pBx2.Show();
            pBx3.Show();
            pBx4.Show();
            lblIgrac1.Show();
            lbl2.Show();
            chcBx1.Show();
            chcBx2.Show();
            chcBx3.Show();
            chcBx4.Show();
            btnNazad.Show();
            btnIzlaz.Hide();
        }

        private void btnUputstvo_Click(object sender, EventArgs e)
        {
            btnNazad.Show();
            btnPodesavanja.Hide();
            btnStart.Hide();
            btnUputstvo.Hide();
            lbxUputstvo.Show();
            lbxUputstvo.Focus();
            btnIzlaz.Hide();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            btnNazad.Hide();
            btnStart.Show();
            btnPodesavanja.Show();
            btnUputstvo.Show();
            lbxUputstvo.Hide();
            pBx1.Hide();
            pBx2.Hide();
            pBx3.Hide();
            pBx4.Hide();
            lblIgrac1.Hide();
            lbl2.Hide();
            chcBx1.Hide();
            chcBx2.Hide();
            chcBx3.Hide();
            chcBx4.Hide();
            btnIzlaz.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmIgra form = new frmIgra();
            btnNazad.Show();
            btnPodesavanja.Hide();
            btnUputstvo.Hide();
            btnStart.Hide();
            btnIzlaz.Hide();
            form.Show();
            form.Focus();
            this.Hide();
        }

        private void chcBx1_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBx1.Checked)
            {
                chcBx3.Enabled = false;
                chcBx2.Checked= false;
            }
            else
            {
                chcBx3.Enabled = true;
            }
        }

        private void chcBx2_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBx2.Checked)
            {
                chcBx4.Enabled = false;
                chcBx1.Checked= false;
            }
            else
            {
                chcBx4.Enabled = true;
            }
        }

        private void chcBx3_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBx3.Checked)
            {
                chcBx1.Enabled = false;
                chcBx4.Checked= false;
            }
            else
            {
                chcBx1.Enabled = true;
            }
        }

        private void chcBx4_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBx4.Checked)
            {
                chcBx2.Enabled = false;
                chcBx3.Checked= false;
            }
            else
            {
                chcBx2.Enabled = true;
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
