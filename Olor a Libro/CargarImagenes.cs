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
                archivo = ruta;
            }
            
                     
            return archivo;
        }

        public static String quitarRuta(String imagen) {

            String ruta = "";
            String toRemove = path + "\\";
            String y = toRemove.Substring(6);
            ruta = imagen.Substring(y.Length);
            
            return ruta;
        }

        public static String ponerRuta(String imagen)
        {
            String ruta = "";
            String y = path.Substring(6);
            ruta = y + "\\" + imagen;

            return ruta;
        }

        public static String buscarImagen(String rutaImg)
        {
            String archivo = ponerRuta(rutaImg);
            String ruta = "";
            
            if (System.IO.File.Exists(archivo))
            {
                ruta = archivo;
            }
            else
            {
                MessageBox.Show("No se ha encontrado la imagen", "ERROR AL CARGAR IMAGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ruta = path.Substring(6) + "\\OlorALibro.png";
            }

            return ruta;
        }
    }
}
