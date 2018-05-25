using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace Controlador
{
    public class ComisionistaBL
    {
        private ComisionistaDA accesoDatos;

        public ComisionistaBL()
        {
            accesoDatos = new ComisionistaDA();
        }

        public BindingList<Comisionista> ListarComisionista()
        {
            return accesoDatos.ListarComisionista();
        }

        public bool RegistrarComisionista(Comisionista comisionista)
        {
            return accesoDatos.RegistrarComisionista(comisionista);
        }

        public bool ActualizarComisionista(Comisionista comisionista)
        {
            return accesoDatos.ActualizarComisionista(comisionista);
        }

        public bool BorrarComisionista(Comisionista comisionista)
        {
            return accesoDatos.BorrarComisionista(comisionista);
        }
    }
}

