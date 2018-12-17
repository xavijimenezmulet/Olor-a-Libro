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
    public partial class FormVerUsuario : Form
    {
        Usuario user;
        /**
         * CONSTRUCTORES
         **/
        public FormVerUsuario()
        {
            InitializeComponent();
        }
        public FormVerUsuario(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
        /*
         * ACCESO A LOS FORMULARIOS
         **/
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
        /**
         * GUARDAR TODO
         **/
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitats.guardarTodo();
        }

        /**
         * LOAD DE USUARIO AL CARGAR POR PRIMERA VEZ SE NOS CENTRA SI NOS VIENE POR PARAMETRO UN USUARIO(EDITAR)
         * NOS MOSTRARÁ LOS DATOS DE EL USUARIO A EDITAR SI NO NOS CARGARÁ PARA UN USUARIO NUEVO
         **/ 
        private void FormVerUsuario_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            if (this.user != null)
            {
                textBoxUsuario.Text     = this.user.username;
                textBoxNombre.Text      = this.user.nombre;
                textBoxApellidos.Text   = this.user.apellidos;
                textBoxCiudad.Text      = this.user.ciudad;
                textBoxContrasenya.Text = this.user.password;
                textBoxPuntos.Text      = this.user.puntos.ToString();
                textBoxRanking.Text     = this.user.rank;
                textBoxDescuento.Text   = this.user.descuento.ToString();
            }
            else
            {
                textBoxContrasenya.Text = "user";
                textBoxPuntos.Text = "0";
                textBoxRanking.Text = "unranked";
                textBoxDescuento.Text = "0.0";

            }

        }

   
        /**
         * NOS CIERRA EL FORMULARIO SIN GUARDAR NADA
         **/ 
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if(Utilitats.cancelarForm(sender, e))
            {
                this.Close(); 
            }
     
        }

        /**
         * AL ACEPTAR NOS GUARDA EL USUARIO A LA LISTA DE USUARIOS DE UTILITATS EN CASO DE ERRORES 
         * SE INFORMA MEDIANTE MESSAGEBOX AL ADMIN
         **/ 
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            String username    = textBoxUsuario.Text;
            String nombre      = textBoxNombre.Text;
            String apellidos   = textBoxApellidos.Text;
            String ciudad      = textBoxCiudad.Text;
            String contrasenya = textBoxContrasenya.Text;
            int puntos         = int.Parse(textBoxPuntos.Text);
            String rank        = textBoxRanking.Text;
            float descuento    = float.Parse(textBoxDescuento.Text);

           if (user == null)
            {
                if(username !="" 
                    && nombre!=""
                    && apellidos!=""
                    && ciudad!="")
                {
                    this.user           = new Usuario();
                    this.user.username  = username;
                    this.user.nombre    = nombre;
                    this.user.apellidos = apellidos;
                    this.user.ciudad    = ciudad;

                    

                    if (!Utilitats.usuarios.Contains(user))
                    {
                        Utilitats.usuarios.Add(user);
                        MessageBox.Show("Usuario añadido satisfactoriamente", "Añadir Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Este usuario ya fue añadido", "Usuario repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.user = null;
                    }
                }
                else
                {
                    MessageBox.Show("No ha rellenado los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(username == "")
                    {
                        textBoxUsuario.Focus();
                    }
                    else if(nombre == "")
                    {
                        textBoxNombre.Focus();
                    }
                    else if(apellidos == "")
                    {
                        textBoxContrasenya.Focus();
                    }
                    else if(ciudad == "")
                    {
                        textBoxCiudad.Focus();
                    }
                }
            }
           else
            {
                if (username != ""
                    && nombre != ""
                    && apellidos != ""
                    && ciudad != "")
                {
                    this.user.username = username;
                    this.user.nombre = nombre;
                    this.user.apellidos = apellidos;
                    this.user.ciudad = ciudad;



                    if (Utilitats.usuarios.Contains(user))
                    {
                        MessageBox.Show("Usuario modificado satisfactoriamente", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al introducir el usuario", "Usuario no introducido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.user = null;
                    }
                }
                else
                {
                    MessageBox.Show("No ha rellenado los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (username == "")
                    {
                        textBoxUsuario.Focus();
                    }
                    else if (nombre == "")
                    {
                        textBoxNombre.Focus();
                    }
                    else if (apellidos == "")
                    {
                        textBoxContrasenya.Focus();
                    }
                    else if (ciudad == "")
                    {
                        textBoxCiudad.Focus();
                    }
                }
            }
        }

        private void FormVerUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Utilitats.closeit(sender, e);
        }
    }
}
