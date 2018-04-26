using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Retribucion
    {
    //atributos
        private string idRetribucion;
    //métodos
        //constructores
        public Retribucion()
        {
        }

        //setters y getters
        public string IdRetribucion { get => idRetribucion; set => idRetribucion = value; }

        //métodos adicionales

    }
}
