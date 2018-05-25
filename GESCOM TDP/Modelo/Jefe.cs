using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Jefe : Payee
    {
     //atributos
        private List<Comisionista> listaComisionistas;
        private TipoLocacion sede;



    //métodos
        //constructores
        public Jefe()
        {
            listaComisionistas = new List<Comisionista>();
        }

        //setters y getters
        internal List<Comisionista> ListaComisionistas { get => listaComisionistas; set => listaComisionistas = value; }
        internal TipoLocacion Sede { get => sede; set => sede = value; }

        //métodos adicionales
        public override void emitirReporte()
        {
            throw new NotImplementedException();
        }

        public void listarComisionistas()
        {
        }
    }
}
