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
    public partial class frmIgra : Form
    {
        bool pomeriGore1, pomeriDole1, pomeriGore2, pomeriDole2;
        public bool metak1, metak2;
        int brzinaIgraca = 10;
        int brzinaMetaka = 50;
        int brojac_metaka1 = 5;
        int brojac_metaka2 = 5;
        int broj_zivota1=5,broj_zivota2=5;
        int brojacPoena1 = 100, brojacPoena2 = 100;
        Random rand = new Random(); 
        public frmIgra()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmPocetniMeni frm = new frmPocetniMeni();
            frm.Show();
            this.Hide();
        }

        private void frmIgra_Load(object sender, EventArgs e)
        {
            pbxMetak2.Hide();
            pbxMetak1.Hide();
            Timer MetakTimer = new Timer();
            MetakTimer.Interval = (10 * 1000);
            MetakTimer.Tick += new EventHandler(MetakTimerTick);
            MetakTimer.Start();
            tbxPoeni1.Text = "100";
            tbxPoeni2.Text = "100";
        }
        private void MetakTimerTick(object sender, EventArgs e)
        {
            brojac_metaka1 = 5;
            brojac_metaka2 = 5;
        }
        private void frmIgra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pomeriGore2 = true;
            if (e.KeyCode == Keys.Down) pomeriDole2 = true;
            if (e.KeyCode == Keys.W) pomeriGore1 = true;
            if (e.KeyCode == Keys.S) pomeriDole1 = true;
            if (e.KeyCode == Keys.A)
            {
                pbxMetak1.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                pbxMetak1.Location = new Point((pbxIgrac1.Left + pbxIgrac1.Right) / 2, (pbxIgrac1.Top + pbxIgrac1.Bottom) / 2);
                if (brojac_metaka1 > 0)
                {
                    metak1 = true;
                    brojac_metaka1--;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                pbxMetak2.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                pbxMetak2.Location = new Point((pbxIgrac2.Left + pbxIgrac2.Right) / 2, (pbxIgrac2.Top + pbxIgrac2.Bottom) / 2);
                if (brojac_metaka2 > 0)
                {
                    metak2 = true;
                    brojac_metaka2--;
                }
            }
        }

        private void pbxIgrac1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void pbxMetak2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrMetkovi_Tick(object sender, EventArgs e)
        {

        }

        private void btnNazad2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void tmrNmp_Tick(object sender, EventArgs e)
        {
            if (pomeriGore1 && pbxIgrac1.Top > 0)
            {
                pbxIgrac1.Top -= brzinaIgraca;
            }
            if (pomeriDole1 && pbxIgrac1.Top < 500)
            {
                pbxIgrac1.Top += brzinaIgraca;
            }
            if (pomeriGore2 && pbxIgrac2.Top > 0 && !metak2)
            {
                pbxIgrac2.Top -= brzinaIgraca;
            }
            if (pomeriDole2 && pbxIgrac2.Top < 500 && !metak2)
            {
                pbxIgrac2.Top += brzinaIgraca;
            }
            if ((metak1 || pbxMetak1.Visible))
            {
                pbxMetak1.Show();
                pbxMetak1.Left += brzinaMetaka;
                if ((pbxIgrac2.Left <= pbxMetak1.Left || pbxIgrac2.Right <= pbxMetak1.Right) &&
                (pbxIgrac2.Top <= pbxMetak1.Bottom && pbxIgrac2.Bottom >= pbxMetak1.Top))
                {
                    pbxMetak1.Hide();
                    brojacPoena2 -= 10;
                    tbxPoeni2.Text = brojacPoena2.ToString();
                    if (brojacPoena2 <= 0)
                    {
                        MessageBox.Show("Igrač 1 je pobedio!");
                        tbxPoeni1.Text = "100";
                        tbxPoeni2.Text = "100";
                    }
                }
            }
            if (metak2 || pbxMetak2.Visible)
            {
                pbxMetak2.Show();
                pbxMetak2.Left -= brzinaMetaka;
                if ((pbxIgrac1.Left >= pbxMetak2.Left || pbxIgrac1.Right >= pbxMetak2.Right) &&
                 (pbxIgrac1.Top <= pbxMetak2.Bottom && pbxIgrac1.Bottom >= pbxMetak2.Top))
                {
                    pbxMetak2.Hide();
                    brojacPoena1 -= 10;
                    tbxPoeni1.Text = brojacPoena1.ToString();
                    if (brojacPoena1 <= 0)
                    {
                        MessageBox.Show("Igrač 2 je pobedio!");
                        tbxPoeni1.Text = "100";
                        tbxPoeni2.Text = "100";
                    }
                }
            }

        }

        private void pbxIgrac2_Click(object sender, EventArgs e)
        {
            
        }

        private void pbxIgrac2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
         
        }

        private void frmIgra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pomeriGore2 = false;
            if (e.KeyCode == Keys.Down) pomeriDole2 = false;
            if (e.KeyCode == Keys.W) pomeriGore1 = false;
            if (e.KeyCode == Keys.S) pomeriDole1 = false;
            if (e.KeyCode == Keys.A) metak1 = false;
            if (e.KeyCode == Keys.Enter) metak2 = false;
        }
    }
}
