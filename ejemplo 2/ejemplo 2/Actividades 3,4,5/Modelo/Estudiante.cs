using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Actividades_3_4_5.Modelo
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
        public byte Edad
        {
            get
            {
                return this._edad;
            }
            set
            {
                if (value != 0)
                    this._edad = value;

            }
        }
        public char genero
        {
            get
            {
                return this._genero;
            }
            set
            {
                if (value == 'S' || value == 'N' || value == 'H' || value == 'M')
                {
                    this._genero = value;
                }
            }
        }

    }
}

