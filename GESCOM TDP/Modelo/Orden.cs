using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Orden
    {
    //atributos
        private String id;
        private DateTime fechaVenta;
        private Producto producto;
        private Canal canal;
        private Payee payee;
        private Retribucion retribucion;
    //métodos
        //constructores
        public Orden()
        {
        }
        //setters y getters
        public string Id { get => id; set => id = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public Producto Producto { get => producto; set => producto = value; }
        internal Canal Canal { get => canal; set => canal = value; }


        //métodos dicionales
        //no implementado hasta definir casteo y/o polimorfismo
        //public Retribucion Retribucion { get => _retribucion; set => _retribucion = value; }
        //no implementado hasta definir casteo y/o polimorfismo
        //public Payee Payee { get => _payee; set => _payee = value; }

        public void CalcularComision()
        {
            //cálculo
        }
    }
}
