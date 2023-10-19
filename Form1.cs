using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Scoreboard_with_voice
{
    public partial class Form1 : Form
    {
        int mt1 = 0;
        int mt2 = 0;
        string urlGit = "https://github.com/ACO-626/SCOREBOARD-WITH-VOICE";
        

        public Form1()
        {
            InitializeComponent();
        }

        #region BOTONES FORM
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (validaAccion())
            {
                resetear();
            }
            
        }

        private void btnAnotacionT1_Click(object sender, EventArgs e)
        {
            if (validaAnotacionMax(mt1)){               
                mt1++;
                labelT1.Text = mt1.ToString();
                reproducirVoz();             
            }
            
        }


        private void lbResT1_Click(object sender, EventArgs e)
        {
            if (validaAnotacionMin(mt1) && validaAccion())
            {
                mt1--;
                labelT1.Text = mt1.ToString();
            }
        }


        //EQUIPO 2
        private void btnAnotacionT2_Click(object sender, EventArgs e)
        {
            if (validaAnotacionMax(mt2))
            {
                mt2++;
                labelT2.Text = mt2.ToString();
                reproducirVoz();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (validaAnotacionMin(mt2) && validaAccion())
            {
                mt2--;
                labelT2.Text = mt2.ToString();
            }
        }

        #endregion

        #region VALIDACIONES

        private bool validaAnotacionMax(int newNum)
        {
            bool numeroValido = false;
            newNum++;

            if (newNum > 99)
            {
                MessageBox.Show("Esta versión está límitada para un puntaje máximo de 99", "LIMITE MÁXIMO DE PUNTAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                numeroValido = true;
            }
            return numeroValido;
        }

        private bool validaAnotacionMin(int newNum)
        {
            bool numeroValido = false;
            newNum--;

            if (newNum < 0)
            {
                MessageBox.Show("Esta versión sólo alcanza puntajes mayores a 0", "LIMITE MÍNIMO DE PUNTAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                numeroValido = true;
            }
            return numeroValido;
        }


        #endregion

        #region METODOS UTILS
        private void resetear()
        {
            mt1 = 0;
            mt2 = 0;
            labelT1.Text = "0";
            labelT2.Text = "0";
            lbNameT1.Text = "Equipo A";
            lbNameT2.Text = "Equipo B";
        }


        private bool validaAccion()
        {
            bool validado = false;
            DialogResult result = MessageBox.Show("¿Seguro que desea restar puntos?", "Confirmación", MessageBoxButtons.YesNo);
            // Comprobar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
               validado = true;
            }
            return validado;
        }



        private void reproducirVoz()
        {
            string rutaAno = "../../audios/marcador.wav";
            string rutavalA = "../../audios/" + labelT1.Text + ".wav";
            string rutaA = "../../audios/a.wav";
            string rutavalB = "../../audios/" + labelT2.Text + ".wav";
            
            try
            {
                // Crear una instancia de SoundPlayer y cargar el archivo MP3
                SoundPlayer anotacion = new SoundPlayer(rutaAno);
                SoundPlayer marcador1 = new SoundPlayer(rutavalA);
                SoundPlayer a = new SoundPlayer(rutaA);
                SoundPlayer marcador2 = new SoundPlayer(rutavalB);              
                // Reproducir el archivo MP3
                
                anotacion.Play();
                anotacion.PlaySync();
                marcador1.Play();
                marcador1.PlaySync();
                a.Play(); 
                a.PlaySync();
                marcador2.Play();
                marcador2.PlaySync();
                anotacion.Dispose();
                marcador1.Dispose();
                a.Dispose();
                marcador2.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al reproducir audio" + ex.Message);
            }


            

        }

        #endregion

        #region MENU STRIP
        private void resetearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validaAccion())
            {
                resetear();
            }
           
        }
        private void anularAnotaciónEquipo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validaAnotacionMin(mt1))
            {
                mt1--;
                labelT1.Text = mt1.ToString();
            }
        }

        private void anularAnotaciónEquipo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validaAnotacionMin(mt2))
            {
                mt2--;
                labelT2.Text = mt2.ToString();
               
            }
        }

        private void textBoxT1_TextChanged(object sender, EventArgs e)
        {
            lbNameT1.Text = textBoxT1.Text;
        }

        private void textBoxT2_TextChanged_1(object sender, EventArgs e)
        {
            lbNameT2.Text = textBoxT2.Text;
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por ACO-626, EMAIL ocampoalejadro.oc@gmail.com", "CONTACTO");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(urlGit);
        }
        #endregion


    }
}
