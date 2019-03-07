using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Modelo
{
    class Facilitador
    {
        private string _profesion;
        private string _nombre;
        private byte _edad;
       
        public long NumeroControl
        {
            get
            {
                return this._edad;
            }
            set
            {
                if (value > 0)
                    this._edad = value;

            }
        }
        public string profesion { get; set; }
        public string Nombre { get; set; }
        public byte Edad { get; set; }
       
    }
}
}
