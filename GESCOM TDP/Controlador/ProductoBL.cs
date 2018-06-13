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

        public BindingList<Producto> listarProductosPapelera()
        {
            return accesoDatos.listarProductosPapelera();
        }

        public BindingList<String> listarTiposProductos()
        {
            return accesoDatos.listarTiposProductos();
        }

        public void recuperarProducto(Producto producto)
        {
            accesoDatos.recuperarProducto(producto);
        }
        public void cargarProducto(Producto p)
        {
            accesoDatos.cargarProducto(p);
        }

        public BindingList<Producto> listarMenosVendidos(DateTime fecha)
        {
            int anho = fecha.Year;
            int mes = fecha.Month;
            string cadena;
            if (mes >= 10)
            {
                cadena= anho.ToString() + mes.ToString();
            } else
            {
                cadena = anho.ToString() + "0" + mes.ToString();
            }
            return accesoDatos.listarmenosvendidos(cadena);
        }
    }
}
