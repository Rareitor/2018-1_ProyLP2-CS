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
    public class OrdenBL
    {
        OrdenDA accesoOrden = new OrdenDA();

        public string gestionarOrden(Orden o, int opcion)
        {
            string respuesta= "";
            if (opcion == 1)
            {
                //registrar una orden
               respuesta = accesoOrden.registrarOrden(o);
            } else if(opcion == 2)
            {
                //modificar una orden
                accesoOrden.modificarOrden(o);
                respuesta= "Correcta";
            } else if (opcion == 3)
            {
                //eliminar una orden
                accesoOrden.eliminarOrden(o);
                respuesta = "Correcta";
            }

            return respuesta;
        }

        public BindingList<Orden> listarOrden()
        {
            return accesoOrden.listarOrden();
        }
    }
}
