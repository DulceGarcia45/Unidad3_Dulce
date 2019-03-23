using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Cinema.Modelo
{
    class Pelicula
    {
        private int _id;
        private string _nombre;
        private string _director;
        private string _clasificasion;
        private string _resumen;

        public int Id
        {
            get { return _id; }
            set { if (value > 0)
                    _id = value;
            }
        }
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 60))
                {
                    this._nombre = value;
                }
            }
        }
            public string Director
        {
            get { return _director; }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 80))
                {
                    this._director = value;
                }
            }

        }
        public string Clasificacion
        {
            get { return _clasificasion; }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 120))
                {
                    this._clasificasion= value;
                }
            }
        }
        public string resumen
        {
            get { return _resumen; }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 200))
                {
                    this._resumen = value;
                }
            }
        }
        public override string ToString()
        {
            return "Id"+ _id+"|Nombre"+ _nombre+"|Director"+_director + "|Clasificasion"+ _clasificasion +"|Resumen"+ _resumen;
        }
    }
    }

