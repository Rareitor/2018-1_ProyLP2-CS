using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ManualDA
    {


        public void cargarArchivo(byte [] archivo)
        {
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                  "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "SUBIR_PDF";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_PDF", MySqlDbType.Binary).Value = archivo;
            comando.ExecuteNonQuery();
            con.Close();

        }

        //public byte [] BajarManual()
        //{
        //    string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
        //          "port=3306;password=4LDJZU;SslMode=none;" + " ";

        //    MySqlConnection con = new MySqlConnection(cadena);
        //    MySqlCommand comando = new MySqlCommand();
        //    con.Open();
            

        //    comando.Connection = con;
        //    comando.CommandText = "BAJAR_PDF";
        //    comando.CommandType = System.Data.CommandType.StoredProcedure;
        //    comando.Parameters.Add("arch", MySqlDbType.Blob).Direction = System.Data.ParameterDirection.Output;
        //    MySqlDataReader rs = comando.ExecuteReader();
        //    while (rs.Read())
        //    {
              
        //    }


            
        //    con.Close();
        //}
    }
}
