using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    /*Clase abstracta que representa a todas las clases que tenga como PK a un id,
    tengan una fecha de validad y un canal de venta. */
    public abstract class Entidad
    {
    //atributos
        private String id;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private Canal canal;
    //métodos
        //constructores
        public Entidad()
        {
        }
        //setters y getters
        public string Id { get => id; set => id = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        internal Canal Canal { get => canal; set => canal = value; }
        //métodos adicionales
    }
}
