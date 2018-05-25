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
    public class OrdenDA
    {
        public string registrarOrden(Orden o)
        {

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "AGREGAR_ORDEN";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("_fechaVenta", MySqlDbType.Date).Value = o.FechaVenta;
            comando.Parameters.Add("_idPayee", MySqlDbType.VarChar).Value = o.Trabajador.IdTrabajador;
            comando.Parameters.Add("_montoPago", MySqlDbType.Float).Value = o.Monto;
            comando.Parameters.Add("_idProducto", MySqlDbType.VarChar).Value = o.Producto.IdProducto;
            comando.Parameters.Add("_idCombo", MySqlDbType.VarChar).Value = o.Combo.IdCombo;
            comando.Parameters.Add("_idCanal", MySqlDbType.VarChar).Value = o.Canal.IdCanal;
            comando.Parameters.Add("_idOrden", MySqlDbType.VarChar).Direction = System.Data.ParameterDirection.Output;
            comando.ExecuteNonQuery();
            string idOrden = comando.Parameters["_idOrden"].Value.ToString();
     
            con.Close();
            return idOrden;
            
        }

        public void modificarOrden(Orden o)
        {

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "MODIFICAR_ORDEN";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("_fechaVenta", MySqlDbType.Date).Value = o.FechaVenta;
            comando.Parameters.Add("_idPayee", MySqlDbType.VarChar).Value = o.Trabajador.IdTrabajador;
            comando.Parameters.Add("_montoPago", MySqlDbType.Float).Value = o.Monto;
            comando.Parameters.Add("_idProducto", MySqlDbType.VarChar).Value = o.Producto.IdProducto;
            comando.Parameters.Add("_idCombo", MySqlDbType.VarChar).Value = o.Combo.IdCombo;
            comando.Parameters.Add("_idCanal", MySqlDbType.VarChar).Value = o.Canal.IdCanal;
            comando.Parameters.Add("_idOrden", MySqlDbType.VarChar).Direction = System.Data.ParameterDirection.Output;
            comando.ExecuteNonQuery();
            string idOrden = comando.Parameters["_idOrden"].Value.ToString();

            con.Close();
           
        }

        public void eliminarOrden(Orden o)
        {

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "ELIMINAR_ORDEN";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("_idOrden", MySqlDbType.Int32).Value = o.Id;
            comando.ExecuteNonQuery();

            con.Close();
        }

        public BindingList<Orden> listarOrden()
        {
            BindingList<Orden> listaOrden = new BindingList<Orden>(); 

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "LISTAR_ORDENES_ADMIN";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                Orden o= new Orden();
                o.Canal = new Canal();
                o.Canal.IdCanal = rs.GetString("idCanal");
                o.Canal.Nombre = rs.GetString("nombreCanal");
                o.Combo = new Combo();
                o.Combo.IdCombo = rs.GetString("idCombo");
                o.Combo.Nombre = rs.GetString("nombreCombo");
                o.Producto = new Producto();
                o.Producto.IdProducto = rs.GetString("idProducto");
                o.Producto.Nombre = rs.GetString("nombreProducto");
                o.Monto = rs.GetFloat("monto");
                o.Trabajador = new Trabajador();
                o.Trabajador.IdTrabajador = rs.GetString("idPayee");
                o.Id = rs.GetString("idOrden");
                o.FechaVenta = rs.GetDateTime("fechaVenta");
                listaOrden.Add(o);


            }
            con.Close();
            return listaOrden;
        }
    }
}
