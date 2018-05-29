using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Sede
    {
        int idLocal;
        string distrito;
        string direccion;

        public int IdLocal { get => idLocal; set => idLocal = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        override
        public string ToString()
        {
            return Distrito;
        }
    }
}
