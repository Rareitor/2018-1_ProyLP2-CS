using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public abstract class Payee : Trabajador
    {
    //atributos
    //métodos
        //constructores
        public Payee()
        {
        }

        //métodos adicionales
        override public abstract void emitirReporte();
    }
}
