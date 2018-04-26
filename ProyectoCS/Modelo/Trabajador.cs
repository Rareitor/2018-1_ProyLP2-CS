using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public abstract class Trabajador : Persona
    {
     //atributos	
        private string idTrabajador;
        private TipoRegimen regimen;
        private DateTime fechaIngreso;
        private string email;
        private string telefono;
        private string userName;
        private string password;

     //métodos
        //constructores
        public Trabajador()
        {
        }

        //setters y getters
        public string IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        internal TipoRegimen Regimen { get => regimen; set => regimen = value; }

        //métodos adicionales
        public abstract void emitirReporte();
    }
}
