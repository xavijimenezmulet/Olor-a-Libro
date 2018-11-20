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
            this.user = user;
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

        }

        public static Boolean repetido(Usuario user)
        {
            Boolean encontrado = false;


            foreach (var item in Utilitats.usuarios)
            {
                Boolean enc = Utilitats.usuarios.Equals(user);
                if (enc)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFechaNacimiento_Click(object sender, EventArgs e)
        {

        }
    }
}
