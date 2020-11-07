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
        private string añosExperiencia;

        public Medico(string identificacionMedico, string nombres, string apellidos, string especialidad, 
                      int salarioPorCita, string añosExperiencia)
        {
            this.IdentificacionMedico = identificacionMedico;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Especialidad = especialidad;
            this.SalarioPorCita = salarioPorCita;
            this.AñosExperiencia = añosExperiencia;
        }

        public string IdentificacionMedico { get => IdentificacionMedico; set => IdentificacionMedico = value; }
        public string Nombres { get => Nombres; set => Nombres = value; }
        public string Apellidos { get => Apellidos; set => Apellidos = value; }
        public string Especialidad { get => Especialidad; set => Especialidad = value; }
        public int SalarioPorCita { get => SalarioPorCita; set => SalarioPorCita = value; }
        public string AñosExperiencia { get => AñosExperiencia; set => AñosExperiencia = value; }
    }
}
