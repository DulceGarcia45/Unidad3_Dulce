using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Actividades_3_4_5
{
    class Carrera
    {
        private long _duracion;
        private string _nombre;
        private string _descripcion;


        public long Duracion
        {
            get
            {
                return this._duracion;
            }
            set
            {
                if (value > 0)
                    this._duracion = value;

            }
        }
        public string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 200))
                {
                    this._descripcion = value;
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
                if (value != null || (value.Length > 2 && value.Length <= 200))
                {
                    this._descripcion = value;
                }

            }
        }


    }
}

