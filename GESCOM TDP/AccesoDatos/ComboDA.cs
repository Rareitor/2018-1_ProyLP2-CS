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
    public class ComboDA
    {
        public BindingList<Combo> ListarCombos()
        {
            BindingList<Combo> listaCombos= new BindingList<Combo>();

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "LISTAR_COMBO";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Combo c = new Combo();

                c.IdCombo= rs.GetString("idcombo");
                c.Nombre = rs.GetString("nombre");
                c.Tipo = rs.GetString("tipo");

                listaCombos.Add(c);
            }
            con.Close();

            return listaCombos;

        }
           
        public string agregarComboProducto(ComboProducto cp)
        {
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                  "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "AGREGAR_COMBOPRODUCTO";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("_idProducto", MySqlDbType.VarChar).Value = cp.Producto.IdProducto;
            comando.Parameters.Add("_idCombo", MySqlDbType.VarChar).Value = cp.Combo1.IdCombo;
            comando.Parameters.Add("_idCanal", MySqlDbType.VarChar).Value = cp.Canal1.IdCanal;
            comando.Parameters.Add("_fechaInicio", MySqlDbType.Date).Value = cp.FechaInicio1;
            comando.Parameters.Add("_fechaFin", MySqlDbType.Date).Value = cp.FechaFin1;
            comando.Parameters.Add("_fePeriodo", MySqlDbType.VarChar).Value = cp.FePeriodo;
            comando.Parameters.Add("_tipo", MySqlDbType.VarChar).Value = cp.Tipo;
            if (cp.Tipo == "COMISION")
            {
                comando.Parameters.Add("_idFormula", MySqlDbType.Int32).Value =1;
            } else if (cp.Tipo == "BONO")
            {
                comando.Parameters.Add("_idFormula", MySqlDbType.Int32).Value = 2;
            } else if (cp.Tipo == "PENALIDAD")
            {
                comando.Parameters.Add("_idFormula", MySqlDbType.Int32).Value = 3;
            }
            


            comando.ExecuteNonQuery();
            con.Close();
            return "Correcto";



       }

        public List<ComboProducto> listarComboProductos(string fePeriodo)
        {
            List<ComboProducto> lista = new List<ComboProducto>();

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                  "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "LISTAR_COMBOPRODUCTOS";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("_fePeriodo", MySqlDbType.VarChar).Value = fePeriodo;

            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {

                ComboProducto cp = new ComboProducto();
                cp.Canal1 = new Canal();
                cp.Producto = new Producto();
                cp.Combo1 = new Combo();

                cp.Canal1.IdCanal = rs.GetString("IdCanal");
                cp.Combo1.IdCombo = rs.GetString("IdCombo");
                cp.Producto.IdProducto = rs.GetString("IdProducto");
                cp.Canal1.Nombre = rs.GetString("nombreCanal");
                cp.Combo1.Nombre = rs.GetString("nombreCombo");
                cp.Producto.Nombre = rs.GetString("nombreProducto");
                cp.Producto.Tipo = rs.GetString("tipo");

                lista.Add(cp);

            }


            con.Close();
            return lista;
        }

        public void cargarCombo(Combo c)
        {

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "INSERT INTO Combo values ('" + c.IdCombo + "','"
                + c.Nombre + "','" + c.Tipo + "', 1);";
            comando.ExecuteNonQuery();

            con.Close();
        }


    }
}
