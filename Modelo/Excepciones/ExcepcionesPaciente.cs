using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS_Mejora_tu_Salud.Modelo.Excepciones
{
    class PacienteException : Exception
    {
        private string mensaje;
        public PacienteException(string mensaje)
        {
            this.mensaje = mensaje;
        }
    }

    class MaximoCitasException : PacienteException {public MaximoCitasException(string mensaje) : base(mensaje){}}
    class NoExistePacienteException: PacienteException {public NoExistePacienteException(string mensaje) : base(mensaje){}}
    class PacienteTieneMultas : PacienteException { public PacienteTieneMultas(string mensaje) : base(mensaje){}}


}
