using IPS_Mejora_tu_Salud.Modelo.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private int valorMultas;
        private List<string> citas;


        public Paciente(string identificacionPaciente, string nombres, string apellidos, string fechaNacimiento, 
                        string direccion, string telefono, string email, string fechaRegistro)
        {
            this.IdentificacionPaciente = identificacionPaciente;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.FechaRegistro = fechaRegistro;
            this.Multas = 0;
        }

        public string IdentificacionPaciente { get => identificacionPaciente; set => identificacionPaciente = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public int Multas { get => multas; set => multas = value; }


        public int ValorMultas { get => valorMultas; set => valorMultas = value; }

        //Métodos necesarios para asignar citas
        public Boolean tieneMultas() { return (multas > 0) ? true : false; }
        public Boolean tieneDosCitas() { return (citas.Count == 2) ? true : false; }
        public void multarPaciente()
        {
            Multas += 1;
            ValorMultas += 4000;
        }
        public void asignarCita(string especialidad)
        {
            if(!tieneDosCitas())
            {
                citas.Add(especialidad);
            }
            else
            {
                throw new MaximoCitasException("No se puede asignar más citas al paciente");
            }
        }
        
    }
}
