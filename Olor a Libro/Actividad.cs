﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_Libro
{
    public class Actividad : IEquatable<Actividad>
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string lugar { get; set; }
        public string tipo { get; set; }
        public String fecha { get; set; } //DataTime
        public string hora { get; set; } //DataTime
        public BindingList<String> librerias { get; set; } //nombre libreria-direccion
        public BindingList<Opinion> opiniones { get; set; }
        public BindingList<Visita> visitas { get; set; }

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
