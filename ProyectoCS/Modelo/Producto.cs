using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto : Entidad
    {
    //atributos
        private int stock;
        private float precioEstandar;
        private String nombre;
        private String marca;

    //métodos
        //constructores
        public Producto()
        {

        }
        //setters y getters
        protected int Stock { get => stock; set => stock = value; }
        protected float PrecioEstandar { get => precioEstandar; set => precioEstandar = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Marca { get => marca; set => marca = value; }

        //métodos adicionales


        //public void MostrarDatos() { }
    }
}
