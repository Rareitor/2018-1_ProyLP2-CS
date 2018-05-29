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
    public class SedeBL
    {
        private SedeDA accesoSede= new SedeDA();

      

        public BindingList<Sede> listarSedes()
        {
            return accesoSede.listarSedes();
        }

    }
}
