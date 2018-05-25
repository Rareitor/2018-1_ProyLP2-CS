using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ComboProducto : Parametrica
    {
    //atributos
        private List<Producto> productos;
    //métodos
        //constructores
        public ComboProducto()
        {
            productos = new List<Producto>();
        }
        //setters y getters
        internal List<Producto> Productos { get => productos; set => productos = value; }

        //métodos adicionales
        /*public void InsertarProductosCombo(Producto p)
        {
            productos.Add(p);
        }*/

        public void InsertarProductosCombo(Producto p) { }
        public void emitirReporte(){}

        public override void mostrarReporte()
        {
            throw new NotImplementedException();
        }
    }
}
