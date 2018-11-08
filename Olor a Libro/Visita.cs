using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_Libro 
{
    public class Visita : IEquatable<Visita>
    {
        public Usuario user { get; set; }
        public Actividad activitatvisitada { get; set; }
        public string fecha { get; set; }

        public bool Equals(Visita v)
        {
            bool igual = false;

            if (v.user == this.user && v.activitatvisitada == this.activitatvisitada && v.fecha == this.fecha)
            {
                igual = true;
            }
            return igual;
        }
    }
}
