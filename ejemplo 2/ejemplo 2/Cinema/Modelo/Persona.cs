using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2.Cinema.Modelo
{
    public  class Persona
    {
        //propiedades de las clases
        protected int _id;
        protected string _nombre;
        protected string _domicilio;
        protected string _email;
        protected string _usuario;
        protected string _password;

        // constructor default
        public Persona()
        {
            _nombre = "Juanito Pérez Rodrígues";

        }
        public Persona (string nombre)
        {
            _nombre = nombre;

        }
        public Persona (int id, string nombre, string domicilio, string email, string usuario, string password)
        {
            _id = id;
            _nombre = nombre;
            _domicilio = domicilio;
            _email = email;
            _usuario = usuario;
            this._password = password;



        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                    _id = value;
            }
        }
            public string  Nombre

        {
            get
            {
                return _nombre;

            }
            set
            {
                if (value.Length >= 0)
                    _nombre = value;
            }

        }
        public string Domicilio

        {
            get
            {
                return _domicilio;

            }
            set
            {
                if (value.Length >= 0)
                    _domicilio = value;
            }

        }
        public string Email

        {
            get
            {
                return _email;

            }
            set
            {
                if (value.Length > 0 )
                    _email = value;
            }

        }
        public string usuario

        {
            get
            {
                return _usuario;

            }
            set
            {
                if (value.Length > 0)
                    _usuario = value;
            }

        }
        public string Password

        {
            get
            {
                return _password;

            }
            set
            {
                if (value.Length > 0 && value.Length <= 15)
                    _password = value;
            }

        }

        public override string ToString()
        {
            return "Id:"+ _id + "|Nombre:"+_nombre +"|Domicilia:"+_domicilio+"|Email"+ _email+"|Usuario"+_usuario;
        }
    }

    }

