using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS_Mejora_tu_Salud.Modelo
{
    class Medico
    {
        private string identificacionMedico;
        private string nombres;
        private string apellidos;
        private string especialidad;
        private int salarioPorCita;
        private int añosExperiencia;
        private int  citasmedicos;

        public Medico(string identificacionMedico, string nombres, string apellidos, string especialidad, 
                      int salarioPorCita, int añosExperiencia)
        {
            this.IdentificacionMedico = identificacionMedico;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Especialidad = especialidad;
            this.SalarioPorCita = salarioPorCita;
            this.AñosExperiencia = añosExperiencia;
        }

        public string IdentificacionMedico { get => identificacionMedico; set => identificacionMedico = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public int SalarioPorCita { get => salarioPorCita; set => salarioPorCita = value; }
        public int AñosExperiencia { get => añosExperiencia; set => añosExperiencia = value; }
    }
}
