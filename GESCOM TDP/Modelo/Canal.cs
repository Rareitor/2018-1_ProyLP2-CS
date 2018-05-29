using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Canal
    {
    //atributos
        private string idCanal;
        private string nombre;
    //métodos
        //contructor
        public Canal()
        {
        }

        //setters y getters
        public string IdCanal { get => idCanal; set => idCanal = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //métodos adicionales

    }
}
