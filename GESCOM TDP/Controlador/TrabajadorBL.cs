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
    public class TrabajadorBL
    {
        TrabajadorDA accesoTrabajador = new TrabajadorDA();

        public string gestionarUsuarios(Trabajador t, string idSuperior, int opcion)
        {
            string idUsuario ="";
            if (opcion == 1) //Agregar un usuario
            {
               idUsuario = accesoTrabajador.insertarUsuario(t, idSuperior);
                return idUsuario;
            } else if (opcion == 2)
            {
                accesoTrabajador.modificarRegistro(t, idSuperior);
                return "Correcto";
            } else if (opcion == 3)
            {
                accesoTrabajador.eliminarUsuario(t);
                return "Correcto";
            }

            return idUsuario;
        }

        public void recuperarTrabajador(Trabajador trab)
        {
            accesoTrabajador.recuperarUsuario(trab);
        }

        public BindingList<String> listarCampos(string nombre, string apellidoPat, string apellidoMat, 
            string email, string dni)
        {
            return accesoTrabajador.listarCampos(nombre,apellidoPat, apellidoMat,email, dni);

        }
        public BindingList<Trabajador> busquedaPersonalizada(string dni, 
            string nombre,string apellidoPat, string apellidoMat, string correo)
        {

            return accesoTrabajador.listarBusqueda(dni, nombre, apellidoPat, apellidoMat, correo);

        }

        public BindingList<Trabajador> listarGerentes()
        {
            return accesoTrabajador.listar("GERENTE","ALL");
        }

        public BindingList<Trabajador> listarJefes()
        {
            return accesoTrabajador.listar("JEFE","ALL");
        }

        public BindingList<Trabajador> listarComisionistas()
        {
            return accesoTrabajador.listar("COMISIONISTA", "ALL");
        }


        public BindingList<Trabajador> listarPayees()
        {
            return accesoTrabajador.listarPayees();
        }

        public BindingList<Trabajador> listarMisJefes(String idPayee)
        {
            return accesoTrabajador.listar("JEFE", idPayee);
        }

        public BindingList<Trabajador> listarMisComisionistas(String idPayee)
        {
            return accesoTrabajador.listar("COMISIONISTA", idPayee);
        }
        
        public string existeUsuarioyContraseña(string usuario, string contraseña, ref int existeUsu,ref int errorContra
            ,ref string id_usuario, ref string nombreUsu, ref string apellidoPat)
        {

            return accesoTrabajador.login(usuario, contraseña, ref existeUsu, ref errorContra, ref id_usuario, ref nombreUsu, ref apellidoPat);
        }

        public void obtenerDatos(string usuario, ref string id_usuario, ref string nombreUsu, ref string apellidoPat)
        {
            accesoTrabajador.obtenerDatos(usuario, ref id_usuario, ref nombreUsu, ref apellidoPat);
        }

        public Trabajador correoycontaseña(string dato)
        {
            return accesoTrabajador.obtenerLogin(dato);
        }

        public BindingList<Trabajador> listarTrabajadorPapelera()
        {
            return accesoTrabajador.listarTrabajadorPapelera();
        }

        public BindingList<String> listarCorreos()
        {
            return accesoTrabajador.listarCorreos();
        }

        public BindingList<String> listarDni()
        {
            return accesoTrabajador.listarDni();
        }
    }
}
