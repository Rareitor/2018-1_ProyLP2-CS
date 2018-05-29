using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Entidad
    {
    //atributos
        private int id;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private Canal canal;
    //métodos
        //constructores
        public Entidad()
        {
        }
        //setters y getters
        
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public int Id { get => id; set => id = value; }
        internal Canal Canal { get => canal; set => canal = value; }
        //métodos adicionales
    }
}
