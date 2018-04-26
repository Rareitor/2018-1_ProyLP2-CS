using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;

namespace Controlador
{
    public class PersonaBL
    {
        private PersonaDA accesoDatosPersona;

        public PersonaBL()
        {
            accesoDatosPersona = new PersonaDA();
        }

        public bool agregarPersona(Persona p)
        {
            return accesoDatosPersona.agregarPersona(p);
        }
    }
}
