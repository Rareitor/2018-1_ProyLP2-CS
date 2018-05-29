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
        private Canal canal;
        private Combo combo;
        private Producto producto;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string tipo;
        private string periodo;

        public Canal Canal1 { get => canal; set => canal = value; }
        public Combo Combo1 { get => combo; set => combo = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public DateTime FechaInicio1 { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin1 { get => fechaFin; set => fechaFin = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Periodo { get => periodo; set => periodo = value; }

        public string NombreCanal { get => canal.Nombre; }
        public String NombreCombo { get => combo.Nombre; }

        public string NombreProducto { get => producto.Nombre; }

        //métodos
        //constructores
        public ComboProducto()
        {
            
        }
        //setters y getters
      
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
