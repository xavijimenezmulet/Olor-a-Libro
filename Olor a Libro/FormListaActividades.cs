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
    public partial class FormListaActividades : Form
    {
        public FormListaActividades()
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

        private void FormListaActividades_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormListaActividades_Activated(object sender, EventArgs e)
        {
            dataGridViewActividades.DataSource = Utilitats.actividades;
            dataGridViewActividades.Refresh();
        }
        //ABRIR FORM PARA AÑADIR ACTIVIDAD
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MetodosMenu.AnyadirAct();
        }
        //ABRIR FORM PARA EDITAR ACTIVIDAD
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewActividades.SelectedRows.Count > 0)
            {
                Actividad a = (Actividad)dataGridViewActividades.SelectedRows[0].DataBoundItem;
                FormActividad fActividad = new FormActividad(a);
                fActividad.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona una Actividad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewActividades.SelectedRows.Count > 0)
            {
                Actividad a = (Actividad)dataGridViewActividades.SelectedRows[0].DataBoundItem;
                Utilitats.actividades.Remove(a);
                dataGridViewActividades.DataSource = Utilitats.actividades;
                dataGridViewActividades.Refresh();
            }
            else
            {
                MessageBox.Show("Selecciona una activitat", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
