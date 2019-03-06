using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using
 Acatividad_4.Modelo;
namespace Acatividad_4.Vista
{
    public partial class FormaEstudiante : Form
    {
        private static FormaEstudiante forma;
        private int Edad;
        private object Genero;

        public object numcontrol { get; private set; }

        public FormaEstudiante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void botonmostrar_Click(object sender, EventArgs e)
        {
            FormaEstudiante.forma = new FormaEstudiante();

            forma.numcontrol = 1218100459;
            forma.Name = " Dulce Maria Martinez Garcia";
            forma.Edad = 18;
            forma.Genero = 'F';

            textonumcontrol.Text = forma.numcontrol.ToString();
            textoNombre.Text = forma.Name;
            textoEdad.Text = forma.Edad.ToString();
            textoGenero.Text = forma.Genero.ToString();




        }
    }
}
