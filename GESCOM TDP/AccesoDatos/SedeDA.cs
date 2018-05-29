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
    public class SedeDA
    {
        public BindingList<Sede> listarSedes()
        {
            BindingList<Sede> listaSedes = new BindingList<Sede>();

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();
            
            comando.Connection = con;
            comando.CommandText = "LISTAR_UBICACIONES";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Sede s = new Sede();
                s.Distrito = rs.GetString("distrito");
                //s.Direccion = rs.GetString("direccion");
                s.IdLocal = rs.GetInt32("idUbicacion");
                listaSedes.Add(s);
                
            }

            con.Close();
            return listaSedes;

        }

    }
}
