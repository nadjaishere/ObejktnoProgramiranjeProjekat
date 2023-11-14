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
        bool pomeriGoreIgracaLevo, pomeriDoleIgracaLevo, pomeriGoreIgracDesno, pomeriDoleIgracDesno;
        public bool IspaljenMetakLevo, IspaljenMetakDesno;
        int brzinaIgraca = 10;
        int brzinaMetaka = 20;
        int brojac_metakaLevo = 5;
        int brojac_metakaDsn = 5;
        int brojacPoenaIgracaLevo= 100, brojacPoenaIgracaDesno= 100;
        Random rand = new Random();
        List<PictureBox> pBxLevo = new List<PictureBox>();
        List<PictureBox> pBxDesno = new List<PictureBox>();
        bool[] nije_zavrsenLevo = new bool[6];
        bool[] nije_prosaoLevo = new bool[6];
        bool[] nije_zavrsenDesno = new bool[6];
        bool[] nije_prosaoDesno = new bool[6];
        
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
            Timer ReloadMetaka = new Timer();
            ReloadMetaka.Interval = (10 * 1000);
            ReloadMetaka.Tick += new EventHandler(MetakTimerTick);
            ReloadMetaka.Start();
            tbxPoeni1.Text = "100";
            tbxPoeni2.Text = "100";
            for (int i = 0; i < 6; i++)
            {
                pBxLevo.Add(new PictureBox());
                pBxLevo[i].Size = pbxMetak1.Size;
                pBxLevo[i].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                pBxLevo[i].Location = new Point((pbxIgrac1.Left + pbxIgrac1.Right) / 2, (pbxIgrac1.Top + pbxIgrac1.Bottom) / 2);
            }
            
            for (int i = 0; i < 6; i++)
            {
                pBxDesno.Add(new PictureBox());
                pBxDesno[i].Size = pbxMetak1.Size;
                pBxDesno[i].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                pBxDesno[i].Location = new Point((pbxIgrac2.Left + pbxIgrac2.Right) / 2, (pbxIgrac2.Top + pbxIgrac2.Bottom) / 2);
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
            if (e.KeyCode == Keys.Up) pomeriGoreIgracDesno = true;
            if (e.KeyCode == Keys.Down) pomeriDoleIgracDesno = true;
            if (e.KeyCode == Keys.W) pomeriGoreIgracaLevo = true;
            if (e.KeyCode == Keys.S) pomeriDoleIgracaLevo = true;
            if (e.KeyCode == Keys.A)
            {
                if (brojac_metakaLevo > 0)
                {
                    brojac_metakaLevo--;
                    this.Controls.Add(pBxLevo[brojac_metakaLevo]);
                    pBxLevo[brojac_metakaLevo].Show();
                    pBxLevo[brojac_metakaLevo].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    pBxLevo[brojac_metakaLevo].Location = new Point((pbxIgrac1.Left + pbxIgrac1.Right) / 2, (pbxIgrac1.Top + pbxIgrac1.Bottom) / 2);
                    nije_zavrsenLevo[brojac_metakaLevo] = true;
                    nije_prosaoLevo[brojac_metakaLevo] = true;
                    IspaljenMetakLevo = true;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                
                if (brojac_metakaDsn > 0)
                {
                    brojac_metakaDsn--;
                    this.Controls.Add(pBxDesno[brojac_metakaDsn]);
                    pBxDesno[brojac_metakaDsn].Show();
                    pBxDesno[brojac_metakaDsn].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    pBxDesno[brojac_metakaDsn].Location = new Point((pbxIgrac2.Left + pbxIgrac2.Right) / 2, (pbxIgrac2.Top + pbxIgrac2.Bottom) / 2);
                    nije_zavrsenDesno[brojac_metakaDsn] = true;
                    nije_prosaoDesno[brojac_metakaDsn] = true;
                    IspaljenMetakDesno = true;

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

        private void tmrKretanje_Tick(object sender, EventArgs e)
        {
            if (pomeriGoreIgracaLevo && pbxIgrac1.Top > 20)
            {
                pbxIgrac1.Top -= brzinaIgraca;
            }
            if (pomeriDoleIgracaLevo && pbxIgrac1.Top < 400)
            {
                pbxIgrac1.Top += brzinaIgraca;
            }
            if (pomeriGoreIgracDesno && pbxIgrac2.Top > 20 )
            {
                pbxIgrac2.Top -= brzinaIgraca;
            }
            if (pomeriDoleIgracDesno && pbxIgrac2.Top < 400 )
            {
                pbxIgrac2.Top += brzinaIgraca;
            }
            if (IspaljenMetakLevo || pBxLevo[brojac_metakaLevo].Visible)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (pBxLevo[i].Left <1202 && nije_zavrsenLevo[i] == true)
                    {
                        pBxLevo[i].Left += brzinaMetaka;
                        if (pBxLevo[i].Left >=1202 )
                        {
                            nije_zavrsenLevo[i] = false;
                            pBxLevo[i].Location = new Point((pbxIgrac1.Left + pbxIgrac1.Right) / 2, (pbxIgrac1.Top + pbxIgrac1.Bottom) / 2);
                            pBxLevo[i].Hide();
                        }
                    }
                    if (pBxLevo[i].Top <= pbxIgrac2.Bottom && pBxLevo[i].Bottom >= pbxIgrac2.Top && pBxLevo[i].Right >= pbxIgrac2.Left
                        && pBxLevo[i].Left<= pbxIgrac2.Right && nije_prosaoLevo[i] == true)
                    {      
                            brojacPoenaIgracaDesno -= 10;
                            tbxPoeni2.Text = brojacPoenaIgracaDesno.ToString();
                            nije_prosaoLevo[i] = false;
                        if (brojacPoenaIgracaDesno == 0)
                        {
                            tbxPoeni2.Text = "0";
                            MessageBox.Show("Igrac 1 je pobedio!");
                            tbxPoeni1.Text = "100";
                            tbxPoeni2.Text = "100";
                            brojacPoenaIgracaLevo = 100;
                            brojacPoenaIgracaDesno = 100;
                            break;
                        }
                        pBxLevo[i].BackColor = Color.DarkSlateBlue;

                    }
                }
            }
            if(IspaljenMetakDesno || pBxDesno[brojac_metakaDsn].Visible)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if(pBxDesno[i].Left > 0 && nije_zavrsenDesno[i] == true)
                    {
                        pBxDesno[i].Left -= brzinaMetaka;
                        if (pBxDesno[i].Left <= 0)
                        {
                            nije_zavrsenDesno[i] = false;
                            pBxDesno[i].Location = new Point((pbxIgrac2.Left + pbxIgrac2.Right) / 2, (pbxIgrac2.Top + pbxIgrac2.Bottom) / 2);
                           pBxDesno[i].Hide();
                        }
                    }
                    if (pBxDesno[i].Top <= pbxIgrac1.Bottom && pBxDesno[i].Bottom >= pbxIgrac1.Top 
                        && pBxDesno[i].Left <= pbxIgrac1.Right && pBxDesno[i].Right <= pbxIgrac1.Left && nije_prosaoDesno[i] == true)
                    {
                            brojacPoenaIgracaLevo -= 10;
                            tbxPoeni1.Text = brojacPoenaIgracaLevo.ToString();
                            nije_prosaoDesno[i] = false;

                        if (brojacPoenaIgracaLevo == 0)
                        {
                            tbxPoeni1.Text = "0";
                            MessageBox.Show("Igrac 2 je pobedio!");
                            tbxPoeni1.Text = "100";
                            tbxPoeni2.Text = "100";
                            brojacPoenaIgracaLevo = 100;
                            brojacPoenaIgracaDesno = 100;
                            break;
                        }
                        pBxDesno[i].BackColor = Color.DarkSlateBlue;
                    }
                }
            }
        }
        private void frmIgra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pomeriGoreIgracDesno = false;
            if (e.KeyCode == Keys.Down) pomeriDoleIgracDesno = false;
            if (e.KeyCode == Keys.W) pomeriGoreIgracaLevo = false;
            if (e.KeyCode == Keys.S) pomeriDoleIgracaLevo = false;
            if (e.KeyCode == Keys.A) IspaljenMetakLevo = false;
            if (e.KeyCode == Keys.Enter) IspaljenMetakDesno = false;
        }
    }
}
