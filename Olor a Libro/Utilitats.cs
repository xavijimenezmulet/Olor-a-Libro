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
    public static class Utilitats
    {
        public static BindingList<Libreria> librerias = new BindingList<Libreria>();
        public static BindingList<Libro> libros = new BindingList<Libro>();
        public static BindingList<Opinion> opiniones = new BindingList<Opinion>();
        public static BindingList<Actividad> actividades = new BindingList<Actividad>();
        public static BindingList<Usuario> usuarios = new BindingList<Usuario>();
        public static BindingList<Visita> visitas = new BindingList<Visita>();

        public static void guardarJsonlibs()
        {
            string arxiulib = "librerias.json";
            JArray jArrayLibs = (JArray)JToken.FromObject(librerias);
            StreamWriter file = File.CreateText(arxiulib);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayLibs.WriteTo(writer);
            writer.Close();
        }
        public static void guardarJsonbooks()
        {
            string arxiubook = "libros.json";
            JArray jArrayBooks = (JArray)JToken.FromObject(libros);
            StreamWriter file = File.CreateText(arxiubook);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayBooks.WriteTo(writer);
            writer.Close();
        }
        public static void guardarJsonusers()
        {
            string arxiuuser = "usuarios.json";
            JArray jArrayUsers = (JArray)JToken.FromObject(usuarios);
            StreamWriter file = File.CreateText(arxiuuser);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayUsers.WriteTo(writer);
            writer.Close();
        }
        public static void guardarJsonop()
        {
            string arxiuop = "opiniones.json";
            JArray jArrayOps = (JArray)JToken.FromObject(opiniones);
            StreamWriter file = File.CreateText(arxiuop);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayOps.WriteTo(writer);
            writer.Close();
        }
        public static void guardarJsonact()
        {
            string arxiuact = "actividades.json";
            JArray jArrayAct = (JArray)JToken.FromObject(actividades);
            StreamWriter file = File.CreateText(arxiuact);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayAct.WriteTo(writer);
            writer.Close();
        }
        public static void guardarJsonviews()
        {
            string arxiuviews = "visitas.json";
            JArray jArrayViews = (JArray)JToken.FromObject(visitas);
            StreamWriter file = File.CreateText(arxiuviews);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayViews.WriteTo(writer);
            writer.Close();
        }

        //------------------METODE PER GENERAR ID------------------------------------------
        public static int generarid(BindingList<object> lista)
        {
            int total = lista.Count;
            int valor;
            if (total > 0)
            {
                valor = (int)lista.First().GetType().GetProperty("id").GetValue(lista[total - 1]);
                valor = valor + 1;
            }
            else
            {
                valor = 0;
            }
            return valor;
        }

        public static void closeit(object sender, FormClosingEventArgs e)
        {
            //Preguntar si quiere garbar o no
            DialogResult respuesta;
            respuesta = MessageBox.Show("Estás a punto de salir sin guardar, quieres guardar?"
                , "ADVERTENCIA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (respuesta)
            {
                case DialogResult.Yes:
                    //consultar compañeros
                    Utilitats.guardarTodo();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        public static void guardarTodo()
        {
            Utilitats.guardarJsonlibs();
            Utilitats.guardarJsonbooks();
            Utilitats.guardarJsonusers();
            Utilitats.guardarJsonop();
            Utilitats.guardarJsonact();
            Utilitats.guardarJsonviews();
        }

        public static Boolean cancelarForm(object sender, EventArgs e)
        {
            Boolean verdadero = false;
            DialogResult respuesta = MessageBox.Show("¿Quieres salir?",
                                                     "ADVERTENCIA",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if(respuesta == DialogResult.Yes)
            {
                verdadero = true;
            }

            return verdadero;
            
        }
        //----------------METODE PER CARREGAR JSONS A LES LLISTES---------------
        /*public static void carregarJsons()
        {
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
                librerias = jArrayLibs.ToObject<BindingList<Libreria>>();
            }
            else
            {
                librerias = new BindingList<Libreria>();
            }
            if (File.Exists(arxiubook))
            {
                JArray jArrayBooks = JArray.Parse(File.ReadAllText(arxiubook));
                libros = jArrayBooks.ToObject<BindingList<Libro>>();
            }
            else
            {
                libros = new BindingList<Libro>();
            }
            if (File.Exists(arxiuuser))
            {
                JArray jArrayusers = JArray.Parse(File.ReadAllText(arxiuuser));
                librerias = jArrayusers.ToObject<BindingList<Libreria>>();
            }
            else
            {
                usuarios = new BindingList<Usuario>();
            }
            if (File.Exists(arxiuop))
            {
                JArray jArrayops = JArray.Parse(File.ReadAllText(arxiuop));
                opiniones = jArrayops.ToObject<BindingList<Opinion>>();
            }
            else
            {
                opiniones = new BindingList<Opinion>();
            }
            if (File.Exists(arxiuact))
            {
                JArray jArrayacts = JArray.Parse(File.ReadAllText(arxiuact));
                actividades = jArrayacts.ToObject<BindingList<Actividad>>();
            }
            else
            {
                actividades = new BindingList<Actividad>();
            }
            if (File.Exists(arxiuviews))
            {
                JArray jArrayviews = JArray.Parse(File.ReadAllText(arxiuviews));
                visitas = jArrayviews.ToObject<BindingList<Visita>>();
            }
            else
            {
                visitas = new BindingList<Visita>();
            }
        }*/
    }
}
