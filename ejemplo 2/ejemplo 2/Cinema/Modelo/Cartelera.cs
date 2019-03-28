using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Cinema.Modelo
{
    class Cartelera
    {
        private int _id;
        private DateTime _fecha;
        private string _horario;
        private string _tipo;
        private double _costo;

        public void agrepelicula(Pelicula _pelicula, Sala _sala, DateTime Fecha, string Horario, string Tipo)
        {
            _horario = Horario;
            _fecha = Fecha;
            _tipo = Tipo;


        }
        public void eliminarPelicula(Pelicula _pelicula)
        {
            return;
        }

        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
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
        public string Horario
        {
            get { return _horario; }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 30))
                {
                    this._horario = value;
                }
            }
        }

        public string Tipo
        {
            get { return _tipo; }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 80))
                {
                    this._tipo = value;
                }
            }
        }
        public double Costo
        {
            get { return _costo; }
            set {
                if (value > 0)
                {
                    _costo = value;
                }
            }
        }
        public override string ToString()
        {
            return "Id" + _id + "|Fecha" + _fecha + "|Horario" + _horario + "|Tipo " + _tipo + "|Costo" + _costo;
        }

    }
}
