using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Orden
    {
    //atributos
        private string id;
        private DateTime fechaVenta;
        private Producto producto;
        private Canal canal;
        private Trabajador trabajador;
        private Retribucion retribucion;
        private Combo combo;
        private double monto;

        private string nombreTrabajadorCompleto;
        private string distrito;

    //métodos
        //constructores
        public Orden()
        {
        }
        //setters y getters
        public string Id { get => id; set => id = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public Canal Canal { get => canal; set => canal = value; }
        public Trabajador Trabajador { get => trabajador; set => trabajador = value; }
        public Retribucion Retribucion { get => retribucion; set => retribucion = value; }
        public Combo Combo { get => combo; set => combo = value; }
        public double Monto { get => Math.Round(monto,2); set => monto = value; }
        public string IdComisionista { get => trabajador.IdTrabajador; }
        public string NombreProducto { get => producto.Nombre; }
        public string NombreComisionista { get => trabajador.Nombre; }
        public string NombreCanal { get => canal.Nombre; }
        public string NombreCombo { get => combo.Nombre; }
        public string NombreTrabajadorCompleto { get => nombreTrabajadorCompleto; set => nombreTrabajadorCompleto = value; }
        public string Distrito { get => distrito; set => distrito = value; }

        //métodos dicionales
        //no implementado hasta definir casteo y/o polimorfismo
        //public Retribucion Retribucion { get => _retribucion; set => _retribucion = value; }
        //no implementado hasta definir casteo y/o polimorfismo
        //public Payee Payee { get => _payee; set => _payee = value; }

        public void CalcularComision()
        {
            //cálculo
        }
    }
}
