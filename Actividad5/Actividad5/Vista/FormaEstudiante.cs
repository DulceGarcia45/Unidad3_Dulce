using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad5.Modelo;

namespace Actividad5.Vista
{
    public partial class FormaEstudiante : Form
    {
        private static FormaEstudiante forma1;
        private char Genero;
        private int numcontrol;

        public FormaEstudiante()
        {
            InitializeComponent();
        }

        public int Edad { get; private set; }

        private void buttonmostrar_Click(object sender, EventArgs e)
        {
            FormaEstudiante.forma1 = new FormaEstudiante();

            forma1.numcontrol = 1218100459;
            forma1.Name = " Dulce Maria Martinez Garcia";
            forma1.Edad = 18;
            forma1.Genero = 'F';

            textonumcontrol.Text = forma1.numcontrol.ToString();
            textoNombre.Text = forma1.Name;
            textoEdad.Text = forma1.Edad.ToString();
            textoGenero.Text = forma1.Genero.ToString();

        }
    }
}
