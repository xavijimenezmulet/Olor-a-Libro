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

        //------------------FUNCIO PER GENERAR ID------------------------------------------
        public static int generarid(BindingList<object> lista)
        {
            //Type tipo = lista.First().GetType();
            
            int total = lista.Count;
            int valor;
            if (total > 0)
            {
                valor = (int)lista.First().GetType().GetProperty("id").GetValue(lista[total - 1]);
                valor = valor + 1;
                //id = (int)(tipo.GetType().GetProperty("id").GetValue(lista[total - 1])) + 1;
            }
            else
            {
                valor = 0;
            }
            return valor;
        }
    }
}
