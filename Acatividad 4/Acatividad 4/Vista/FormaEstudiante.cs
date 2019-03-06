using Acatividad_4.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Acatividad_4.Vista
{
    public partial class FormaEstudiante : Form
    {
        private static object TextoNumControl;
        private static string Edad;
        private static string Genero;

        public static string NombreEstudiante { get; private set; }

        public FormaEstudiante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
     Estudiante  forma1 = new Estudiante();

            forma1.Nombre= "Dulce Maria Martinez Garcia";
            forma1.Edad = 18;
            forma1.genero = 'F';
            forma1.NumControl = 1218100459;

            FormaEstudiante.TextoNumControl = forma1.NumControl.ToString();
            FormaEstudiante.NombreEstudiante = forma1.Nombre.ToString();
            FormaEstudiante.Edad = forma1.Edad.ToString();
            FormaEstudiante.Genero = forma1.genero.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante forma1 = new Estudiante();

            forma1.Nombre = "Dulce Maria Martinez Garcia";
            forma1.Edad = 18;
            forma1.genero = 'F';
            forma1.NumControl = 1218100459;

            FormaEstudiante.TextoNumControl = forma1.NumControl.ToString();
            FormaEstudiante.NombreEstudiante = forma1.Nombre.ToString();
            FormaEstudiante.Edad = forma1.Edad.ToString();
            FormaEstudiante.Genero = forma1.genero.ToString();


        }

        private void NumControl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
