using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class NoticiaDA
    {
        public void registrarNoticias(Noticia n)
        {
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                   "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "AGREGAR_NOTICIA";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("_idPayee", MySqlDbType.VarChar).Value = n.Trabajador.IdTrabajador;
            comando.Parameters.Add("_texto", MySqlDbType.Text).Value = n.Texto;
            comando.Parameters.Add("_fecha", MySqlDbType.DateTime).Value = n.Fecha;
            comando.Parameters.Add("_idNoticia", MySqlDbType.Int32).Direction= System.Data.ParameterDirection.Output;
            comando.Parameters.Add("_titulo", MySqlDbType.Text).Value = n.Titulo;
            comando.ExecuteNonQuery();

            con.Close();

        }

        public BindingList<Noticia> listarNoticias()
        {
            BindingList<Noticia> listaNoticia = new BindingList<Noticia>();

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                   "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "RECOGER_NOTICIA";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Noticia n = new Noticia();

                n.Titulo = rs.GetString("titulo");
                n.Trabajador = new Trabajador();
                n.Id = rs.GetInt32("idNoticia");
                n.Trabajador.IdTrabajador = rs.GetString("idPayee");
                n.Texto=rs.GetString("texto");
                n.Fecha = rs.GetDateTime("fechaPublicacion");

                listaNoticia.Add(n);
            }
            

            con.Close();
            return listaNoticia;
        }
    }
}
