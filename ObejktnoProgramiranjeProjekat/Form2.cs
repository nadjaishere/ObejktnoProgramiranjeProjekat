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
        int brzinaMetaka = 30;
        int brojac_metaka1 = 5;
        int brojac_metaka2 = 5;
        int broj_zivota1=5,broj_zivota2=5;
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
                    pbxMetak1.Top = pbxIgrac1.Top;
                    pbxMetak1.Left= pbxIgrac1.Left;
                    metak1 = true;
                    pbxMetak1.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    brojac_metaka1--;
                   // MessageBox.Show(Convert.ToString(brojac_metaka1));
                }
                


            }
            if (e.KeyCode == Keys.Enter)
            {
                if (brojac_metaka2>0)
                {
                    pbxMetak2.Top = pbxIgrac2.Top;
                    pbxMetak2.Left = pbxIgrac2.Left;
                    metak2 = true;
                    pbxMetak2.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    brojac_metaka2--;
                    //MessageBox.Show(Convert.ToString(brojac_metaka2));
                }
            }
        }

        private void pbxIgrac1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void pbxMetak2_Click(object sender, EventArgs e)
        {

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
                pbxMetak1.Top -= brzinaIgraca;
            }
            if (pomeriDole1 && pbxIgrac1.Top < 500)
            {
                pbxIgrac1.Top += brzinaIgraca;
                pbxMetak1.Top += brzinaIgraca;
            }
            if (pomeriGore2 && pbxIgrac2.Top > 0)
            {
                pbxIgrac2.Top -= brzinaIgraca;
                pbxMetak2.Top -= brzinaIgraca;  
            }
            if (pomeriDole2 && pbxIgrac2.Top < 500)
            {
                pbxIgrac2.Top += brzinaIgraca;
                pbxMetak2.Top += brzinaIgraca;
            }
            if ((metak1 || pbxMetak1.Visible))
            {
                pbxMetak1.Show();
                pbxMetak1.Left += brzinaMetaka;
            }
            if ((metak2 || pbxMetak2.Visible))
            {
                pbxMetak2.Show();
                pbxMetak2.Left -= brzinaMetaka;
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
