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
        private string idCombo;
        private string tipo;
        private string nombre;

    //métodos
        //constructores
        public Combo()
        {
            productos = new List<Producto>();
        }

        public string IdCombo { get => idCombo; set => idCombo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //setters y getters
        internal List<Producto> Productos { get => productos; set => productos = value; }

        //métodos adicionales
        public void AgregarProducto(Producto producto) { }
        public void EliminarProducto(String producto) { }
    }
}
