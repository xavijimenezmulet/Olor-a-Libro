using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_Libro
{
    class Actividad : IEquatable<Actividad>
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string lugar { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public List<Libreria> librerias { get; set; }
        public List<Opinion> opiniones { get; set; }

        public bool Equals(Actividad a)
        {
            bool igual = false;

            if (a.nombre == this.nombre && a.lugar == this.lugar && a.fecha == this.fecha && a.hora == this.hora)
            {
                igual = true;
            }
            return igual;
        }
    }
}
