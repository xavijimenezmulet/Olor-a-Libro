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

namespace Olor_a_Libro
{
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void verLibreriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitats.guardarJsonlibs();
            Utilitats.guardarJsonbooks();
            Utilitats.guardarJsonusers();
            Utilitats.guardarJsonop();
            Utilitats.guardarJsonact();
            Utilitats.guardarJsonviews();
        }
       

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            
            //carregar/crear arxius json

            string arxiulib = "librerias.json";
            string arxiubook = "libros.json";
            string arxiuuser = "usuarios.json";
            string arxiuop = "opiniones.json";
            string arxiuact = "actividades.json";
            string arxiuviews = "visitas.json";

            if (File.Exists(arxiulib))
            {
                JArray jArrayLibs = JArray.Parse(File.ReadAllText(arxiulib));
                Utilitats.librerias = jArrayLibs.ToObject<List<Libreria>>();
            }
            else
            {
                Utilitats.librerias = new List<Libreria>();
            }
            if (File.Exists(arxiubook))
            {
                JArray jArrayBooks = JArray.Parse(File.ReadAllText(arxiubook));
                Utilitats.libros = jArrayBooks.ToObject<List<Libro>>();
            }
            else
            {
                Utilitats.libros = new List<Libro>();
            }
            if (File.Exists(arxiuuser))
            {
                JArray jArrayusers = JArray.Parse(File.ReadAllText(arxiuuser));
                Utilitats.librerias = jArrayusers.ToObject<List<Libreria>>();
            }
            else
            {
                Utilitats.usuarios = new List<Usuario>();
            }
            if (File.Exists(arxiuop))
            {
                JArray jArrayops = JArray.Parse(File.ReadAllText(arxiuop));
                Utilitats.opiniones = jArrayops.ToObject<List<Opinion>>();
            }
            else
            {
                Utilitats.opiniones = new List<Opinion>();
            }
            if (File.Exists(arxiuact))
            {
                JArray jArrayacts = JArray.Parse(File.ReadAllText(arxiuact));
                Utilitats.actividades = jArrayacts.ToObject<List<Actividad>>();
            }
            else
            {
                Utilitats.actividades = new List<Actividad>();
            }
            if (File.Exists(arxiuviews))
            {
                JArray jArrayviews = JArray.Parse(File.ReadAllText(arxiuviews));
                Utilitats.visitas = jArrayviews.ToObject<List<Visita>>();
            }
            else
            {
                Utilitats.visitas = new List<Visita>();
            }
        }

        private void libreriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

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

        private void toolStripButtonLibrerias_Click(object sender, EventArgs e)
        {
            FormListaLibrerias f = new FormListaLibrerias();
            f.Show();
        }
    }
}
