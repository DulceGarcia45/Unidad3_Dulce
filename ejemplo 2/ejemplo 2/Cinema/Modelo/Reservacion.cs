using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Cinema.Modelo
{
    class Reservacion
    {
        private DateTime _fecha;
        private string _numTargeta;

        public void reservacion()
        {
            return;
        }
         public DateTime Fecha
        {
            get
            {
                return this._fecha;
            }
            set
            {
                {
                    DateTime inicio = new DateTime(2019, 3, 22);
                    if (value <= inicio)
                    {
                        this._fecha = value;
                    }
                }
            }

        }
        public string NumTargeta
        {
            get { return _numTargeta ; }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 30))
                {
                    this._numTargeta = value;
                }
            }
        }
        public override string ToString()
        {
            return "Fecha" + _fecha + "|NumTargeta" + _numTargeta;
        }

    }
}
