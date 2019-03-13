using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Campeonato.Metodo
{
    class Persona
    {
        private int _id;
        private string _nombre;
        private string _apellidos;
        private DateTime _fechaNacimiento;

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
        public string Apellido
        {
            get
            {
                return this._apellidos;
            }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 60))
                {
                    this._apellidos = value;
                }

            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return this._fechaNacimiento;
            }
            set
            {
                {
                    DateTime inicio = new DateTime(2019, 3, 8);
                    if (value <= inicio)
                    {
                        this._fechaNacimiento = value;
                    }
                }
            }
        }
    }
}
