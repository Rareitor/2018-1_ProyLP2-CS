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
    public class InfraccionDA
    {
        public void registrarInfraccion(Infraccion i)
        {
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
       "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "AGREGAR_INFRACCION";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("_idPayeeReportador", MySqlDbType.VarChar).Value = i.IdPayeeReportador;
            comando.Parameters.Add("_texto", MySqlDbType.Text).Value = i.Texto;
            comando.Parameters.Add("_fechaPublicado", MySqlDbType.DateTime).Value = i.Fecha;
            comando.Parameters.Add("_idInfraccion", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
           
            comando.ExecuteNonQuery();

            con.Close();

        }

        public BindingList<Infraccion> listarInfracciones()
        {
            BindingList<Infraccion> lista= new BindingList<Infraccion>();
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
       "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "RECOGER_INFRACCION";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Infraccion i = new Infraccion();
                i.Fecha = rs.GetDateTime("fechaPublicado");
                i.IdInfraccion = rs.GetInt32("idInfraccion");
                i.IdPayeeReportador = rs.GetString("idPayee");
                i.Texto = rs.GetString("texto");
                lista.Add(i);
            }


            con.Close();
            return lista;
        }
    }
}
