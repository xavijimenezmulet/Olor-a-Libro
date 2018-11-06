﻿using Newtonsoft.Json;
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
        List<Libreria> librerias = new List<Libreria>();
        List<Libro> libros = new List<Libro>();
        List<Opinion> opiniones = new List<Opinion>();
        List<Actividad> actividades = new List<Actividad>();
        List<Usuario> usuarios = new List<Usuario>();
        List<Visita> visitas = new List<Visita>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void verLibreriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarJsonlibs();
            guardarJsonbooks();
            guardarJsonusers();
            guardarJsonop();
            guardarJsonact();
            guardarJsonviews();
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
                librerias = jArrayLibs.ToObject<List<Libreria>>();
            }
            else
            {
                librerias = new List<Libreria>();
            }
            if (File.Exists(arxiubook))
            {
                JArray jArrayBooks = JArray.Parse(File.ReadAllText(arxiubook));
                libros = jArrayBooks.ToObject<List<Libro>>();
            }
            else
            {
                libros = new List<Libro>();
            }
            if (File.Exists(arxiuuser))
            {
                JArray jArrayusers = JArray.Parse(File.ReadAllText(arxiuuser));
                librerias = jArrayusers.ToObject<List<Libreria>>();
            }
            else
            {
                usuarios = new List<Usuario>();
            }
            if (File.Exists(arxiuop))
            {
                JArray jArrayops = JArray.Parse(File.ReadAllText(arxiuop));
                opiniones = jArrayops.ToObject<List<Opinion>>();
            }
            else
            {
                opiniones = new List<Opinion>();
            }
            if (File.Exists(arxiuact))
            {
                JArray jArrayacts = JArray.Parse(File.ReadAllText(arxiuact));
                actividades = jArrayacts.ToObject<List<Actividad>>();
            }
            else
            {
                actividades = new List<Actividad>();
            }
            if (File.Exists(arxiuviews))
            {
                JArray jArrayviews = JArray.Parse(File.ReadAllText(arxiuviews));
                visitas = jArrayviews.ToObject<List<Visita>>();
            }
            else
            {
                visitas = new List<Visita>();
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
        private void guardarJsonlibs()
        {
            string arxiulib = "librerias.json";
            JArray jArrayLibs = (JArray)JToken.FromObject(librerias);
            StreamWriter file = File.CreateText(arxiulib);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayLibs.WriteTo(writer);
            writer.Close();
        }
        private void guardarJsonbooks()
        {
            string arxiubook = "libros.json";
            JArray jArrayBooks = (JArray)JToken.FromObject(libros);
            StreamWriter file = File.CreateText(arxiubook);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayBooks.WriteTo(writer);
            writer.Close();
        }
        private void guardarJsonusers()
        {
            string arxiuuser = "usuarios.json";
            JArray jArrayUsers = (JArray)JToken.FromObject(usuarios);
            StreamWriter file = File.CreateText(arxiuuser);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayUsers.WriteTo(writer);
            writer.Close();
        }
        private void guardarJsonop()
        {
            string arxiuop = "opiniones.json";
            JArray jArrayOps = (JArray)JToken.FromObject(opiniones);
            StreamWriter file = File.CreateText(arxiuop);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayOps.WriteTo(writer);
            writer.Close();
        }
        private void guardarJsonact()
        {
            string arxiuact = "actividades.json";
            JArray jArrayAct = (JArray)JToken.FromObject(actividades);
            StreamWriter file = File.CreateText(arxiuact);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayAct.WriteTo(writer);
            writer.Close();
        }
        private void guardarJsonviews()
        {
            string arxiuviews = "visitas.json";
            JArray jArrayViews = (JArray)JToken.FromObject(visitas);
            StreamWriter file = File.CreateText(arxiuviews);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayViews.WriteTo(writer);
            writer.Close();
        }
    }
}
