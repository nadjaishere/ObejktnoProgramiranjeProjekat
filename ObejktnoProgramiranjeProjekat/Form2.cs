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
        public bool metakLevo, metakDesno;
        int brzinaIgraca = 10;
        int brzinaMetaka = 20;
        int brojac_metakaLevo = 5;
        int brojac_metakaDsn = 5;
        bool neznam = true;
        int brojacPoena1 = 100, brojacPoena2 = 100;
        Random rand = new Random();
        List<PictureBox> pBx1 = new List<PictureBox>();
        List<PictureBox> pBx2 = new List<PictureBox>();
        bool[] nije_zavrsenLevo = new bool[6];
        bool[] nije_prosaoLevo = new bool[6];
        bool[] nije_zavrsenDesno = new bool[6];
        bool[] nije_prosaoDesno = new bool[6];
        public int igrac1Slika;
        
        public frmIgra(bool jesteSelektovan)
        {
            InitializeComponent();
            this.KeyPreview = true;
            if (jesteSelektovan)
            {
                pbxIgrac1.Image = Properties.Resources._734D8597_9FF9_493B_8F12_C9C45A1BFB5D;
                pbxIgrac2.Image = Properties.Resources.Vanzemaljac;
            }
            else if(!jesteSelektovan)
            {
                pbxIgrac2.Image = Properties.Resources._734D8597_9FF9_493B_8F12_C9C45A1BFB5D;
                pbxIgrac1.Image = Properties.Resources.Vanzemaljac;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmPocetniMeni frm = new frmPocetniMeni();
            frm.Show();
            this.Hide();
        }

        private void frmIgra_Load(object sender, EventArgs e)
        {
            pbxMetak1.Hide();
            Timer MetakTimer = new Timer();
            MetakTimer.Interval = (10 * 1000);
            MetakTimer.Tick += new EventHandler(MetakTimerTick);
            MetakTimer.Start();
            tbxPoeni1.Text = "100";
            tbxPoeni2.Text = "100";
            for (int i = 0; i < 6; i++)
            {
                pBx1.Add(new PictureBox());
                pBx1[i].Size = pbxMetak1.Size;
                pBx1[i].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                pBx1[i].Location = new Point((pbxIgrac1.Left + pbxIgrac1.Right) / 2, (pbxIgrac1.Top + pbxIgrac1.Bottom) / 2);
            }
            
            for (int i = 0; i < 6; i++)
            {
                pBx2.Add(new PictureBox());
                pBx2[i].Size = pbxMetak1.Size;
                pBx2[i].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                pBx2[i].Location = new Point((pbxIgrac2.Left + pbxIgrac2.Right) / 2, (pbxIgrac2.Top + pbxIgrac2.Bottom) / 2);
            }
        }
        private void MetakTimerTick(object sender, EventArgs e)
        {
            brojac_metakaLevo = 5;
            brojac_metakaDsn = 5;
            for (int i = 0; i < 5; i++)
            {
                nije_zavrsenLevo[i] = false;
                nije_prosaoLevo[i] = true;
                nije_zavrsenDesno[i] = false;
                nije_prosaoDesno[i] = true;
            }
        }
        private void frmIgra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pomeriGore2 = true;
            if (e.KeyCode == Keys.Down) pomeriDole2 = true;
            if (e.KeyCode == Keys.W) pomeriGore1 = true;
            if (e.KeyCode == Keys.S) pomeriDole1 = true;
            if (e.KeyCode == Keys.A)
            {
                if (brojac_metakaLevo > 0)
                {
                    brojac_metakaLevo--;
                    this.Controls.Add(pBx1[brojac_metakaLevo]);
                    pBx1[brojac_metakaLevo].Show();
                    pBx1[brojac_metakaLevo].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    pBx1[brojac_metakaLevo].Location = new Point((pbxIgrac1.Left + pbxIgrac1.Right) / 2, (pbxIgrac1.Top + pbxIgrac1.Bottom) / 2);
                    nije_zavrsenLevo[brojac_metakaLevo] = true;
                    nije_prosaoLevo[brojac_metakaLevo] = true;
                    metakLevo = true;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                
                if (brojac_metakaDsn > 0)
                {
                    brojac_metakaDsn--;
                    this.Controls.Add(pBx2[brojac_metakaDsn]);
                    pBx2[brojac_metakaDsn].Show();
                    pBx2[brojac_metakaDsn].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    pBx2[brojac_metakaDsn].Location = new Point((pbxIgrac2.Left + pbxIgrac2.Right) / 2, (pbxIgrac2.Top + pbxIgrac2.Bottom) / 2);
                    nije_zavrsenDesno[brojac_metakaDsn] = true;
                    nije_prosaoDesno[brojac_metakaDsn] = true;
                    metakDesno = true;

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
            if (pomeriGore2 && pbxIgrac2.Top > 0 && !metakDesno)
            {
                pbxIgrac2.Top -= brzinaIgraca;
            }
            if (pomeriDole2 && pbxIgrac2.Top < 500 && !metakDesno)
            {
                pbxIgrac2.Top += brzinaIgraca;
            }
            if (metakLevo || pBx1[brojac_metakaLevo].Visible)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (pBx1[i].Left <1202 && nije_zavrsenLevo[i] == true)
                    {
                        pBx1[i].Left += brzinaMetaka;
                        if (pBx1[i].Left >=1202 )
                        {
                            nije_zavrsenLevo[i] = false;
                            pBx1[i].Location = new Point((pbxIgrac1.Left + pbxIgrac1.Right) / 2, (pbxIgrac1.Top + pbxIgrac1.Bottom) / 2);
                            pBx1[i].Hide();
                        }
                    }
                    if (pBx1[i].Top <= pbxIgrac2.Bottom && pBx1[i].Bottom >= pbxIgrac2.Top && pBx1[i].Right >= pbxIgrac2.Left
                        && pBx1[i].Left<= pbxIgrac2.Right && nije_prosaoLevo[i] == true)
                    {      
                            brojacPoena2 -= 10;
                            tbxPoeni2.Text = brojacPoena2.ToString();
                            nije_prosaoLevo[i] = false;
                        if (brojacPoena2 == 0)
                        {
                            tbxPoeni2.Text = "0";
                            MessageBox.Show("Igrac 1 je pobedio!");
                            tbxPoeni1.Text = "100";
                            tbxPoeni2.Text = "100";
                            brojacPoena1 = 100;
                            brojacPoena2 = 100;
                            break;
                        }
                        pBx1[i].BackColor = Color.DarkSlateBlue;

                    }
                }
            }
            if(metakDesno || pBx2[brojac_metakaDsn].Visible)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if(pBx2[i].Left > 0 && nije_zavrsenDesno[i] == true)
                    {
                        pBx2[i].Left -= brzinaMetaka;
                        if (pBx2[i].Left <= 0)
                        {
                            nije_zavrsenDesno[i] = false;
                            pBx2[i].Location = new Point((pbxIgrac2.Left + pbxIgrac2.Right) / 2, (pbxIgrac2.Top + pbxIgrac2.Bottom) / 2);
                           pBx2[i].Hide();
                        }
                    }
                    if (pBx2[i].Top <= pbxIgrac1.Bottom && pBx2[i].Bottom >= pbxIgrac1.Top 
                        && pBx2[i].Left <= pbxIgrac1.Right && pBx2[i].Right <= pbxIgrac1.Left && nije_prosaoDesno[i] == true)
                    {
                            brojacPoena1 -= 10;
                            tbxPoeni1.Text = brojacPoena1.ToString();
                            nije_prosaoDesno[i] = false;

                        if (brojacPoena1 == 0)
                        {
                            tbxPoeni1.Text = "0";
                            MessageBox.Show("Igrac 2 je pobedio!");
                            tbxPoeni1.Text = "100";
                            tbxPoeni2.Text = "100";
                            brojacPoena1 = 100;
                            brojacPoena2 = 100;
                            break;
                        }
                        pBx2[i].BackColor = Color.DarkSlateBlue;
                    }
                }
            }
        }
        private void frmIgra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pomeriGore2 = false;
            if (e.KeyCode == Keys.Down) pomeriDole2 = false;
            if (e.KeyCode == Keys.W) pomeriGore1 = false;
            if (e.KeyCode == Keys.S) pomeriDole1 = false;
            if (e.KeyCode == Keys.A) metakLevo = false;
            if (e.KeyCode == Keys.Enter) metakDesno = false;
        }
    }
}
