﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_Libro
{
    public class Libreria : IEquatable<Libreria>
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string imagen { get; set; }
        public BindingList<Libro> libros { get; set; } = new BindingList<Libro>();
        //    public BindingList<Actividad> actividades { get; set; } = new BindingList<Actividad>();
        //    public List<Libro> libros { get; set; }
        public BindingList<String> actividades { get; set; } = new BindingList<string>(); //nombre-lugar-hora

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
