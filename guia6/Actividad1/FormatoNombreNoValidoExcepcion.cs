using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    internal class FormatoNombreNoValidoExcepcion:ApplicationException
    {
        public FormatoNombreNoValidoExcepcion(): base("El nombre cargado es inavilo") { }

        public FormatoNombreNoValidoExcepcion(string message): base(message) { }

        public FormatoNombreNoValidoExcepcion(string message, Exception inner) : base(message, inner) { }
    }
}
