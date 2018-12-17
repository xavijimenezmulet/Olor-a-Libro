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
 * CLASE UTILITATS (NOS SERVIRÁ PARA GARGAR LOS JSON EN LISTAS Y PODER TRABAJAR CON ELLOS)
 **/ 
namespace Olor_a_Libro
{
    public static class Utilitats
    {
        //ATRIBUTOS DE UTILITATS
        public static BindingList<Libreria> librerias = new BindingList<Libreria>();
        public static BindingList<Libro> libros = new BindingList<Libro>();
        public static BindingList<Opinion> opiniones = new BindingList<Opinion>();
        public static BindingList<Actividad> actividades = new BindingList<Actividad>();
        public static BindingList<Usuario> usuarios = new BindingList<Usuario>();
        public static BindingList<Visita> visitas = new BindingList<Visita>();
        public static Puntuacion puntuacion = new Puntuacion();
        public static Rango rango = new Rango();

        /**
         * NOS GUARDA EL JSON DE LIBRERIAS
         **/
        public static void guardarJsonlibs()
        {
            string arxiulib = "librerias.json";
            JArray jArrayLibs = (JArray)JToken.FromObject(librerias);
            StreamWriter file = File.CreateText(arxiulib);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayLibs.WriteTo(writer);
            writer.Close();
        }

        /**
         * NOS GUARDA EL JSON DE LIBROS
         **/ 
        public static void guardarJsonbooks()
        {
            string arxiubook = "libros.json";
            JArray jArrayBooks = (JArray)JToken.FromObject(libros);
            StreamWriter file = File.CreateText(arxiubook);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayBooks.WriteTo(writer);
            writer.Close();
        }

        /**
         * NOS GUARDA EL JSON DE USUARIOS
         **/ 
        public static void guardarJsonusers()
        {
            string arxiuuser = "usuarios.json";
            JArray jArrayUsers = (JArray)JToken.FromObject(usuarios);
            StreamWriter file = File.CreateText(arxiuuser);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayUsers.WriteTo(writer);
            writer.Close();
        }

        /**
         * NOS GUARDA EL JSON DE OPINIONES
         **/
        public static void guardarJsonop()
        {
            string arxiuop = "opiniones.json";
            JArray jArrayOps = (JArray)JToken.FromObject(opiniones);
            StreamWriter file = File.CreateText(arxiuop);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayOps.WriteTo(writer);
            writer.Close();
        }

        /**
         * NOS GUARDA EL JSON DE ACTIVIDADES
         **/ 
        public static void guardarJsonact()
        {
            string arxiuact = "actividades.json";
            JArray jArrayAct = (JArray)JToken.FromObject(actividades);
            StreamWriter file = File.CreateText(arxiuact);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayAct.WriteTo(writer);
            writer.Close();
        }

        /**
         * NOS GUARDA EL JSON DE VISITAS
         **/ 
        public static void guardarJsonviews()
        {
            string arxiuviews = "visitas.json";
            JArray jArrayViews = (JArray)JToken.FromObject(visitas);
            StreamWriter file = File.CreateText(arxiuviews);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayViews.WriteTo(writer);
            writer.Close();
        }

        /**
         * NOS GUARDA EL JSON DE PUNTUACION
         **/ 
        public static void guardarJsonPuntuacion()
        {
            string arxiuPuntuacio = "puntuacion.json";
            //JArray jArrayPuntuacio = (JArray)JToken.FromObject(puntuacion);
            JObject jArrayPuntuacio = (JObject)JToken.FromObject(puntuacion);
            StreamWriter file = File.CreateText(arxiuPuntuacio);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayPuntuacio.WriteTo(writer);
            writer.Close();
        }

        /**
         * NOS GUARDA EL JSON DE RANGOS
         **/ 
        public static void guardarJsonRangos()
        {
            string arxiurangos = "rangos.json";
            //JArray jArrayPuntuacio = (JArray)JToken.FromObject(puntuacion);
            JObject jArrayRangos = (JObject)JToken.FromObject(rango);
            StreamWriter file = File.CreateText(arxiurangos);
            JsonTextWriter writer = new JsonTextWriter(file);
            jArrayRangos.WriteTo(writer);
            writer.Close();
        }

        /**
         * AUTOGENERA UN ID AUTOINCREMENTAL
         **/ 
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
                valor = 1;
            }
            return valor;
        }

        /**
         * DIALOGO QUE REUTILIZAMOS A LA HORA DE CERRAR UN FORMULARIO
         **/ 
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

        /**
         * NOS GUARDA ABSOLUTAMENTE TODAS LAS LISTAS EN LOS JSON
         **/ 
        public static void guardarTodo()
        {
            Utilitats.guardarJsonlibs();
            Utilitats.guardarJsonbooks();
            Utilitats.guardarJsonusers();
            Utilitats.guardarJsonop();
            Utilitats.guardarJsonact();
            Utilitats.guardarJsonviews();
            Utilitats.guardarJsonPuntuacion();
            Utilitats.guardarJsonRangos();
        }

        /**
         * REUTILIZAMOS AL CANCELAR UN FORMULARIO EL DIALOGRESULT
         **/ 
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

        /**
         * REUTILIZAMOS AL ELIMINAR UN ELEMENTO DE LA LISTA EL DIALOGRESULT 
         * @parametro (String objeto) LE PASAMOS EL STRING QUE ES EL NOMBRE DE EL ELEMENTO DE LA LISTA
         **/ 
        public static Boolean eliminarForm(object sender, EventArgs e, String objeto)
        {
            Boolean verdadero = false;
            DialogResult respuesta = MessageBox.Show("Estás a punto de eliminar a " + objeto + " ¿Estás seguro?",
                                                     "ADVERTENCIA",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                verdadero = true;
            }

            return verdadero;

        }
        /**
         * NOS BUSCA SI EL ID EXISTE O NO Y NOS DEVUELVE UN BOOLEANO, TODO ESTO A PARTIR DE UN OBJETO Y LA LISTA DEL
         * MISMO TIPO DE OBJECTO
         **/ 
        public static bool buscarId(object sender, EventArgs e, Object objeto, BindingList<object> lista)
        {
            
            int total = lista.Count;
            int id, id2;
            string nombre, nombre2, lugar, lugar2 = "", hora, hora2 = "", fecha, fecha2, direccion, direccion2 ="";
            bool igual = false;
            id2 = (int)objeto.GetType().GetProperty("id").GetValue(objeto);
            nombre2 = (string)objeto.GetType().GetProperty("nombre").GetValue(objeto);
            if (objeto is Actividad)
            {
                lugar2 = (string)objeto.GetType().GetProperty("lugar").GetValue(objeto);
                hora2 = (string)objeto.GetType().GetProperty("hora").GetValue(objeto);
                fecha2 = (string)objeto.GetType().GetProperty("fecha").GetValue(objeto);
            }
            else if (objeto is Libreria)
            {
                direccion2 = (string)objeto.GetType().GetProperty("direccion").GetValue(objeto);
            }

            for (int i = 0; i < total; i++)
            {
                id = (int)lista.First().GetType().GetProperty("id").GetValue(lista[i]);
                nombre = (string)lista.First().GetType().GetProperty("nombre").GetValue(lista[i]);
                if (objeto is Actividad)
                {
                    lugar = (string)lista.First().GetType().GetProperty("lugar").GetValue(lista[i]);
                    hora = (string)lista.First().GetType().GetProperty("hora").GetValue(lista[i]);
                    fecha = (string)objeto.GetType().GetProperty("fecha").GetValue(lista[i]);
                    if (id != id2 && nombre == nombre2 && lugar == lugar2 && hora == hora2)
                    {
                        igual = true;
                    }
                }
                else if (objeto is Libreria)
                {
                    direccion = (string)objeto.GetType().GetProperty("direccion").GetValue(lista[i]);
                    if (id != id2 && nombre == nombre2 && direccion == direccion2)
                    {
                        igual = true;
                    }
                }

               
            }
            return igual;
        }

       /* public static void actsLibs()
        {
            for (int i = 0; i < librerias.Count; i++)
            {
                for (int j = 0; j < librerias[i].actividades.Count; j++)
                {
                    for (int k = 0; k < actividades.Count; k++)
                    {
                        if (librerias[i].actividades[j] == actividades[k].nombre)
                        {

                        }
                    }
                }
            }
        }*/
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
