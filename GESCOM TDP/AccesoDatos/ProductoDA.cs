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
    public class ProductoDA
    {
        public BindingList<Producto> listarProductos()
        {

            BindingList<Producto> listaProducto = new BindingList<Producto>();

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "LISTAR_PRODUCTO";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Producto p = new Producto();

                p.IdProducto = rs.GetString("idproducto");
                
                p.Nombre = rs.GetString("nombre");
                p.Tipo = rs.GetString("tipo");

                listaProducto.Add(p);
            }
            con.Close();

            return listaProducto;

        }

    }
}
