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
        private string responsable;
        private string zona;  
    //métodos
        //contructor
        public Canal()
        {
        }

        //setters y getters
        public string IdCanal { get => idCanal; set => idCanal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        public string Zona { get => zona; set => zona = value; }

        //métodos adicionales

    }
}
