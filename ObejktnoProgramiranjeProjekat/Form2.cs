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
        int brzinaMetaka = 10;
        int brojac_metaka1 = 5;
        int brojac_metaka2 = 5;
        bool neznam = true;
        int brojacPoena1 = 100, brojacPoena2 = 100;
        Random rand = new Random();
        List<PictureBox> pBx1 = new List<PictureBox>();
        List<PictureBox> pBx2 = new List<PictureBox>();
        bool[] nije_zavrsen = new bool[6];
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
                //pBx[i].Hide();
            }
            
            for (int i = 0; i < 6; i++)
            {
                pBx2.Add(new PictureBox());
                pBx2[i].Size = pbxMetak1.Size;
                pBx2[i].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                pBx2[i].Location = new Point((pbxIgrac2.Left + pbxIgrac2.Right) / 2, (pbxIgrac2.Top + pbxIgrac2.Bottom) / 2);
                //pBx[i].Hide();
            }
            //MessageBox.Show(Convert.ToString(pBx1.Count));
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
                if (brojac_metaka1 > 0)
                {
                    //MessageBox.Show(Convert.ToString(brojac_metaka1));
                    brojac_metaka1--;
                    this.Controls.Add(pBx1[brojac_metaka1]);
                    pBx1[brojac_metaka1].Show();
                    pBx1[brojac_metaka1].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    pBx1[brojac_metaka1].Location = new Point((pbxIgrac1.Left + pbxIgrac1.Right) / 2, (pbxIgrac1.Top + pbxIgrac1.Bottom) / 2);
                    metakLevo = true;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                
                if (brojac_metaka2 > 0)
                {
                    //MessageBox.Show(Convert.ToString(brojac_metaka2));
                    brojac_metaka2--;
                    this.Controls.Add(pBx2[brojac_metaka2]);
                    pBx2[brojac_metaka2].Show();
                    pBx2[brojac_metaka2].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    pBx2[brojac_metaka2].Location = new Point((pbxIgrac2.Left + pbxIgrac2.Right) / 2, (pbxIgrac2.Top + pbxIgrac2.Bottom) / 2);
                    nije_zavrsen[brojac_metaka2] = true;
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
            if (metakLevo || pBx1[brojac_metaka1].Visible)
            {
                pBx1[brojac_metaka1].Left += brzinaMetaka;
            }
            if(metakDesno || pBx2[brojac_metaka2].Visible)
            {
                while(pBx2[brojac_metaka2].Left > 0 && nije_zavrsen[brojac_metaka2] ==true)
                {
                    pBx2[brojac_metaka2].Left -= brzinaMetaka;
                }
                if (pBx2[brojac_metaka2].Top< pbxIgrac1.Bottom && pBx2[brojac_metaka2].Bottom> pbxIgrac1.Top && pBx2[brojac_metaka2].Left < pbxIgrac1.Left)
                {
                    brojacPoena1 -= 10;
                    tbxPoeni1.Text=brojacPoena1.ToString();
                }
                nije_zavrsen[brojac_metaka2] = false;
                //pBx2[brojac_metaka2].Location = new Point(100 + brojac_metaka2 * brojac_metaka2, 100);
                pBx2[brojac_metaka2].Location = new Point((pbxIgrac2.Left + pbxIgrac2.Right) / 2, (pbxIgrac2.Top + pbxIgrac2.Bottom) / 2);

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
