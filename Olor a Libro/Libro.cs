using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_Libro 
{
    public class Libro : IEquatable<Libro>
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anyo { get; set; }
        public int precio { get; set; }
        public List<string> genero { get; set; }

        public bool Equals(Libro l)
        {
            bool igual = false;

            if (l.titulo == this.titulo && l.autor == this.autor && l.anyo == this.anyo)
            {
                igual = true;
            }
            return igual;
        }
    }
}
