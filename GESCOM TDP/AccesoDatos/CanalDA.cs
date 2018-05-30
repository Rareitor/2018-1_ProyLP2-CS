using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CanalDA
    {
        public BindingList<Canal> ListarCanales()
        {
            BindingList<Canal> listaCanales = new BindingList<Canal>();

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "LISTAR_CANAL";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Canal c = new Canal();
                c.IdCanal = rs.GetString("idCanal");
                c.Nombre = rs.GetString("nombre");

                listaCanales.Add(c);
            }
            con.Close();

            return listaCanales;

        }

        public void cargarCanal(Canal c)
        {

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "INSERT INTO Canal values ('"+ c.IdCanal + "','"
                + c.Nombre +"', 1);";
            comando.ExecuteNonQuery();

            con.Close();
        }
    }
}
