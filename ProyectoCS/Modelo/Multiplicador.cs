using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Multiplicador :Parametrica
    {
    //atributos
        float mult;
        private string descripcion;
    //métodos
        //constructores
        public Multiplicador()
        {

        }
        //setters y getters
        public float Mult { get => mult; set => mult = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        //métodos adicionales
        public override void mostrarReporte()
        {
        }
    }
}
