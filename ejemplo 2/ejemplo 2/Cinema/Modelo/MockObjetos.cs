using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Cinema.Modelo
{
    class MockObjetos
    {
        public static Sala []  coleccionSalas ()
        {
            Sala[] colSalas = new Sala[5]; // Tamaño de la sala
            colSalas[0] = new Sala();
            colSalas[1] = new Sala(200);
            colSalas[2] = new Sala(200, "Sala A");
            colSalas[3] = new Sala(200, "Sala B");
            colSalas[4] = new Sala(200, "Sala B");


            return colSalas;
        }
        public List <Taquillero> coleccionEmpleados ()
        {
            List<Taquillero> coleccionEmpleados = new List<Taquillero>();
            Persona person1 = new Persona();
            Taquillero emp1 = new Taquillero();
            for (int i = 1; i <= 100; i++)
            {
                coleccionEmpleados.Add(new Taquillero());
            }

            return coleccionEmpleados;

        }
    }
}
