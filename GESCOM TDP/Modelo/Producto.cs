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
        private string idProducto;
        private string tipo;
        private bool isVisible;

    //métodos
        //constructores
        public Producto()
        {

        }

        public string IdProducto { get => idProducto; set => idProducto = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        //setters y getters
        protected int Stock { get => stock; set => stock = value; }
        protected float PrecioEstandar { get => precioEstandar; set => precioEstandar = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        protected string Marca { get => marca; set => marca = value; }
        public bool IsVisible { get => isVisible; set => isVisible = value; }

        //métodos adicionales


        //public void MostrarDatos() { }
    }
}
