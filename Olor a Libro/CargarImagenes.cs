using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olor_a_Libro
{
    class CargarImagenes
    {
        public static OpenFileDialog openFileDialog = new OpenFileDialog();
        public static string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)+ "\\Imagenes";

        public static string cargarImagen()
        {
            string ruta ="";
            string archivo = "";

            openFileDialog.InitialDirectory = path;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog.FileName;
                archivo = ruta;
            }
            
                     
            return archivo;
        }

        public static string quitarRuta(string imagen) {

            string ruta = "";
            string toRemove = path + "\\";
            string y = toRemove.Substring(6);
            
            if (imagen != "")
            {
                if (imagen.Contains(y))
                {
                    ruta = imagen.Substring(y.Length);
                }
                else
                {
                    ruta = imagen;
                }
                
            }
       
            return ruta;
        }

        public static string ponerRuta(string imagen)
        {
            string ruta = "";
            string y = path.Substring(6);
            if (imagen != "")
            {
                ruta = y + "\\" + imagen;
            }
           
            return ruta;
        }

        public static string buscarImagen(string rutaImg)
        {
            string archivo = ponerRuta(rutaImg);
            string ruta = "";
            
            if (System.IO.File.Exists(archivo))
            {
                ruta = archivo;
            }
            else
            {
                MessageBox.Show("No se ha encontrado la imagen", "ERROR AL CARGAR IMAGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ruta = path.Substring(6) + "\\OlorALibro.png";
                //ruta = Path.Combine(Application.StartupPath, "Resource\\OlorALibro.png");
                //ruta = "OlorALibro.png";
            }

            return ruta;
        }
    }
}
