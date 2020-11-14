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
        private int numeroCitas;


        public Paciente(string identificacionPaciente, string nombres, string apellidos, string fechaNacimiento, 
                        string direccion, string telefono, string email, string fechaRegistro)
        {
            IdentificacionPaciente = identificacionPaciente;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaRegistro = fechaRegistro;
            Multas = 0;
            NumeroCitas = 0;

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
        public int NumeroCitas { get => numeroCitas; set => numeroCitas = value; }

        //Métodos necesarios para asignar citas
        public Boolean tieneMultas() { return (multas > 0) ? true : false; }
        public Boolean tieneDosCitas()
        {
            if(NumeroCitas == 2)
            {
                throw new MaximoCitasException("El paciente tiene el máximo de citas");
            }
            else
            {
                return false;
            }
        }
        
        public int especialidadYaElegida(string especialidad)
        {
            if(especialidad == "Medico general")
            {
                return 1;
            }
            else if(especialidad == "Optometria")
            {
                return 2;
            }
            else if(especialidad == "Pediatria")
            {
                return 3;
            }
            else
            {
                // no tiene citas
                return 0;
            }
        }

        /*
         * private 
         */ 

    }
}
