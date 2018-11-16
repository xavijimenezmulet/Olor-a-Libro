﻿using Newtonsoft.Json;
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
        Actividad act;
        public FormActividad()
        {
            InitializeComponent();
        }
        public FormActividad(Actividad act)
        {
            InitializeComponent();
            this.act = act;
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
            listBoxLibreriasAct.DataSource = null;
            listBoxLibreriasAct.DataSource = Utilitats.librerias;
            listBoxLibreriasAct.DisplayMember = "nombre";
            /*for (int i = 0; i < Utilitats.librerias.Count(); i++)
            {
                listBoxLibreriasAct.Items.Add(Utilitats.librerias[i].nombre);
            }*/

            if (act != null)
            {
                textBoxID.Text = act.id.ToString();
                textBoxNomAct.Text = act.nombre;
                textBoxLugarAct.Text = act.lugar;
                comboBoxTipoAct.Text = act.tipo; 
                dateTimePickerDiaAct.Value = act.fecha;
                textBoxHoraAct.Text = act.hora;
                textBoxDescripcionAct.Text = act.descripcion;
                foreach (Libreria item in act.librerias)
                {
                    listBoxLibreriasAct.SelectedItems.Add(item);
                }
            }
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
        /*
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
        }*/
        public static Boolean repetido(Actividad act)
        {
            Boolean encontrado = false;

            foreach (var item in Utilitats.actividades)
            {
                encontrado = Utilitats.actividades.Equals(act);
            }
            return encontrado;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int id = Utilitats.generarid(new BindingList<object>(Utilitats.actividades.Cast<object>().ToList()));
            String nomAct = textBoxNomAct.Text;
            String lugar = textBoxLugarAct.Text;
            String tipo = comboBoxTipoAct.SelectedItem.ToString();
            DateTime fecha = dateTimePickerDiaAct.Value;
            String hora = textBoxHoraAct.Text;
            String descripcion = textBoxDescripcionAct.Text;
            //listBoxLibreriasAct
            //---------------------------------AÑADIR ACTIVIDAD-------------------------------
            if (act == null)
            {
                if (nomAct != "" && lugar != "" && fecha != null && descripcion != "")
                {
                    Actividad act = new Actividad();
                    //act.librerias = new List<int>();

                    act.nombre = nomAct;
                    act.lugar = lugar;
                    act.fecha = fecha;
                    act.hora = hora;
                    act.descripcion = descripcion;
                    foreach (Libreria item in listBoxLibreriasAct.SelectedItems)
                    {
                        act.librerias.Add(item);
                    }
                    Boolean encontrado = repetido(act);

                    if (!encontrado)
                    {
                        Utilitats.actividades.Add(act);
                        MessageBox.Show("Actividad añadida satisfactoriamente", "Añadir Actividad", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Esta actividad ya fue añadida.", "Actividad repetida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No ha rellenado los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (nomAct == "")
                    {
                        textBoxNomAct.Focus();
                    }
                    else if (lugar == "")
                    {
                        textBoxLugarAct.Focus();
                    }
                    else if (tipo == "")
                    {
                        comboBoxTipoAct.Focus();
                    }
                    else if (fecha == null)
                    {
                        dateTimePickerDiaAct.Focus();
                    }
                }
            }

            
        }
    }
}
