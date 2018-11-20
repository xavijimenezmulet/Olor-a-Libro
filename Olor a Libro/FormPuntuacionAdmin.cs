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
    public partial class FormPuntuacionAdmin : Form
    {
        Puntuacion puntos;
        public FormPuntuacionAdmin()
        {
            InitializeComponent();
        }

        public FormPuntuacionAdmin(Puntuacion puntos)
        {
            InitializeComponent();
            this.puntos = puntos;
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

        private void FormPuntuacionAdmin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            if (puntos != null)
            {
                textBoxPuntosAct.Text = puntos.puntosActividad.ToString();
                textBoxPuntosLibro.Text = puntos.puntosLibros.ToString();
                textBoxPuntosLibreria.Text = puntos.puntosLibreria.ToString();
                textBoxPuntosLogin.Text = puntos.puntosLogin.ToString();
                textBoxPuntosComentar.Text = puntos.puntosComentar.ToString();
            }
            else
            {
                textBoxPuntosAct.Text = "0";
                textBoxPuntosLibro.Text = "0";
                textBoxPuntosLibreria.Text = "0";
                textBoxPuntosLogin.Text = "0";
                textBoxPuntosComentar.Text = "0";
            }
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string puntosAct = textBoxPuntosAct.Text;
            string puntosLibro = textBoxPuntosLibro.Text;
            string puntosLibreria = textBoxPuntosLibreria.Text;
            string puntosLogin = textBoxPuntosLogin.Text;
            string puntosComent = textBoxPuntosComentar.Text;

            if (puntos == null)
            {
                puntos = new Puntuacion();
                if (puntosAct == null)
                {
                    puntos.puntosActividad = 0;
                }
                if (puntosLibro == null)
                {
                    puntos.puntosLibros = 0;
                }
                if (puntosLibreria == null)
                {
                    puntos.puntosLibreria = 0;
                }
                if (puntosLogin == null)
                {
                    puntos.puntosLogin = 0;
                }
                if (puntosComent == null)
                {
                    puntos.puntosComentar = 0;
                }
                if(puntosAct!= null && puntosLibro != null && puntosLibreria != null && puntosLogin != null && puntosAct != null)
                {
                    puntos.puntosActividad= int.Parse(puntosAct);
                    puntos.puntosLibros = int.Parse(puntosLibro);
                    puntos.puntosLibreria = int.Parse(puntosLibreria);
                    puntos.puntosLogin = int.Parse(puntosLogin);
                    puntos.puntosComentar = int.Parse(puntosComent);
                }
            }
            else
            {
                puntos.puntosActividad = int.Parse(puntosAct);
                puntos.puntosLibros = int.Parse(puntosLibro);
                puntos.puntosLibreria = int.Parse(puntosLibreria);
                puntos.puntosLogin = int.Parse(puntosLogin);
                puntos.puntosComentar = int.Parse(puntosComent);
            }
            Utilitats.puntuacion = puntos;
        }
    }
}
