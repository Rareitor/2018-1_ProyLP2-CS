using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class OrdenBL
    {
        OrdenDA accesoOrden = new OrdenDA();

        public string gestionarOrden(Orden o, int opcion, string tipoProducto)
        {
            string respuesta= "";
            if (opcion == 1)
            {
                //registrar una orden
               respuesta = accesoOrden.registrarOrden(o, tipoProducto);
            } else if(opcion == 2)
            {
                //modificar una orden
                accesoOrden.modificarOrden(o,tipoProducto);
                respuesta= "Correcta";
            } else if (opcion == 3)
            {
                //eliminar una orden
                accesoOrden.eliminarOrden(o);
                respuesta = "Correcta";
            }

            return respuesta;
        }

         public string GestionarOrden(Orden o, int opcion, string tipoProducto)
        {
            string respuesta= "";
            if (opcion == 1)
            {
                //registrar una orden
               respuesta = accesoOrden.registrarOrden(o, tipoProducto);
            } else if(opcion == 2)
            {
                //modificar una orden
                accesoOrden.modificarOrden(o,tipoProducto);
                respuesta= "Correcta";
            } else if (opcion == 3)
            {
                //eliminar una orden
                accesoOrden.eliminarOrden(o);
                respuesta = "Correcta";
            }

            return respuesta;
        }
        public void recuperarOrden(Orden ord)
        {
            accesoOrden.recuperarOrden(ord);
        }

        public BindingList<Orden> listarOrdenPapelera()
        {
            return accesoOrden.listarOrdenPapelera();
        }

        public BindingList<Orden> listarOrden()
        {
            return accesoOrden.listarOrden();
        }

        public BindingList<Orden> listarOrdenesComisionista(string idPayee, DateTime fecha1, DateTime fecha2)
        {
            return accesoOrden.listarOrdenesComisionista(idPayee, fecha1, fecha2);
        }

        public BindingList<Orden> listarOrdenesJefe(string idPayee, DateTime fecha1, DateTime fecha2)
        {
            return accesoOrden.listarOrdenesJefe(idPayee, fecha1, fecha2);
        }

        public BindingList<Orden> listarOrdenesGerente(string idGerente, DateTime fecha1, DateTime fecha2)
        {
            return accesoOrden.listarOrdenesGerente(idGerente,fecha1, fecha2);
        }

       
    }
}
