using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Actividad1
{
    internal class Persona: IComparable
    {
        protected string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                Match match = Regex.Match(value, @"^\s*(?<apellido>[\p{L}\s]{2,}?),\s*(?<nombres>[\p{L}\s]{2,})\s*$");
                if (match.Success == false)
                {
                    throw new FormatoNombreNoValidoExcepcion();
                }
                nombre = value;
            }
        }
             

        public Persona(string nom)
        {
            this.Nombre = nom;
        }

        public virtual string Describir()
        {
            return nombre;
        }

        public  int CompareTo(Object obj)
        {
            Persona p = obj as Persona;
            if (p  != null)
            {
                return this.nombre.CompareTo(p.nombre);
            }
            return 0;
        }



    }
}
