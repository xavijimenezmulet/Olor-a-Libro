using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_Libro 
{
    public class Visita : IEquatable<Visita>
    {
        public string user { get; set; }
        public string fecha { get; set; } //en android habra que hacer algo asi cada vez que creemos una instancia de visita, pero en java: fecha = DateTime.Now.ToString("yyyyMMdd");
        
        public bool Equals(Visita v)
        {
            bool igual = false;

            if (v.user == this.user && v.fecha == this.fecha)
            {
                igual = true;
            }
            return igual;
        }
    }
}
