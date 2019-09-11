using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Terapeutico
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }
        public Video(string ruta)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Start();
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }

        }

        private void Video_Load(object sender, EventArgs e)
        {

        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void AxWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            //MessageBox.Show("Pause");
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            Thread.Sleep(rnd2.Next(1000,3000));
            //MessageBox.Show("Play");
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Stop();
            timer1.Interval = rnd.Next(10000,30000);
            timer1.Start();
        }

        private void Video_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
