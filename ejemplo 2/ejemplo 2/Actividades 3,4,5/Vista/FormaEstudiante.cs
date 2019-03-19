using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejemplo_2.Actividades_3_4_5.Modelo;

namespace ejemplo_2.Actividades_3_4_5.Vista
{
    public partial class FormaEstudiante : Form
    {
        private static FormaEstudiante forma1;
        private int NumeroControl;
        private char genero;
        private int Edad;

        public FormaEstudiante()
        {
            InitializeComponent();
        }

        private void FormaEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaEstudiante.forma1 = new FormaEstudiante();

            forma1.NumeroControl = 1218100459;
            forma1.Name = " Dulce Maria Martinez Garcia";
            forma1.Edad = 18;
            forma1.genero = 'F';

            textonumcontrol.Text = forma1.NumeroControl.ToString();
            textoNombre.Text = forma1.Name;
            textoEdad.Text = forma1.edad.ToString();
            textoGenero.Text = forma1.Genero.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
