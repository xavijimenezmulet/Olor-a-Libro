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
    public partial class FormLibreria : Form
    {
        Libreria lib;

        public FormLibreria()
        {
            InitializeComponent();
        }

        public FormLibreria(Libreria lib)
        {
            InitializeComponent();
            this.lib = lib;
        }


        //ACCESO A LOS FORMULARIOS

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void verLibreriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.VerLibrerias();
            this.Close();
        }
        private void añadirLibreríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.AnyadirLibreria();
            this.Close();
        }
        private void verActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.VerActividades();
            this.Close();
        }
        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.verUsuarios();
            this.Close();
        }
        private void añadirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.AnyadirUsuarios();
            this.Close();
        }
        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.Estadisticas();
            this.Close();
        }

        private void puntuaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.PuntosAdmin();
            this.Close();
        }

        private void toolStripButtonInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.Inicio();
            this.Close();
        }
        private void anyadirActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosMenu.AnyadirAct();
            this.Close();
        }
        //GUARDAR TODO

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitats.guardarTodo();
        }

        private void FormLibreria_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            
            if(lib != null)
            {
                textBoxID.Text = lib.id.ToString();
                textBoxNombreLib.Text = lib.nombre;
                textBoxDirccionLib.Text = lib.direccion;
                textBoxTelefonoLib.Text = lib.telefono.ToString();
                textBoxCorreoLib.Text = lib.Correo;
                String archivo = "";
                archivo = CargarImagenes.buscarImagen(lib.imagen);
                pictureBoxImgLib.Image = System.Drawing.Image.FromFile(archivo);
                textBoxImgLib.Text = archivo;
               
                pictureBoxImgLib.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxImgLib.Size = new System.Drawing.Size(150, 200);
            }
        }

        public static Boolean repetido(Libreria lib)
        {
            Boolean encontrado = false;

            foreach (var item in Utilitats.librerias)
            {
                encontrado = Utilitats.librerias.Equals(lib);
            }
            return encontrado;   
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            int  id = Utilitats.generarid(new BindingList <object>(Utilitats.librerias.Cast<object>().ToList()));

            String nombre = textBoxNombreLib.Text;
            String direccion = textBoxDirccionLib.Text;
            String telefono = textBoxTelefonoLib.Text;
            String correo = textBoxCorreoLib.Text;
            String img = CargarImagenes.quitarRuta(textBoxImgLib.Text);
            //---------------------------------AÑADIR LIBRERIA------------------------------
            if (lib == null)
            {
                if (nombre != null && direccion != "" && telefono != "")
                {
                    lib = new Libreria();
                    lib.id = id;
                    lib.nombre = nombre;
                    lib.direccion = direccion;
                    lib.telefono = int.Parse(telefono);
                    lib.Correo = correo;
                    lib.imagen = img;

                    
                    Boolean encontrado = repetido(lib);

                    if (!encontrado)
                    {
                        Utilitats.librerias.Add(lib);
                        MessageBox.Show("Libreria añadida satisfactoriamente", "Añadir Librería", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Esta librería ya fue añadida.", "Librería repetida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No ha rellenado los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (nombre == "")
                    {
                        textBoxNombreLib.Focus();
                    }
                    else if (direccion == "")
                    {
                        textBoxDirccionLib.Focus();
                    }
                    else if (telefono == "")
                    {
                        textBoxTelefonoLib.Focus();
                    }
                    /*else
                    {
                        this.Focus();
                    }*/
                }
            }
            //---------------------------------EDITAR LIBRERIA------------------------------
            else
            {
                if (nombre != null && direccion != "" && telefono != "")
                {
                    //lib.id = id;
                    lib.nombre = nombre;
                    lib.direccion = direccion;
                    lib.telefono = int.Parse(telefono);
                    lib.Correo = correo;
                    lib.imagen = img; 
                    Boolean encontrado = repetido(lib);

                    if (!encontrado)
                    {
                        MessageBox.Show("Libreria modificada satisfactoriamente", "Modificar Librería", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Esta librería ya fue añadida.", "Librería repetida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                MessageBox.Show("No ha rellenado los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (nombre == "")
                {
                    textBoxNombreLib.Focus();
                }
                else if (direccion == "")
                {
                    textBoxDirccionLib.Focus();
                }
                else if (telefono == "")
                {
                    textBoxTelefonoLib.Focus();
                }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuscarImg_Click(object sender, EventArgs e)
        {

            String ruta = "";
            ruta=CargarImagenes.cargarImagen();

            if (ruta != "")
            {
                textBoxImgLib.Text = ruta;
                pictureBoxImgLib.Image = System.Drawing.Image.FromFile(ruta);
                pictureBoxImgLib.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxImgLib.Size = new System.Drawing.Size(100, 150);
            }
            
        }

        private void buttonLibros_Click(object sender, EventArgs e)
        {
            FormLibros libros = new FormLibros(lib);
            libros.ShowDialog();
        }
    }
}
