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
            Utilitats.guardarJsonlibs();
            Utilitats.guardarJsonbooks();
            Utilitats.guardarJsonusers();
            Utilitats.guardarJsonop();
            Utilitats.guardarJsonact();
            Utilitats.guardarJsonviews();
        }

        private void FormLibreria_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
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
            //Libreria lib = new Libreria();

            String nombre = textBoxNombreLib.Text;
            String direccion = textBoxDirccionLib.Text;
            String telefono = textBoxTelefonoLib.Text;
            String correo = textBoxCorreoLib.Text;
            String dirWeb = textBoxDirecWebLib.Text;
            
            if (lib == null)
            {
                if (nombre != null && direccion != "" && telefono != "" && correo != "" && dirWeb != "")
                {
                    lib = new Libreria();
                    lib.nombre = nombre;
                    lib.direccion = direccion;
                    lib.Correo = correo;
                    lib.telefono = int.Parse(telefono);

                    Boolean encontrado = repetido(lib);

                    if (!encontrado)
                    {
                        Utilitats.librerias.Add(lib);
                        MessageBox.Show("Libreria añadida satisfactoriamente", "Añadir Librería", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                        this.Focus();
                    }
                    else if (direccion == "")
                    {
                        this.Focus();
                    }
                    else if (telefono == "")
                    {
                        this.Focus();
                    }
                    else if (correo == "")
                    {
                        this.Focus();
                    }
                    else
                    {
                        this.Focus();
                    }
                }
            }
            else
            {

            }

            this.Close();
            

        }
        //AÑADIR / EDITAR LIBRERIA
        /*
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (lib1 == null)
            {
                Libreria l = new Libreria();
                l.nombre = textBoxNombre.Text;
                p.director = textBoxDirector.Text;
                p.any = int.Parse(textBoxAnyo.Text);
                p.tema = new List<string>();

                foreach (string item in listBoxTemas.SelectedItems)
                {
                    p.tema.Add(item);
                }

                if (pelis.Contains(p))
                {
                    MessageBox.Show("La pelicula ja existeix", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    pelis.Add(p);
                }
            }
            else
            {

            }
            this.Close();
        }*/
    }
}
