using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* PRIMER PROYECTO DAM2A - OLOR A LIBRO - 
* WINDOWS FORMS 
* @authors:
* @JoelGalimany @AinhoaGarcía @GermanGómez @XavierJimenez
* Creación:            10/10/2018
* Ultima modificacióN: 17/12/2018 (Introducción comentarios)
**/
namespace Olor_a_Libro
{
    public partial class FormPrincipal : Form
    {
        //CONSTRUCTOR 
        public FormPrincipal()
        {
            InitializeComponent();
        }

        /**
         * NOS CARGA LA PRIMERA VEZ QUE SE ABRE TODOS LOS JSON Y ASÍ PODEMOS TRABAJAR CON ELLOS EN 
         * UTILITATS 
         **/
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            //carregar/crear arxius json
            //Utilitats.carregarJsons();
            
            string arxiulib = "librerias.json";
            string arxiubook = "libros.json";
            string arxiuuser = "usuarios.json";
            string arxiuop = "opiniones.json";
            string arxiuact = "actividades.json";
            string arxiuviews = "visitas.json";
            string arxiuPuntuacio = "puntuacion.json";
            string arxiurangos = "rangos.json";

            if (File.Exists(arxiulib))
            {
                JArray jArrayLibs = JArray.Parse(File.ReadAllText(arxiulib));
                Utilitats.librerias = jArrayLibs.ToObject<BindingList<Libreria>>();
            }
            else
            {
                Utilitats.librerias = new BindingList<Libreria>();
            }
            //if (File.Exists(arxiubook))
            //{
            //    JArray jArrayBooks = JArray.Parse(File.ReadAllText(arxiubook));
            //    Utilitats.libros = jArrayBooks.ToObject<BindingList<Libro>>();
            //}
            //else
            //{
            //    Utilitats.libros = new BindingList<Libro>();
            //}
            if (File.Exists(arxiuuser))
            {
                JArray jArrayusers = JArray.Parse(File.ReadAllText(arxiuuser));
                Utilitats.usuarios = jArrayusers.ToObject<BindingList<Usuario>>();
            }
            else
            {
                Utilitats.usuarios = new BindingList<Usuario>();
            }
            if (File.Exists(arxiuop))
            {
                JArray jArrayops = JArray.Parse(File.ReadAllText(arxiuop));
                Utilitats.opiniones = jArrayops.ToObject<BindingList<Opinion>>();
            }
            else
            {
                Utilitats.opiniones = new BindingList<Opinion>();
            }
            if (File.Exists(arxiuact))
            {
                JArray jArrayacts = JArray.Parse(File.ReadAllText(arxiuact));
                Utilitats.actividades = jArrayacts.ToObject<BindingList<Actividad>>();
            }
            else
            {
                Utilitats.actividades = new BindingList<Actividad>();
            }
            if (File.Exists(arxiuviews))
            {
                JArray jArrayviews = JArray.Parse(File.ReadAllText(arxiuviews));
                Utilitats.visitas = jArrayviews.ToObject<BindingList<Visita>>();
            }
            else
            {
                Utilitats.visitas = new BindingList<Visita>();
            }
            if (File.Exists(arxiuPuntuacio))
            {
                JObject jArrayPuntuacio = JObject.Parse(File.ReadAllText(arxiuPuntuacio));
                //JArray jArrayPuntuacio = JArray.Parse(File.ReadAllText(arxiuPuntuacio));
                //Utilitats.puntuacion = jArrayPuntuacio.ToObject<Puntuacion>();
                Utilitats.puntuacion = jArrayPuntuacio.ToObject<Puntuacion>();
            }
            else
            {
                Utilitats.puntuacion = new Puntuacion();
            }
            if (File.Exists(arxiurangos))
            {
                JObject jArrayRangos = JObject.Parse(File.ReadAllText(arxiurangos));
                Utilitats.rango = jArrayRangos.ToObject<Rango>();
            }
            else
            {
                Utilitats.rango = new Rango();
            }
        }
        
        /**
         * ENLACES DE MENUS DONDE APLICAMOS LOS COLORES EN CASA UNA DE LAS OPCIONES
         **/
        public void archivoToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            archivoToolStripMenuItem.ForeColor = Color.Black;
        }

        public void archivoToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            archivoToolStripMenuItem.ForeColor = Color.White;
        }

        private void libreriasToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            libreriasToolStripMenuItem.ForeColor = Color.Black;
        }

        private void libreriasToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            libreriasToolStripMenuItem.ForeColor = Color.White;
        }

        private void actividadesToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            actividadesToolStripMenuItem.ForeColor = Color.White;
        }

        private void actividadesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            actividadesToolStripMenuItem.ForeColor = Color.Black;
        }

        private void usuariosToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            usuariosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void usuariosToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            usuariosToolStripMenuItem.ForeColor = Color.White;
        }

        /**
         *  ACCESO A LOS FORMULARIOS
         **/
               
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void verLibreriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.VerLibrerias();
            this.Show();
        }
        private void añadirLibreríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.AnyadirLibreria();
            this.Show();
        }
        private void verActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.VerActividades();
            this.Show();
        }
        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.verUsuarios();
            this.Show();
        }
        private void añadirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.AnyadirUsuarios();
            this.Show();
        }
        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.Estadisticas();
            this.Show();
        }

        private void puntuaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.PuntosAdmin();
            this.Show();
        }

        private void anyadirActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.AnyadirAct();
            this.Show();
        }
        
        /**
         * NOS GUARDA TODOS LOS DATOS QUE TENGAMOS MODIFICADOS EN EL MOMENTO A LOS JSON
         **/
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitats.guardarTodo();
        }

        /**
         * AL CERRAR NOS PREGUNTARÁ SI QUEREMOS SALIR GUARDANDO O NO O CANCELAR REUTILIZANDO EL METODO
         * EN UTILITATS
         **/
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utilitats.closeit(sender, e);
        } 
    }
}
