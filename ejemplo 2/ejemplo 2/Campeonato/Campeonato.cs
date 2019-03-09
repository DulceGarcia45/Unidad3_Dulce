using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Campeonato
{
    class Campeonato
    {
        private int _id;
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        //constructor default
        public Campeonato()
        {
            this._nombre = "Campeonato de la segunda division de Dolores";
            this._id = 1;
            for (int i=1;i<=20;i++)
            {
                Jornada j = new Jornada();
                _jornada.Add(j);
            }
        }
        //resultado de la asociacion entre campeonato y jornada 
        private List<Jornada> _jornada = new List<Jornada>();
        //metodo getter's y setter's
        public int Id { get; set; }
        public string Nonbre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }


    }
}
