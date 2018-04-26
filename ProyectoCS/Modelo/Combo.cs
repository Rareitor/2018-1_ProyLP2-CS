using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Combo : Entidad
    {
    //atributos
        private List<Producto> productos;
    //métodos
        //constructores
        public Combo()
        {
            productos = new List<Producto>();
        }

        //setters y getters
        internal List<Producto> Productos { get => productos; set => productos = value; }

        //métodos adicionales
        public void AgregarProducto(Producto producto) { }
        public void EliminarProducto(String producto) { }
    }
}
