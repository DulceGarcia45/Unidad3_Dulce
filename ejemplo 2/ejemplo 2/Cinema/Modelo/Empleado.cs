using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Cinema.Modelo
{
    class Empleado:Persona
    {
        private int _numeroEmpleado;
        private string _tipoEmpleado;

        public Empleado() : base()
        {
        }

        public Empleado(int numero, string tipo)
        {
            _numeroEmpleado = numero;
            _tipoEmpleado = tipo;
        }
        public int NumeroEmpleado
        {
            get { return _numeroEmpleado; }

            set
            {
                if (value >= 0)
                    _numeroEmpleado = value;
            }
        }
            public string TipoEmpleado
        {
            get { return _tipoEmpleado; }

            set
            {
                if (value.Length > 0 && value.Length <= 150)
                    _tipoEmpleado = value;
            }
        }
    }
}
