using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Modelo
{
    class Carrera
    {
        private long _duracion;
        private string _nombre;
        private string _descripcion;


        public long NumeroControl
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
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public long Duracion { get; set; }

    }
}

