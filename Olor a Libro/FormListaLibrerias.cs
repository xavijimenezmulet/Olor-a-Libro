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
            string arxiu = "librerias.json";

            if (File.Exists(arxiu))
            {
                JArray jArrayLibs = JArray.Parse(File.ReadAllText(arxiu));
                Utilitats.librerias = jArrayLibs.ToObject<List<Libreria>>();
            }
            else
            {
                Utilitats.librerias = new List<Libreria>();
            }
            dataGridViewLibrerias.DataSource = Utilitats.librerias;
        }
        private void FormListaLibrerias_Activated(object sender, EventArgs e)
        {
            dataGridViewLibrerias.DataSource = null;
            dataGridViewLibrerias.DataSource = Utilitats.librerias;

            dataGridViewLibrerias.Columns[0].HeaderText = "ID";
            dataGridViewLibrerias.Columns[1].HeaderText = "Nombre";
            dataGridViewLibrerias.Columns[2].HeaderText = "Dirección";
            dataGridViewLibrerias.Columns[3].HeaderText = "Contacto";
            //dataGridViewLibrerias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        //CHECK
        private void ToolStripMenuItemGuardar_Click(object sender, EventArgs e)
        {
            Utilitats.guardarJsonlibs();
        }

        private void ToolStripMenuItemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
