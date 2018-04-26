using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comision : Retribucion
    {
     //atributos
        private float monto;
        private DateTime fechaVenta;
        private DateTime fechaEmision;
    //métodos
        //constructor
        public Comision()
        {
        }

        //setters y getters
        public float Monto { get => monto; set => monto = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        //métodos adicionales
        

    }
}
