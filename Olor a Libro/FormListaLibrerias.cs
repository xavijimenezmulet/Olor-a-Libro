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
    public partial class FormListaLibrerias : Form
    {
        public FormListaLibrerias()
        {
            InitializeComponent();
        }

        private void FormListaLibrerias_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormListaLibrerias_Activated(object sender, EventArgs e)
        {
            //dataGridViewLibrerias.DataSource = null;
            dataGridViewLibrerias.DataSource = Utilitats.librerias;
            dataGridViewLibrerias.Refresh();
            
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

        //ABRIR FORM PARA AÑADIR LIBRERIA
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MetodosMenu.AnyadirLibreria();
        }
        //ABRIR FORM PARA EDITAR LIBRERIA
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibrerias.SelectedRows.Count > 0)
            {
                Libreria l = (Libreria)dataGridViewLibrerias.SelectedRows[0].DataBoundItem;
                FormLibreria fLibreria = new FormLibreria(l);
                fLibreria.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona una llibreria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibrerias.SelectedRows.Count > 0)
            {
                Libreria l = (Libreria)dataGridViewLibrerias.SelectedRows[0].DataBoundItem;
                Utilitats.librerias.Remove(l);
                dataGridViewLibrerias.DataSource = null;
                dataGridViewLibrerias.DataSource = Utilitats.librerias;
            }
            else
            {
                MessageBox.Show("Selecciona una llibreria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
    }
}
