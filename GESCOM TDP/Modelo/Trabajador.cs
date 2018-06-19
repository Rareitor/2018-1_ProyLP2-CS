using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Trabajador : Persona
    {
     //atributos	
        private string idTrabajador;
        private TipoRegimen regimen;
        private DateTime fechaIngreso;
        private string email;
        private string telefono;
        private string userName;
        private string password;
        private Sede locacion;
        private string superior;
        private String cargo;
        private String distrito;
        private bool isVisible;
        private double monto;
        private bool isBlocked;

        //métodos
        //constructores
        public Trabajador()
        {
        }

        //setters y getters
  
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
        public string Superior { get => superior; set => superior = value; }
        public string IdSuperior { get => superior; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public Sede Locacion { get => locacion; set => locacion = value; }
        public bool IsVisible { get => isVisible; set => isVisible = value; }
        public double Monto { get => monto; set => monto = value; }
        public bool IsBlocked { get => isBlocked; set => isBlocked = value; }
        public string Razon { get => (isBlocked ? "BLOQUEADO" : "BORRADO");}
        internal TipoRegimen Regimen { get => regimen; set => regimen = value; }

       

        public string NombreTrabajadorCompleto()
        {
           return this.ApellidoPaterno + " " + this.ApellidoMaterno + ", " + this.Nombre;
        }

        //métodos adicionales
        //public void emitirReporte();

        public override string ToString()
        {

            return idTrabajador;
        }
    }
}
