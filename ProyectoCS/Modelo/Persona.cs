using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public abstract class Persona
    {
     //atributos
        private string dni;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private int edad;

     //métodos
        //constructores
        public Persona()
        {

        }

        //setters y getters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public int Edad { get => edad; set => edad = value; }


        //métodos adicionales
    }
}
