using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_Libro
{
    public class Usuario : IEquatable<Usuario>
    {
        public string username { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string ciudad { get; set; }
        public string password { get; set; }
        public int puntos { get; set; }
        public string rank { get; set; }
        public float descuento { get; set; }

        public Usuario()
        {
            this.password  = "user";
            this.puntos    = 0;
            this.rank      = "unranked";
            this.descuento = 0.0f;
        }

        public bool Equals(Usuario u)
        {
            bool igual = false;

            if (u.username == this.username)
            {
                igual = true;
            }
            return igual;
        }
    }
}
