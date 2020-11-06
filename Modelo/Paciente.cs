using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS_Mejora_tu_Salud.Modelo
{
    class Paciente
    {
        private String IdentificacionPaciente;
        private String Nombres;
        private String Apellidos;
        private DateTime FechaNacimiento;
        private String Direccion;
        private String Telefono;
        private String Email;
        private DateTime FechaRegistro;
        private int Multas;

        public Paciente(string identificacionPaciente, string nombres, string apellidos, DateTime fechaNacimiento, 
                        string direccion, string telefono, string email, DateTime fechaRegistro, int multas)
        {
            IdentificacionPaciente = identificacionPaciente;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaRegistro = fechaRegistro;
            Multas = multas;
        }

        public string IdentificacionPaciente1 { get => IdentificacionPaciente; set => IdentificacionPaciente = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string FechaRegistro1 { get => FechaRegistro; set => FechaRegistro = value; }
        public int Multas1 { get => Multas; set => Multas = value; }
    }
}
