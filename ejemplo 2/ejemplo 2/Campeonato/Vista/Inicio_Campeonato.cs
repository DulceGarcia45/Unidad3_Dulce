using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_2.Campeonato.Vista
{
    public partial class Inicio_Campeonato : Form
    {
        public Inicio_Campeonato()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.liga_futbol.ForeColor = System.Drawing.SystemColors.Highlight;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.liga_futbol.ForeColor = System.Drawing.SystemColors.Desktop;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.   Jornada.Size = new System.Drawing.Size(300, 189);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.Jornada.Size = new System.Drawing.Size(269, 174);
        }

        private void Campeonato_Click(object sender, EventArgs e)
        {
          

        }

        private void Campeonato_MouseEnter(object sender, EventArgs e)
        {
              this.Campeonato.Size = new System.Drawing.Size(300, 189);

        }

        private void Jornada_Click(object sender, EventArgs e)
        {

        }

        private void liga_futbol_Click(object sender, EventArgs e)
        {

        }

        private void liga_futbol_MouseEnter(object sender, EventArgs e)
        {
            this.liga_futbol.ForeColor = System.Drawing.SystemColors.Highlight;

        }
    }
}
