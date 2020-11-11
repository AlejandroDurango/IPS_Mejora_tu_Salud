using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS_Mejora_tu_Salud.Modelo.Excepciones
{
    class MedicoException : Exception
    {
        private string mensaje;
        public MedicoException(string mensaje)
        {
            this.mensaje = mensaje;
        }
    }

    class NoExisteMedicoException : MedicoException{ public NoExisteMedicoException(string mensaje):base(mensaje) { } }
}
