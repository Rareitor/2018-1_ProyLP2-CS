using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Gerente :Trabajador
    {
    //atributos
        private List<Jefe> listaJefes;
        private TipoLocacion sede;
    //métodos
        //constructor
        public Gerente()
        {
            listaJefes = new List<Jefe>();
        }
        //setters y getters
        internal List<Jefe> ListaJefes { get => listaJefes; set => listaJefes = value; }
        internal TipoLocacion Sede { get => sede; set => sede = value; }
        //métodos adicionales
        

        public void listarJefes()
        {
        }
    }
}
