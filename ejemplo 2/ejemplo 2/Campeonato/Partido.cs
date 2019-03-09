using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Campeonato
{
    class Partido
    {
        private int _id;
        private string _descripcion;
        private DateTime _fecha;
        private bool _isFinalizado;
        private string _observaciones;
        // asocia con cancha
        private Cancha _cancha1;
        private Equipo _local;
        private Equipo _visistante;

        // se asocia con arbitro
        private Arbitro _arbitro1;
        private Arbitro _arbitro2;

        // resultado de la asociacion

        private List<Cancha> _cancha = new List<Cancha>();
        private List<Arbitro> _arbitro1 = new List<Arbitro>();
        private List<Arbitro> _arbitro2 = new List<Arbitro>();

        //constructores default
        public addArbitro (Arbitro A)
        {
            this._arbitro1 = A;
            this._arbitro2 = A;

        }
        public void addCancha(Cancha C)
        {
            this._cancha1 = C;
        }
        public Partido ()
        {
            this._isFinalizado = false;
            this._id = 1;
            Random alea = new Random();
            int dia = alea.Next(1, 31);

            this._fecha = new DateTime(2019,3,dia,16,0,0);
        }
        public Partido(Equipo equipo1, Equipo equipo2)
        {
            this._local = equipo1;
            this._visistante = equipo2;

        }
        

        ///private Arbitro [] arbitro;
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool IsFinalizados { get; set; }


        
    }
}
