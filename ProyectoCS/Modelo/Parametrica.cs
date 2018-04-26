using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Parametrica
    {
    //atributos
        private Canal canal;
        private Combo combo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
    //métodos
        //setters y getters
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        internal Canal Canal { get => canal; set => canal = value; }
        internal Combo Combo { get => combo; set => combo = value; }
    //métodos adicionales
        public abstract void  mostrarReporte();

    }
}
