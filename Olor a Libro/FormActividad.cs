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
    public partial class FormActividad : Form
    {
        List<Actividad> actividad = new List<Actividad>();
        List<Libreria> lib;
        Actividad act1;
        public FormActividad()
        {
            InitializeComponent();
        }
        public FormActividad(Actividad act1)
        {
            InitializeComponent();
            this.act1 = act1;
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

        private void FormActividad_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            omplirListBox();
        }

        private void archivoToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            archivoToolStripMenuItem.ForeColor = Color.White;
        }

        private void archivoToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            archivoToolStripMenuItem.ForeColor = Color.Black;
        }

        private void libreríasToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            libreríasToolStripMenuItem.ForeColor = Color.White;
        }

        private void libreríasToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            libreríasToolStripMenuItem.ForeColor = Color.Black;
        }

        private void actividadesToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            actividadesToolStripMenuItem.ForeColor = Color.White;
        }

        private void actividadesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            actividadesToolStripMenuItem.ForeColor = Color.Black;
        }

        private void usuariosToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            usuariosToolStripMenuItem.ForeColor = Color.White;
        }

        private void usuariosToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            usuariosToolStripMenuItem.ForeColor = Color.Black;
        }

        public static void omplirListBox()
        {
            ListBox listBL = new ListBox();
            List<Libreria> lib;

            if (File.Exists("librerias.json"))
            {
                JArray jArrayPelis = JArray.Parse(File.ReadAllText("librerias.json"));
                lib = jArrayPelis.ToObject<List<Libreria>>();
            }
            else
            {
                lib = new List<Libreria>();
            }


            foreach (var item in lib)
            {
                listBL.Items.Add(item.nombre);
                listBL.DisplayMember = item.id.ToString(); 
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            String nomAct = textBoxNomAct.Text;
            String lugar = textBoxLugarAct.Text;
            //String tipo = comboBoxTipoAct.SelectedItem
            String fecha = dateTimePickerDiaAct.Text;
            String hora = textBoxHoraAct.Text;
            String descripcion = textBoxDescripcionAct.Text;
                      

            if (nomAct!="" && lugar != "" && fecha != "" && hora != "" && descripcion != "" && listBoxLibreriasAct.SelectedItems!=null)
            {
                Actividad act = new Actividad();
                act.IDlibrerias = new List<int>();

                act.nombre = nomAct;
                act.lugar = lugar;
                act.fecha = fecha;
                act.hora = hora;
                act.descripcion = descripcion;

                foreach (var item in listBoxLibreriasAct.SelectedItems)
                {
                    //act.IDlibrerias.Add(item)
                }
            }
            else
            {
                
            }

            
        }
    }
}
