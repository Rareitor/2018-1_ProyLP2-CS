using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Comisionista : Trabajador
    {
    //atributos
        private TipoLocacion region;
    //métodos
        //constructor
        public Comisionista()
        {
        }
        //setters y getters
        internal TipoLocacion Region { get => region; set => region = value; }
        //métodos adicionales
        public override void emitirReporte()
        {
        }
    }
}
