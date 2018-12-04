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
    public partial class FormEstadisticas : Form
    {
        Actividad act;
        public FormEstadisticas(Actividad act)
        {
            InitializeComponent();
            this.act = act;
            participacionTabla();
        }
        public FormEstadisticas()
        {
            InitializeComponent();
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

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            participacionTabla();
            dataGridViewParticipacion.Refresh();

            tablaRank();
            dataGridViewRank.Refresh();

        }

        /*Función para rellenar la tabla Participación de actividades*/
        private void participacionTabla()
        {
            foreach (var item in Utilitats.actividades)
            {

                int participantesActividad = numeroParticipantes(item.visitas);
                dataGridViewParticipacion.Rows.Add(item.nombre, participantesActividad);
            }
        }

        /* Función para calcular el número de participantes de una actividad */
        private static int numeroParticipantes(BindingList<Visita> ListaVisitas)
        {
            int participantes = 0;

            if (ListaVisitas != null)
            {
                foreach (var item in ListaVisitas)
                {
                    if (item.user != "")
                    {
                        participantes++;
                    }

                }
            }

            return participantes;
        }

        /*Función para buscar los y poner los users de la actividad*/
        private void buscarUsers(BindingList <Visita> v)
        {
            Usuario u = new Usuario();

            if (v != null)
            {
                foreach (var item1 in v)
                {

                    foreach (var item2 in Utilitats.usuarios)
                    {
                        if (item1.user.Equals(item2.username))
                        {
                            dataGridViewPuntosUsuario.Rows.Add(item2.username, item2.puntos);
                        }
                    }
                }
            }
        }

        /*Función para seleccionar una fila de Participación para rellenar la tabla de puntos usuarios*/
        private void dataGridViewParticipacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridViewParticipacion.Rows[e.RowIndex].Cells[0].Value.ToString();
            Usuario u = new Usuario();

            foreach (var item in Utilitats.actividades)
            {
                if (item.nombre.Equals(value))
                {
                    vaciarTabla();
                    buscarUsers(item.visitas);
                    
                }
            }
        }

        /*Función para vaciar la tabla puntos usuarios*/
        private void vaciarTabla()
        {
            int r = dataGridViewPuntosUsuario.RowCount;
            if (r != 0)
            {
                int i = 0;
                while (i < r)
                {
                    dataGridViewPuntosUsuario.Rows.Remove(dataGridViewPuntosUsuario.Rows[i]);
                    r = dataGridViewPuntosUsuario.RowCount;
                }

            }
        }

        /*Función para rellenar la última tabla*/
        private void tablaRank()
        {
            foreach (var item in Utilitats.usuarios)
            {
                dataGridViewRank.Rows.Add(item.username, item.puntos, item.rank);
            }
        }

    }
}
