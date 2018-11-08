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
        public static List<Libreria> librerias = new List<Libreria>();
        public static List<Libro> libros = new List<Libro>();
        public static List<Opinion> opiniones = new List<Opinion>();
        public static List<Actividad> actividades = new List<Actividad>();
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Visita> visitas = new List<Visita>();

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
    }
}
