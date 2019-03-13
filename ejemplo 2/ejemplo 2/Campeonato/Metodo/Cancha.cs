using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Campeonato
{
    class Cancha
    {
        private int _id;
        private string _nombre;
        private string _ubicacion;
        public int Id
        {
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
        public string Nombre {
            get {
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
       
            
        public string Ubicacion {
            get
            {
                return this._ubicacion;
            }
            set
            {
                if (value != null)
                {
                    this._ubicacion = value;
                }

            }

                }

    }
}
