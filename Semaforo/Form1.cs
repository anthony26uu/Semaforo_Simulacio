using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int entero = 0;
        Random variableR = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Semaforo.Properties.Resources.apagado2;
            buttonApagar.Enabled = false;
            buttonParar.Enabled = false;
            buttonIniciar.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(entero)
            {
                case 0:
                    pictureBox1.Image = Semaforo.Properties.Resources.rojo;
                    timer1.Interval = 6000;
                    entero = 1;

                    if (EstadoLabel.Text == "Semaforo Funcionando")
                    {
                        variableR = new Random((int)DateTime.Now.Ticks & 0x00FFFF);
                        int numero = variableR.Next(0, 20);

                        CarrostextBox.Text = Convert.ToString(numero);
                    }
                  
                    break;
                case 1:
                    pictureBox1.Image = Semaforo.Properties.Resources.amarrillo2;
                    timer1.Interval = 1000;
                    entero = 2;
                    break;
                case 2: pictureBox1.Image = Semaforo.Properties.Resources.verde;
                   
                    timer1.Interval = 4000;
                    entero = 0;

                 
                    break;


            }
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttonParar.Enabled = true;
            buttonApagar.Enabled = true;
            buttonIniciar.Enabled = false;

            EstadoLabel.Text = "Semaforo Funcionando";

        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            if (buttonParar.Text == "Parar") 
            {
                timer1.Enabled = false;
                buttonParar.Text="Reanudar";
                EstadoLabel.Text = "SEMAFORO PARADO";
                
            }
            else if(buttonParar.Text=="Reanudar")
            {
                timer1.Enabled = true;
                buttonParar.Text = "Parar";
                EstadoLabel.Text = "SEMAFORO ENCENDIDO";
            }

        
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            buttonParar.Enabled = false;
            buttonApagar.Enabled = false;
            buttonIniciar.Enabled = true;

            EstadoLabel.Text = "SEMAFORO APAGADO";
            CarrostextBox.Text = "";
            pictureBox1.Image = Semaforo.Properties.Resources.apagado2;

        }
    }
}
