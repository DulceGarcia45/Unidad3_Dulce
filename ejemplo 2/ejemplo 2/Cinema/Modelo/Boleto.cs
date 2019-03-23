using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Cinema.Modelo
{
    class Boleto
    {
        private long _folio;
        private DateTime _fecha;
        private int _asiento;
        private double _costo;
        private Reservacion _reservacion;

        public Boleto()
        {
            _reservacion =  new Reservacion();
        }

        public Boleto (Reservacion reservacion)
        {
            _reservacion = reservacion;
        }
        public void boleto()
        {
            return;
        }
        public long Folio  

        {
            get { return _folio; }
            set{
                if (value > 0)
                    {
                        _folio = value;
                    }

            }
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
        public int Asiento
        {
            get
            {
                return _asiento;
            }
            set {
                if (value > 0)
                {
                    _asiento = value;
                }
            }
        }
        public double Costo
        {
            get
            {
                return _costo;
            }
            set
            {
                if (value > 0)
                {
                    _costo = value;
                }
            }
        }
        public override string ToString()
        {
            return "Folio" + _folio + "|Fecha" + _fecha + "|Asiento" + _asiento + "|Costo" + _costo;
        }
    }
}
