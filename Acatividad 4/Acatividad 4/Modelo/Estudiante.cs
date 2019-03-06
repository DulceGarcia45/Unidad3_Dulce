using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acatividad_4.Modelo
{
    class Estudiante
    {
        private long _numerocontrol;
        private string _nombre;
        private byte _edad;
        private char _genero;
        public long NumeroControl
        {
            get
            {
                return this._numerocontrol;
            }
            set
            {
                if (value > 0)
                    this._numerocontrol = value;

            }
        }
        public long NumControl { get; set; }
        public string Nombre { get; set; }
        public byte Edad { get; set; }
        public char genero { get; set; }
    }
}
