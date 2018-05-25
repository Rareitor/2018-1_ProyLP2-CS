using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Penalidad : Retribucion
    {
    //atributos
        private float porcentaje;
        private DateTime fechaDevengado;
        private string motivo;
        private char estado; //0 = activo y 1 = anulado
    //métodos
        //Constructor
        public Penalidad()
        {
        }

        //setters y getters
        public float Porcentaje { get => porcentaje; set => porcentaje = value; }
        public DateTime FechaDevengado { get => fechaDevengado; set => fechaDevengado = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public char Estado { get => estado; set => estado = value; }

        //métodos adicionales
        /*En caso de que el trabajador justifique la razÃ³n de su falta, 
        se puede anular la penalidad*/
        public void Anular() { }
    }
}
