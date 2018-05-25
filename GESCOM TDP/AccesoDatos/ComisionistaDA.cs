using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class ComisionistaDA
    {
        public string ComprobarConexion()
        {
            string mensaje;
            try
            {
                String cadena = "server=200.16.7.96;" +
                               "user=inf282g8;database=inf282g8;" +
                               "port=3306;password=4LDJZU;SslMode=none;" +
                               "";

                MySqlConnection con = new MySqlConnection(cadena);

                con.Open();
                mensaje = "Conexion exitosa";
                con.Close();
            }
            catch (Exception e)
            {
                mensaje = "Conexion erronea";
            }
            return mensaje;
        }
        public bool RegistrarComisionista(Comisionista comisionista)
        {
            try
            {
                String cadena = "server=200.16.7.96;" +
                               "user=inf282g8;database=inf282g8;" +
                               "port=3306;password=4LDJZU;SslMode=none;" +
                               "";

                MySqlConnection con = new MySqlConnection(cadena);

                con.Open();
                MySqlCommand comando = new MySqlCommand
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "insertarPayee",
                    Connection = con
                };
                comando.Parameters.Add("_idPayee", MySqlDbType.VarChar).Value =  comisionista.IdTrabajador;
                comando.Parameters.Add("_nombre", MySqlDbType.VarChar).Value =   comisionista.Nombre;
                comando.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public BindingList<Comisionista> ListarComisionista()
        {
            try
            {
                BindingList<Comisionista> lista = new BindingList<Comisionista>();
                String cadena = "server=200.16.7.96;" +
                                "user=inf282g8;database=inf282g8;" +
                                "port=3306;password=4LDJZU;SslMode=none;" +
                                "";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT idPayee, nombre FROM Payee";
                comando.Connection = con;
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Comisionista c = new Comisionista
                    {
                        IdTrabajador = reader.GetString("idPayee"),
                        Nombre = reader.GetString("nombre")
                    };
                    lista.Add(c);
                }
                con.Close();
                return lista;
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool ActualizarComisionista(Comisionista com)
        {
            try
            {
                String cadena = "server=200.16.7.96;" +
                                "user=inf282g8;database=inf282g8;" +
                                "port=3306;password=4LDJZU;SslMode=none;" +
                                "";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();

                MySqlCommand cmd = new MySqlCommand();
                string sql = "UPDATE Payee SET nombre = '" + com.Nombre + "' WHERE idPayee = '" + com.IdTrabajador+ "'";
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                con.Close();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool BorrarComisionista(Comisionista com)
        {
            try
            {
                String cadena = "server=200.16.7.96;" +
                               "user=inf282g8;database=inf282g8;" +
                               "port=3306;password=4LDJZU;SslMode=none;" +
                               "";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();

                MySqlCommand cmd = new MySqlCommand();
                string sql = "DELETE FROM Payee WHERE idPayee = '" + com.IdTrabajador + "'";
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                con.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
