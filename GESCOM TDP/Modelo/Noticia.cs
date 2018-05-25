using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Noticia
    {
        private Trabajador trabajador;
        private DateTime fecha;
        private int id;
        private string texto;
        private string titulo;

        public Trabajador Trabajador { get => trabajador; set => trabajador = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id { get => id; set => id = value; }
        public string Texto { get => texto; set => texto = value; }
        public string Titulo { get => titulo; set => titulo = value; }

        public string Mostrar { get=> "[ " + fecha.ToString() + " ] " + titulo; }
        public override string ToString()
        {
            return "[ " + fecha.ToString() + " ] " + titulo;
        }
    }
}
