using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Actividad1
{
    internal class PersonaJuridica: Persona
    {
        private string cuit;

        public string Cuit
        {
            get { return cuit; } 
            set
            {
                Match match = Regex.Match(value, @"\d{11}");
                if ( match.Success == false)
                {
                    throw new FormatoCuitNoValidoExcepcion();
                }
                cuit= value;
            }
        }
        public PersonaJuridica(string nombre, string cuit): 
            base(nombre)
        {
            this.cuit = cuit;
        }

        public override string Describir()
        {
            return base.Describir() + cuit;
        }
    }
}
