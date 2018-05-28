﻿using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class TrabajadorDA
    {
        public string insertarUsuario(Trabajador t, string idSuperior)
        {

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "AGREGAR_USUARIO";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_dni", MySqlDbType.VarChar).Value = t.Dni;
            comando.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = t.Nombre;
            comando.Parameters.Add("_apellidoPaterno", MySqlDbType.VarChar).Value = t.ApellidoPaterno;
            comando.Parameters.Add("_apellidoMaterno", MySqlDbType.VarChar).Value = t.ApellidoMaterno;
            comando.Parameters.Add("_fechaIngreso", MySqlDbType.Date).Value = t.FechaIngreso;
            comando.Parameters.Add("_email", MySqlDbType.VarChar).Value = t.Email;
            comando.Parameters.Add("_idubicacion", MySqlDbType.Int32).Value = t.Locacion.IdLocal;
            comando.Parameters.Add("_usuario", MySqlDbType.VarChar).Value = t.UserName;
            comando.Parameters.Add("_password", MySqlDbType.VarChar).Value = t.Password;
            string tipoUsu="";

            switch (t.GetType().ToString()){
                case "Modelo.Gerente":
                    tipoUsu = "GERENTE";
                    comando.Parameters.Add("_gerente", MySqlDbType.VarChar).Value = "";
                    comando.Parameters.Add("_jefe", MySqlDbType.VarChar).Value = "";
                    break;
                case "Modelo.Jefe":
                    tipoUsu = "JEFE";
                    comando.Parameters.Add("_gerente", MySqlDbType.VarChar).Value = idSuperior;
                    comando.Parameters.Add("_jefe", MySqlDbType.VarChar).Value = "";
                    break;
                case "Modelo.Comisionista":

                    tipoUsu = "COMISIONISTA";
                    comando.Parameters.Add("_gerente", MySqlDbType.VarChar).Value =t.Superior;
                    comando.Parameters.Add("_jefe", MySqlDbType.VarChar).Value = idSuperior;
                    break;
            }
            comando.Parameters.Add("_cargo", MySqlDbType.VarChar).Value = tipoUsu;
            comando.Parameters.Add("_idpayee", MySqlDbType.VarChar).Direction = System.Data.ParameterDirection.Output;
            comando.ExecuteNonQuery();
            string idUsuario = comando.Parameters["_idpayee"].Value.ToString();

            
            con.Close();
            

            return idUsuario;
        }

        public BindingList<String> listarCampos(string nombre, string apellidoPat, string apellidoMat, string email, string dni)
        {
            BindingList<String> listaCampos = new BindingList<String>(); 

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();
            comando.Connection = con;
            comando.CommandText = "BUSQUEDA_CARGAR_COMBOS";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_dni", MySqlDbType.VarChar).Value = dni;
            comando.Parameters.Add("_email", MySqlDbType.VarChar).Value = email;
            comando.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = nombre;
            comando.Parameters.Add("_apellidoMat", MySqlDbType.VarChar).Value = apellidoMat;
            comando.Parameters.Add("_apellidoPat", MySqlDbType.VarChar).Value = apellidoPat;

            MySqlDataReader rs = comando.ExecuteReader();


            while (rs.Read())
            {
               if (dni == "X")
                {
                    listaCampos.Add(rs.GetString("dni"));
                } else if (email == "X")
                {
                    listaCampos.Add(rs.GetString("email"));
                } else if (nombre == "X")
                {
                    listaCampos.Add(rs.GetString("nombre"));
                } else if (apellidoMat == "X")
                {
                    listaCampos.Add(rs.GetString("apellidoMaterno"));
                }
                else if (apellidoPat == "X")
                {
                    listaCampos.Add(rs.GetString("apellidoPaterno"));
                }

            }

            con.Close();

            return listaCampos;
        }    


        public BindingList<Trabajador> listarBusqueda(string dni,
            string nombre, string apellidoPat, string apellidoMat, string correo)
        { 
            BindingList<Trabajador> lista = new BindingList<Trabajador>();

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();
            comando.Connection = con;
            comando.CommandText = "BUSQUEDA_PERSONALIZADA_USUARIO";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("_dni", MySqlDbType.VarChar).Value = dni;
            comando.Parameters.Add("_email", MySqlDbType.VarChar).Value = correo;
            comando.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = nombre;
            comando.Parameters.Add("_apellidoMat", MySqlDbType.VarChar).Value = apellidoMat;
            comando.Parameters.Add("_apellidoPat", MySqlDbType.VarChar).Value = apellidoPat;

            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Trabajador t = null;
                string tipoUsu = rs.GetString("cargo");

                if (tipoUsu == "GERENTE")
                {
                    Gerente g = new Gerente();
                    t = (Trabajador)g;

                }
                else if (tipoUsu == "COMISIONISTA")
                {
                    Comisionista c = new Comisionista();
                    t = (Trabajador)c;
                    t.Superior = rs.GetString("jefe");
                }
                else if (tipoUsu == "JEFE")
                {
                    Jefe j = new Jefe();
                    t = (Trabajador)j;
                    t.Superior = rs.GetString("gerente");
                } 

                t.ApellidoMaterno = rs.GetString("apellidoMaterno");
                t.ApellidoPaterno = rs.GetString("apellidoPaterno");
                t.Dni = rs.GetString("dni");
                t.Email = rs.GetString("email");
                t.Nombre = rs.GetString("nombre");
                t.FechaIngreso = rs.GetDateTime("fechaIngreso");
                t.UserName = rs.GetString("username");
                t.Password = rs.GetString("password");
                t.Locacion = new Sede();
                t.Locacion.IdLocal = rs.GetInt32("idUbicacion");
                t.Locacion.Distrito = rs.GetString("distrito");
                //t.Locacion.Direccion = rs.GetString("direccion");
                t.IdTrabajador = rs.GetString("idPayee");
                


                lista.Add(t);

            }



            return lista;


        }

        public void modificarRegistro(Trabajador t,string idSuperior)
        {


            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "MODIFICAR_USUARIO";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_idPayee", MySqlDbType.VarChar).Value = t.IdTrabajador;
            comando.Parameters.Add("_dni", MySqlDbType.VarChar).Value = t.Dni;
            comando.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = t.Nombre;
            comando.Parameters.Add("_apellidoPaterno", MySqlDbType.VarChar).Value = t.ApellidoPaterno;
            comando.Parameters.Add("_apellidoMaterno", MySqlDbType.VarChar).Value = t.ApellidoMaterno;
            comando.Parameters.Add("_fechaIngreso", MySqlDbType.Date).Value = t.FechaIngreso;
            comando.Parameters.Add("_email", MySqlDbType.VarChar).Value = t.Email;
            comando.Parameters.Add("_idubicacion", MySqlDbType.Int32).Value = t.Locacion.IdLocal;
            comando.Parameters.Add("_usuario", MySqlDbType.VarChar).Value = t.UserName;
            comando.Parameters.Add("_password", MySqlDbType.VarChar).Value = t.Password;
            string tipoUsu = "";

            switch (t.GetType().ToString())
            {
                case "Modelo.Gerente":
                    tipoUsu = "GERENTE";
                    comando.Parameters.Add("_gerente", MySqlDbType.VarChar).Value = "";
                    comando.Parameters.Add("_jefe", MySqlDbType.VarChar).Value = "";
                    break;
                case "Modelo.Jefe":
                    tipoUsu = "JEFE";
                    comando.Parameters.Add("_gerente", MySqlDbType.VarChar).Value = idSuperior;
                    comando.Parameters.Add("_jefe", MySqlDbType.VarChar).Value = "";
                    break;
                case "Modelo.Comisionista":

                    tipoUsu = "COMISIONISTA";
                    comando.Parameters.Add("_gerente", MySqlDbType.VarChar).Value = t.Superior ;
                    comando.Parameters.Add("_jefe", MySqlDbType.VarChar).Value = idSuperior;
                    break;
            }
            comando.Parameters.Add("_cargo", MySqlDbType.VarChar).Value = tipoUsu;
            
            comando.ExecuteNonQuery();
            


            con.Close();


           
        }

        public BindingList<Trabajador> listar(string tipoUsu, string idPayee)
        {
            BindingList<Trabajador> lista= new BindingList<Trabajador>();
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                    "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            if (idPayee.Equals("ALL"))
            {
                comando.Connection = con;
                if (tipoUsu == "GERENTE")
                {
                    comando.CommandText = "LISTAR_GERENTES";
                }
                else if (tipoUsu == "JEFE")
                {
                    comando.CommandText = "LISTAR_JEFES";
                    comando.Parameters.Add("idPayee", MySqlDbType.VarChar).Value = "ALL";
                }
                else if (tipoUsu == "COMISIONISTA")
                {
                    comando.CommandText = "LISTAR_COMISIONISTAS";
                    comando.Parameters.Add("idPayee", MySqlDbType.VarChar).Value = "ALL";
                }
            }
            else
            {
                comando.Connection = con;
                if (tipoUsu == "GERENTE")
                {
                    comando.CommandText = "LISTAR_GERENTES";
                }
                else if (tipoUsu == "JEFE")
                {
                    comando.CommandText = "LISTAR_JEFES";
                    comando.Parameters.Add("idPayee", MySqlDbType.VarChar).Value = idPayee;
                }
                else if (tipoUsu == "COMISIONISTA")
                {
                    comando.CommandText = "LISTAR_COMISIONISTAS";
                    comando.Parameters.Add("idPayee", MySqlDbType.VarChar).Value = idPayee;
                }
            }
            
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Trabajador t = null;
                string tipoU = rs.GetString("cargo");

                if (tipoU == "GERENTE")
                {
                    Gerente g = new Gerente();
                    t = (Trabajador)g;

                }
                else if (tipoU == "COMISIONISTA")
                {
                    Comisionista c = new Comisionista();
                    t = (Trabajador)c;
                   
                }
                else if (tipoU == "JEFE")
                {
                    Jefe j = new Jefe();
                    t = (Trabajador)j;
                    t.Superior = rs.GetString("gerente");
                }

                t.ApellidoMaterno = rs.GetString("apellidoMaterno");
                t.ApellidoPaterno = rs.GetString("apellidoPaterno");
                t.Dni = rs.GetString("dni");
                t.Email = rs.GetString("email");
                t.Nombre = rs.GetString("nombre");
                t.IdTrabajador = rs.GetString("idPayee");
                t.Cargo = rs.GetString("cargo");
                t.UserName = rs.GetString("username");
                t.Distrito = rs.GetString("distrito");

                lista.Add(t);
            }
            con.Close();

            return lista;
            
        }

        public void eliminarUsuario(Trabajador t)
        {
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                  "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "ELIMINAR_USUARIO";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_idPayee", MySqlDbType.VarChar).Value = t.IdTrabajador;

            comando.ExecuteNonQuery();

            con.Close();
        }

        public string login(string usuario, string contraseña, ref int existeUsu, ref int errorContra,
            ref string id_usuario, ref string nombreUsu, ref string apellidoPat)
        {
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                 "port=3306;password=4LDJZU;SslMode=none;" + " ";

            existeUsu = 0;
            errorContra = 1;

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "LISTAR_TRABAJADORES";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader rs = comando.ExecuteReader();


            while (rs.Read())
            {
                string user=  rs.GetString("username");
                string pass = rs.GetString("password");
                string tipo = rs.GetString("cargo");

                if (user == usuario)
                {
                    existeUsu = 1;
                    if (pass == contraseña)
                    {
                        errorContra = 0;
                        id_usuario = rs.GetString("idPayee");
                        nombreUsu = rs.GetString("nombre");
                        apellidoPat = rs.GetString("apellidoPaterno");

                        switch (tipo)
                        {
                            case "ADMINISTRADOR":
                                con.Close();
                                return "Administrador";
                            case "GERENTE":
                                con.Close();
                                return "Gerente";
                            case "JEFE":
                                con.Close();
                                return "Jefe";

                            case "COMISIONISTA":
                                con.Close();
                                return "Comisionista";
                        }

                        con.Close();
                        return "";
                        
                    }
                }

            }

            con.Close();


            return "";
        }

        public void obtenerDatos(string usuario, ref string id_usuario, ref string nombreUsu, ref string apellidoPat)
        {

            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
                "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "BUSCAR_DATOS";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_usuario", MySqlDbType.VarChar).Value = usuario;

            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                id_usuario = rs.GetString("idPayee");
                nombreUsu = rs.GetString("nombre");
                apellidoPat = rs.GetString("apellidoPaterno");
            }
           

            con.Close();
        }

        public Trabajador obtenerLogin(string usuario)
        {
            string cadena = "server= 200.16.7.96;" + "user= inf282g8;database= inf282g8;" +
               "port=3306;password=4LDJZU;SslMode=none;" + " ";

            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();

            comando.Connection = con;
            comando.CommandText = "OBTENER_LOGIN";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("DATO", MySqlDbType.VarChar).Value = usuario;

            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Trabajador t = new Trabajador();

                t.IdTrabajador = rs.GetString("idPayee");
                t.Nombre = rs.GetString("nombre");
                t.ApellidoPaterno= rs.GetString("apellidoPaterno");
                t.UserName = rs.GetString("username");
                t.Email = rs.GetString("email");
                t.Password = rs.GetString("password");

                return t;
            }

            return null;
        }
    }

}
 