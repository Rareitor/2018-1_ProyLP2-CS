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
    public class NoticiaBL
    {
        private NoticiaDA accesoNoticias = new NoticiaDA();

        public void registrarNoticia(Noticia n)
        {
            accesoNoticias.registrarNoticias(n);
        }

        public BindingList<Noticia> listarNoticias()
        {
            return accesoNoticias.listarNoticias();
        }

        public void registrarVisita(int index, string idUsuario)
        {
            accesoNoticias.registrarVistaNoticia(idUsuario, index);
        }

        public BindingList<int> listarVisitadas(string idUsuario)
        {
            return accesoNoticias.listarVisitadas(idUsuario);
        }
    }
}
