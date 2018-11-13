using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olor_a_Libro
{
    class CargarImagenes
    {
        public static OpenFileDialog openFileDialog = new OpenFileDialog();
        public static String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)+ "\\Imagenes";

        public static String cargarImagen()
        {
            String ruta="";
            String archivo = "";

            openFileDialog.InitialDirectory = path;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog.FileName;
                archivo = recortarRuta(ruta);
            }
            
                     
            return archivo;
        }

        public static String recortarRuta(String imagen) {

            String ruta = "";
            String archivo = "";
            String toRemove = path + "\\";

            string result = string.Empty;
            int i = ruta.IndexOf(toRemove);
            if (i >= 0)
            {
                archivo = ruta.Remove(i, toRemove.Length);
            }

            return ruta;
        }

        public static String ponerRuta(String imagen)
        {
            String ruta = "";
            
            ruta = path + "\\" + imagen;

            return ruta;
        }

        public static String buscarImagen(Libreria lib)
        {
            String archivo = "";
            String ruta = "";


            ruta = ponerRuta(lib.imagen);
            //if (openFileDialog.CheckFileExists=ruta))
            //{
            //    ruta = archivo;
            //}
            //else
            //{
            //    MessageBox.Show("No se ha encontrado la imagen", "ERROR AL CARGAR IMAGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    ruta = path + "\\OlorALibro.png";
            //}

            return ruta;
        }
    }
}
