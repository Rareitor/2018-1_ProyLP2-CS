using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Infraccion
    {
        private int idInfraccion;
        private string idPayeeReportador;
        private DateTime fecha;
        private string texto;

        public int IdInfraccion { get => idInfraccion; set => idInfraccion = value; }
        public string IdPayeeReportador { get => idPayeeReportador; set => idPayeeReportador = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Texto { get => texto; set => texto = value; }
    }
}
