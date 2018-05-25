using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ProductoBL
    {
        private ProductoDA accesoDatos = new ProductoDA();

        public BindingList<Producto> listarProductos()
        {
            return accesoDatos.listarProductos();
        }
    }
}
