using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_Libro
{
    class Libreria : IEquatable<Libreria>
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int contacto { get; set; }
        public List<Libro> libros { get; set; }
        public List<Actividad> actividades { get; set; }

        public bool Equals(Libreria l)
        {
            bool igual = false;

            if (l.nombre == this.nombre && l.direccion == this.direccion)
            {
                igual = true;
            }
            return igual;
        }
    }
}
