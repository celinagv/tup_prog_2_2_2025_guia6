using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    internal class FormatoCuitNoValidoExcepcion:ApplicationException
    {
        public FormatoCuitNoValidoExcepcion() : base("El cuit cargado es invalido") { }

        public FormatoCuitNoValidoExcepcion(string message) : base(message) { }

        public FormatoCuitNoValidoExcepcion(string message, Exception inner) : base(message, inner) { }
    }
}
