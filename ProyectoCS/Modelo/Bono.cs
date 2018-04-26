using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Bono : Retribucion
    {
    //atributos
        private float monto;
        private DateTime fechaEmision;
    //métodos
        //constructores
        public Bono()
        {
        }

        //setters y getters
        public float Monto { get => monto; set => monto = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        //métodos adicionales

    }
}
