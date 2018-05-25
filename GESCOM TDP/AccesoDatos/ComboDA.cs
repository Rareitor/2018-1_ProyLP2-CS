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


    }
}
