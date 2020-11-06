using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS_Mejora_tu_Salud.Modelo
{
    class Medico
    {
        private String IdentificacionMedico;
        private String Nombres;
        private String Apellidos;
        private String Especialidad;
        private int SalarioPorCita;
        private String AñosExperiencia;

        public Medico(string identificacionMedico, string nombres, string apellidos, string especialidad, 
                      int salarioPorCita, string añosExperiencia)
        {
            IdentificacionMedico = identificacionMedico;
            Nombres = nombres;
            Apellidos = apellidos;
            Especialidad = especialidad;
            SalarioPorCita = salarioPorCita;
            AñosExperiencia = añosExperiencia;
        }

        public string IdentificacionMedico1 { get => IdentificacionMedico; set => IdentificacionMedico = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string Especialidad1 { get => Especialidad; set => Especialidad = value; }
        public int SalarioPorCita1 { get => SalarioPorCita; set => SalarioPorCita = value; }
        public string AñosExperiencia1 { get => AñosExperiencia; set => AñosExperiencia = value; }
    }
}
