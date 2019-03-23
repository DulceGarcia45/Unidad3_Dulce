using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Cinema.Modelo
{
    class Asiento : Sala
    {
        private int _numero;
        private bool _estaDisponible;
        private Sala _sala;
        public Sala sala = new Sala();

       

        public  void Diasponibilidad (bool disponibilidad)
        {
            _estaDisponible = disponibilidad;
            
        }
        public int Numero
        {
            get { return _numero; }

            set { _numero = value; }
        }
        public bool EstaDisponible
        {
            get { return _estaDisponible;}
            set { _estaDisponible = value; }
        }

        public override string ToString()
        {
            return "Numero" + _numero + "|EstaDisponible"+_estaDisponible;
        }
    }
}
