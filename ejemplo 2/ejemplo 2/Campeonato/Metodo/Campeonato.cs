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

        public int Id {
            get
            {
                return this._id;

            }
            set
            {
                if (value > 0)
                    {
                    this._id = value;
                }
            }
                }
                public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 30))
                {
                    this._nombre = value;
                }
            }

        }
        public DateTime FechaInicio
        {
            get
            { return _fechaInicio; }
        
        set
            {
                if (value > DateTime.Today)
                {
                    this._fechaInicio = value;
                }
            }
    }
        public DateTime FechaFin
        {
            get
            {
                return this._fechaFin;
            }
            set
            {
                DateTime fin = new DateTime(2019, 4, 8);
                if (value <= fin)
                {
                    this._fechaFin = value;
                }
            }
        }


    }
}
