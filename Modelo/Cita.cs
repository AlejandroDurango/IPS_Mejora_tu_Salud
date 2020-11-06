using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS_Mejora_tu_Salud.Modelo
{
    class Cita
    {
        private String IdentificacionMedico;
        private String IdentificacionPaciente;
        private DateTime FechaCita;

        public Cita(string identificacionMedico, string identificacionPaciente, DateTime fechaCita)
        {
            IdentificacionMedico = identificacionMedico;
            IdentificacionPaciente = identificacionPaciente;
            FechaCita = fechaCita;
        }

        public string IdentificacionMedico1 { get => IdentificacionMedico; set => IdentificacionMedico = value; }
        public string IdentificacionPaciente1 { get => IdentificacionPaciente; set => IdentificacionPaciente = value; }
        public DateTime FechaCita1 { get => FechaCita; set => FechaCita = value; }
    }
}
