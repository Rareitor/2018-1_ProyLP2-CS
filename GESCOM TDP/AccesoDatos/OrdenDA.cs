using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class OrdenDA
    {
        public string registrarOrden(Orden o, string tipo)
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

            if (tipo == "ARCH")
            {
                comando.Parameters.Add("_tipo", MySqlDbType.VarChar).Value = o.Producto.Tipo;

            }
            else
            {
                comando.Parameters.Add("_tipo", MySqlDbType.VarChar).Value = tipo;
            }

            comando.ExecuteNonQuery();
            string idOrden = comando.Parameters["_idOrden"].Value.ToString();
     
            con.Close();
            return idOrden;
            
        }

        public void recuperarOrden(Orden ord)
        {
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                   "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "UPDATE Orden SET isVisible=1 WHERE idOrden=\"" + ord.Id + "\"";
            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<Orden> listarOrdenPapelera()
        {
            BindingList<Orden> listaOrdenBorradas = new BindingList<Orden>();
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
               "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "LISTAR_ORDENES_BORRADAS";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                Orden o = new Orden();
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
                listaOrdenBorradas.Add(o);

                Console.WriteLine(o.Trabajador.IdTrabajador);
            }
            con.Close();
            return listaOrdenBorradas;
        }

        public void modificarOrden(Orden o, string tipo)
        {
           
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            con.Open();
            string fePeriodo;

            int mes = o.FechaVenta.Month;
            int year = o.FechaVenta.Year;

            if (mes <= 9)
            {
                fePeriodo = year.ToString() + "0" + mes.ToString();
            } else
            {
                fePeriodo = year.ToString() + mes.ToString();
            }

     

            comando.CommandText = "UPDATE Retribucion SET idProducto = '" + o.Producto.IdProducto +
                "', idCombo = '" + o.Combo.IdCombo + "' ,idCanal = '" + o.Canal.IdCanal +
                "' ,tipo = '" + tipo + "' , monto = " + o.Monto + ", fePeriodo = '" +
                fePeriodo + "' where idOrden = " + o.Id + ";";
            comando.ExecuteNonQuery();

            comando.CommandText = "MODIFICAR_ORDEN";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("_fechaVenta", MySqlDbType.Date).Value = o.FechaVenta;
            comando.Parameters.Add("_idPayee", MySqlDbType.VarChar).Value = o.Trabajador.IdTrabajador;
            comando.Parameters.Add("_montoPago", MySqlDbType.Float).Value = o.Monto;
            comando.Parameters.Add("_idProducto", MySqlDbType.VarChar).Value = o.Producto.IdProducto;
            comando.Parameters.Add("_idCombo", MySqlDbType.VarChar).Value = o.Combo.IdCombo;
            comando.Parameters.Add("_idCanal", MySqlDbType.VarChar).Value = o.Canal.IdCanal;
            comando.Parameters.Add("_idOrden", MySqlDbType.VarChar).Value = o.Id;
            comando.Parameters.Add("_tipo", MySqlDbType.VarChar).Value = tipo;

            comando.ExecuteNonQuery();

           // string idOrden = comando.Parameters["_idOrden"].Value.ToString();

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
                o.Producto.Tipo = rs.GetString("tipo");
                o.Monto = rs.GetFloat("montoPago");
                o.Trabajador = new Trabajador();
                o.Trabajador.IdTrabajador = rs.GetString("idPayee");
                o.Id = rs.GetString("idOrden");
                o.FechaVenta = rs.GetDateTime("fechaVenta");
                listaOrden.Add(o);


            }
            con.Close();
            return listaOrden;
        }

        public BindingList<Orden> listarOrdenesComisionista(string idPayee, DateTime fecha1, DateTime fecha2)
        {
            BindingList<Orden> listaOrden = new BindingList<Orden>();

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "LISTAR_ORDENES_COMISIONISTA";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_idPayee", MySqlDbType.VarChar).Value = idPayee;
            comando.Parameters.Add("fecha1", MySqlDbType.Date).Value = fecha1;
            comando.Parameters.Add("fecha2", MySqlDbType.Date).Value = fecha2;

            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                Orden o = new Orden();
                o.Id = rs.GetString("idOrden");
                o.NombreTrabajadorCompleto = rs.GetString("nombrePayee");
                o.Producto = new Producto();
                o.Producto.Nombre = rs.GetString("nombreProducto");
                o.FechaVenta = rs.GetDateTime("fechaVenta");
                o.Canal = new Canal();
                o.Canal.Nombre = rs.GetString("nombreCanal");
                o.Distrito = rs.GetString("distrito");
                o.Monto = rs.GetFloat("monto");
                listaOrden.Add(o);
            }
            con.Close();
            return listaOrden;
        }

        public BindingList<Orden> listarOrdenesJefe(string idPayee, DateTime fecha1, DateTime fecha2)
        {
            BindingList<Orden> listaOrden = new BindingList<Orden>();

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "LISTAR_ORDENES_JEFE";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_idJefe", MySqlDbType.VarChar).Value = idPayee;
            comando.Parameters.Add("fecha1", MySqlDbType.Date).Value = fecha1;
            comando.Parameters.Add("fecha2", MySqlDbType.Date).Value = fecha2;

            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                Orden o = new Orden();
                o.Id = rs.GetString("idOrden");
                o.NombreTrabajadorCompleto = rs.GetString("nombrePayee");
                o.Producto = new Producto();
                o.Producto.Nombre = rs.GetString("nombreProducto");
                o.FechaVenta = rs.GetDateTime("fechaVenta");
                o.Canal = new Canal();
                o.Canal.Nombre = rs.GetString("nombreCanal");
                o.Distrito = rs.GetString("distrito");
                o.Monto = rs.GetFloat("monto");
                listaOrden.Add(o);
            }
            con.Close();
            return listaOrden;
        }

        public BindingList<Orden> listarOrdenesGerente(string idGerente, DateTime fecha1, DateTime fecha2)
        {
            BindingList<Orden> listaOrden = new BindingList<Orden>();

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "LISTAR_ORDENES_GERENTE";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_idGerente", MySqlDbType.VarChar).Value = idGerente;
            comando.Parameters.Add("fecha1", MySqlDbType.Date).Value = fecha1;
            comando.Parameters.Add("fecha2", MySqlDbType.Date).Value = fecha2;

            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                Orden o = new Orden();
                o.Id = rs.GetString("idOrden");
                o.NombreTrabajadorCompleto = rs.GetString("nombrePayee");
                o.Producto = new Producto();
                o.Producto.Nombre = rs.GetString("nombreProducto");
                o.FechaVenta = rs.GetDateTime("fechaVenta");
                o.Canal = new Canal();
                o.Canal.Nombre = rs.GetString("nombreCanal");
                o.Distrito = rs.GetString("distrito");
                o.Monto = rs.GetFloat("monto");
                listaOrden.Add(o);
            }
            con.Close();
            return listaOrden;
        }

       
    }
}
