using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Actividades_3_4_5.Modelo
{
    class Facilitador
    {
        private string _profesion;
        private string _nombre;
        private byte _edad;

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
        public string Profesion
        {
            get
            {
                return this._profesion;
            }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 30))
                {
                    this._profesion = value;
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

        public void RevisarTarea(string materia)
        {

            return;
        }
        public void ExplicaeTema(String tema)
        {
            return;

        }
    }
}

