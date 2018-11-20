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
    public partial class FormUsuarios : Form
    {
        /**
         * CONSTRUCTORES
         **/
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        /**
         * FORMUSUARIOS_LOAD : NOS CENTRA EL FORMULARIO Y LUEGO MIRA SI EXISTE EL JSON,
         * SI EXISTE LO CARGA Y SINO CREA UNA LISTA DE USUARIOS Y GUARDA EN LA GRID LOS USUARIOS
         **/
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            //Utilitats.carregarJsons();
            String arxiu = "usuarios.json";

            if (File.Exists(arxiu))
            {
                JArray jArrayLibs = JArray.Parse(File.ReadAllText(arxiu));
                Utilitats.usuarios = jArrayLibs.ToObject<BindingList<Usuario>>();
            }
            else
            {
                Utilitats.usuarios = new BindingList<Usuario>();
            }
            dataGridViewUsuarios.DataSource = Utilitats.usuarios;
        }
        /**
         * FORMUSUARIOS_ACTIVATED: CADA VEZ QUE SE ABRA EL FORMULARIO NOS REFRESCA LA GRIDVIEW
         * DE USUARIOS
         **/
        private void FormUsuarios_Activated(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataSource = Utilitats.usuarios;
            dataGridViewUsuarios.Refresh();
        }
        /**
         * BUTTONANYADIR_CLICK: NOS ABRE UN FORMULARIOA FORMVERUSUARIO PARA PODER AÑADIR UN
         * USUARIO UTILIZANDO LA CLASE METODOSMENU 
         **/
        private void buttonAnyadir_Click(object sender, EventArgs e)
        {
            MetodosMenu.AnyadirUsuarios();
        }

        /**
         * BUTTONEDITAR_CLICK: NOS EDITA A TRAVÉS DE LA SELECCIÓN EN LA GRIDVIEW UN USUARIO 
         * ABRIENDO ASÍ EL FORMULARIO PARA EDITAR SI NO SELECCIONAMOS NINGUNO NOS MUESTRA UN MENSAJE
         * DE ERROR
         **/
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                Usuario user = (Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;
                FormVerUsuario fuser = new FormVerUsuario(user);
                fuser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /**
         * FORMUSUARIOS_FORMCLOSING: AL CLICKAR LA PESTAÑA DE CERRAR NOS APARECERÁ UN CUADRO DIALOGO
         * PREGUNTANDO SI SALIR SIN GUARDAR CANCELAR O SEGUIR 
         **/
        private void FormUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Preguntar si quiere garbar o no
            Utilitats.closeit(sender, e);

        }

        
        /**
         * BUTTONELIMINAR_CLICK: AL CLICKAR NOS ELIMINA UN USUARIO SELECCIONADO DE LA GRIDVIEW
         * SI NO SELECCIONAMOS NINGUNO NOS SALTA MENSAJE DE ERROR
         **/
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                Usuario user = (Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;
                Utilitats.usuarios.Remove(user);
                dataGridViewUsuarios.DataSource = null;
                dataGridViewUsuarios.DataSource = Utilitats.usuarios;
            }
            else
            {
                MessageBox.Show("Selecciona un usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
