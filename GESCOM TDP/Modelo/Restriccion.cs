using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Restriccion :Parametrica
    {
    //atributos
        private string descripcion;
        private int numValor;
    //métodos
        //contsructores
        public Restriccion()
        {

        }
        //setters y getters
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int NumValor { get => numValor; set => numValor = value; }

        //métodos adicionales
        public override void mostrarReporte()
        {
        }

        
    }
}
