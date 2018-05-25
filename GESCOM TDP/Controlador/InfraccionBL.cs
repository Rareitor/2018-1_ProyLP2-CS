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
    public class InfraccionBL
    {
        InfraccionDA accesoInfraccion = new InfraccionDA();

        public void registrarInfraccion(Infraccion i)
        {
            accesoInfraccion.registrarInfraccion(i);
        }

        public BindingList<Infraccion> listarInfracciones()
        {
            return accesoInfraccion.listarInfracciones();

        }
    }
}
