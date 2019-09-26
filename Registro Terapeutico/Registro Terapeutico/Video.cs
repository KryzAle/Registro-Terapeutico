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
using System.IO.Ports;
namespace Registro_Terapeutico
{
    public partial class Video : Form
    {
        string data = "0";
        private SerialPort myport;
        string terapia;
        public Video()
        {
            InitializeComponent();
        }
        public Video(string ruta, string sensor)
        {
            InitializeComponent();
            timer1.Enabled = true;
            
            string namePort = "";
            
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.uiMode = "none";
           
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
            switch (sensor)
            {
                case "3":

                    timer1.Interval = 2000;
                    timer1.Start();
                    namePort = "COM3";
                    break;
                case "2":
                    timer1.Interval = 2000;
                    timer1.Start();

                    namePort = "COM5";
                    break;
                case "1":
                    timer1.Interval = 8000;
                    timer1.Start();

                    namePort = "COM7";

                    break;
                default:
                    break;
            }
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = namePort;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += Myport_DataReceived;
            try
            {
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                throw;
            }
            terapia = sensor;
        }

        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            data = myport.ReadLine();

            switch (terapia)
            {
                case "1":
                    this.Invoke(new EventHandler(displaydata_event));
                    if (Int32.Parse(data)!=0)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    break;
                case "2":
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    timer1.Stop();
                    break;
                case "3":
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;
                default:
                    break;
            }
            
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            datatxt.AppendText("\t\t\t" + data+" \n");
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

            axWindowsMediaPlayer1.Ctlcontrols.pause();



        }

        private void Video_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            myport.Close();
        }
    }
}
