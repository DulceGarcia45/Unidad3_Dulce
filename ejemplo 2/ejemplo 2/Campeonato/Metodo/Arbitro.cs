using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Campeonato.Metodo
{
    class Arbitro
    {
        private int _aniosExperiencia;
        private bool _tieneGafete;
        private string _arbitro1;
        private string _arbitro2;
        private Partido _isFinalizado;
        private Partido _idPartido;
        private Partido _fecha;

        // asociacion con partido 
        private Partido _partido;
        public int AnosExperiencia
        {
            get
            {
                return this._aniosExperiencia;
            }
            set
            {
                if (value > 0)
                {
                    this._aniosExperiencia = value;
                }
            }
        }
        public bool TieneGafete
        {
            get
            {
                return this._tieneGafete;
            }
            set
            {
              
                this._tieneGafete = value;
            }
        }
    
    public string Arbitro1
        {
            get
            {
                return this._arbitro1;
            }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 30))
                {
                    this._arbitro1 = value;
                }


            }
        }
        public string Arbitro2 {

            get
            {
                return this._arbitro2;
            }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 30))
                {
                    this._arbitro2 = value;
                }


            }
        }

        public  void addObservacion (Partido A)
        {
            this._partido = A;
            

        }
        public void setisFinalizado (Partido A)
        {
          
       
            this._isFinalizado = false;
            this._idPartido = 1;
            Random alea = new Random();
            int dia = alea.Next(1, 31);

            this._fecha = new DateTime(2019, 3, dia, 16, 0, 0);
        }
    }
   
}

