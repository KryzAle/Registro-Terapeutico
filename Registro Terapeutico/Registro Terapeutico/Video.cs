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
        //declaramos las variables de data donde almacenaremos la informacion que viene del sensor
        string data = "0";
        //declaramos myport para almacenar el puerto bluetooth del sensor
        private SerialPort myport;
        //declaramos terapia para almacenar el sensor 
        string terapia;
        public Video()
        {
            InitializeComponent();
        }
        //constructor que recibe la ruta del video y el sensor que se va a ocupar
        public Video(string ruta, string sensor)
        {
            InitializeComponent();
            //obtiene el componente timer y lo activa
            timer1.Enabled = true;
            
            string namePort = "";
            //declara la ruta del video para el componente de reproductor y establece sus propiedades
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.uiMode = "none";
            //valida si cargo el video y coloca el video en pantalla completa
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
            //obtiene el nombre del puerto y establece el intervalo del timer para cada sensor
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
            //declara un nuevo puerto y declara el puerto del sensor que se va a utilizar ademas de los bits de parada y la funcion que va a recibir la data
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = namePort;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += Myport_DataReceived;
            //abre el puerto
            try
            {
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                throw;
            }
            //asigna el valor de sensor a la variable terapia
            terapia = sensor;
        }

        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //lee la data del puerto
            data = myport.ReadLine();
            //compara que sensor se va a utilizar y ejecutando un codigo para cada sensor dependiendo de la data obtenida
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
        //agrega los datos obtenidos del sensor al campo de texto en el diseño
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
        //funcion llamaada por el timer segun el intervalo de tiempo declarado
        private void Timer1_Tick(object sender, EventArgs e)
        {

            //pone pause al video
            axWindowsMediaPlayer1.Ctlcontrols.pause();



        }
        //funcion llamda al cerrar el video 
        private void Video_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            myport.Close();
        }
    }
}
