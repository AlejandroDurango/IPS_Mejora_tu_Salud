using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS_Mejora_tu_Salud.Modelo.Excepciones
{
    class ProgramaException : Exception
    {
        private string mensaje;
        public ProgramaException(string mensaje)
        {
            this.mensaje = mensaje;
        }
    }

    class CamposVaciosException : ProgramaException { public CamposVaciosException(string mensaje) : base(mensaje) {} }
    class RegistroNoExitosoException : ProgramaException { public RegistroNoExitosoException(string mensaje) : base(mensaje) {} }
}
