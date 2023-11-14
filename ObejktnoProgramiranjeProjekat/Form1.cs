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
        bool jesteSelektovanaSlika1 = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnNazad.Hide();
            rtbUputstvo.Hide();
            pBxAstronautIgrac1.Hide();
            pBxVanzemaljacIgrac1.Hide();
            pBxVanzemaljacIgrac2.Hide();
            pBxAstronautIgrac2.Hide();
            lblIgrac1.Hide();
            lblIgrac2.Hide();
            chcBxAstronautIgrac1.Hide();
            chcBxVanzemaljacIgrac1.Hide();
            chcBxAstronautIgrac2.Hide();
            chcBxVanzemaljacIgrac2.Hide();
            chcBxAstronautIgrac1.Checked = true;
            chcBxVanzemaljacIgrac2.Checked = true;
        }
        private void btnPodesavanja_Click(object sender, EventArgs e)
        {
           
            btnStart.Hide();
            btnPodesavanja.Hide();
            btnUputstvo.Hide();
            pBxAstronautIgrac1.Show();    
            pBxVanzemaljacIgrac1.Show();
            pBxVanzemaljacIgrac2.Show();
            pBxAstronautIgrac2.Show();
            lblIgrac1.Show();
            lblIgrac2.Show();
            chcBxAstronautIgrac1.Show();
            chcBxVanzemaljacIgrac1.Show();
            chcBxAstronautIgrac2.Show();
            chcBxVanzemaljacIgrac2.Show();
            btnNazad.Show();
            btnIzlaz.Hide();
        }

        private void btnUputstvo_Click(object sender, EventArgs e)
        {
            rtbUputstvo.Show();
            btnNazad.Show();
            btnPodesavanja.Hide();
            btnStart.Hide();
            btnUputstvo.Hide();
            btnIzlaz.Hide();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            btnNazad.Hide();
            btnStart.Show();
            btnPodesavanja.Show();
            btnUputstvo.Show();
            rtbUputstvo.Hide();
            pBxAstronautIgrac1.Hide();
            pBxVanzemaljacIgrac1.Hide();
            pBxVanzemaljacIgrac2.Hide();
            pBxAstronautIgrac2.Hide();
            lblIgrac1.Hide();
            lblIgrac2.Hide();
            chcBxAstronautIgrac1.Hide();
            chcBxVanzemaljacIgrac1.Hide();
            chcBxAstronautIgrac2.Hide();
            chcBxVanzemaljacIgrac2.Hide();
            btnIzlaz.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmIgra form = new frmIgra(jesteSelektovanaSlika1);
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
            if (chcBxAstronautIgrac1.Checked)
            {
                chcBxAstronautIgrac2.Enabled = false;
                chcBxVanzemaljacIgrac1.Checked = false;
                jesteSelektovanaSlika1 = true;
            }
            else
            {
                chcBxAstronautIgrac2.Enabled = true;
            }
        }

        private void chcBx2_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBxVanzemaljacIgrac1.Checked)
            {
                chcBxVanzemaljacIgrac2.Enabled = false;
                chcBxAstronautIgrac1.Checked= false;
                jesteSelektovanaSlika1=false;
            }
            else
            {
                chcBxVanzemaljacIgrac2.Enabled = true;
            }
        }

        private void chcBx3_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBxAstronautIgrac2.Checked)
            {
                chcBxAstronautIgrac1.Enabled = false;
                chcBxVanzemaljacIgrac2.Checked= false;
            }
            else
            {
                chcBxAstronautIgrac1.Enabled = true;
            }
        }

        private void chcBx4_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBxVanzemaljacIgrac2.Checked)
            {
                chcBxVanzemaljacIgrac1.Enabled = false;
                chcBxAstronautIgrac2.Checked= false;
            }
            else
            {
                chcBxVanzemaljacIgrac1.Enabled = true;
            }
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
