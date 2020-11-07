using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS_Mejora_tu_Salud.Modelo
{
    class Paciente
    {
        private string identificacionPaciente;
        private string nombres;
        private string apellidos;
        private string fechaNacimiento;
        private string direccion;
        private string telefono;
        private string email;
        private string fechaRegistro;
        private int multas;

        public Paciente(string identificacionPaciente, string nombres, string apellidos, string fechaNacimiento, 
                        string direccion, string telefono, string email, string fechaRegistro, int multas)
        {
            this.IdentificacionPaciente = identificacionPaciente;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.FechaRegistro = fechaRegistro;
            this.Multas = multas;
        }

        public string IdentificacionPaciente { get => IdentificacionPaciente; set => IdentificacionPaciente = value; }
        public string Nombres { get => Nombres; set => Nombres = value; }
        public string Apellidos { get => Apellidos; set => Apellidos = value; }
        public string FechaNacimiento { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string Direccion { get => Direccion; set => Direccion = value; }
        public string Telefono { get => Telefono; set => Telefono = value; }
        public string Email { get => Email; set => Email = value; }
        public string FechaRegistro { get => FechaRegistro; set => FechaRegistro = value; }
        public int Multas { get => Multas; set => Multas = value; }
    }
}
