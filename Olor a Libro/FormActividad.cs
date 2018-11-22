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

        private void FormActividad_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            listBoxLibreriasAct.DataSource = null;
            listBoxLibreriasAct.DataSource = Utilitats.librerias;
            listBoxLibreriasAct.DisplayMember = "nombre";

            if (act != null)
            {
                textBoxID.Text = act.id.ToString();
                textBoxNomAct.Text = act.nombre;
                textBoxLugarAct.Text = act.lugar;
                comboBoxTipoAct.Text = act.tipo; 
                dateTimePickerDiaAct.Value = act.fecha;
                textBoxHoraAct.Text = act.hora;
                textBoxDescripcionAct.Text = act.descripcion;
                listBoxLibreriasAct.ClearSelected();
                if (act.librerias != null)
                {
                    foreach (String item in act.librerias)
                    {
                        for (int i = 0; i < Utilitats.librerias.Count; i++)
                        {
                            if (Utilitats.librerias[i].nombre == item)
                            {
                                listBoxLibreriasAct.SelectedItems.Add(Utilitats.librerias[i]);
                            }
                        }
                    }
                }
                else
                {
                    listBoxLibreriasAct.ClearSelected();
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
            BindingList<String> libs = new BindingList<String>();
            //---------------------------------AÑADIR ACTIVIDAD-------------------------------
            if (act == null)
            {
                if (nomAct != "" && lugar != "" && tipo != null && fecha != null && descripcion != "")
                {
                    if (hora.Length == 5 && hora[0].ToString().All(Char.IsDigit) && hora[1].ToString().All(Char.IsDigit) && hora[3].ToString().All(Char.IsDigit) && hora[4].ToString().All(Char.IsDigit))
                    {
                        int hores = int.Parse(hora[0].ToString() + hora[1].ToString());
                        int minuts = int.Parse(hora[3].ToString() + hora[4].ToString());
                        //-------------COMPROBAR HORA-----------

                        if (hora[2] == ':' && hores < 24 && minuts < 60)
                        {
                            Actividad act = new Actividad();
                            act.id = id;
                            act.nombre = nomAct;
                            act.lugar = lugar;
                            act.tipo = tipo;
                            act.fecha = fecha;
                            act.hora = hora;
                            act.descripcion = descripcion;
                            foreach (Libreria item in listBoxLibreriasAct.SelectedItems)
                            {
                                libs.Add(item.nombre);
                            }
                            if (listBoxLibreriasAct.SelectedItems.Count > 0)
                            {
                                act.librerias = libs;
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
                            MessageBox.Show("Formato de hora incorrecto", "Hora incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxHoraAct.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato de hora incorrecto", "Hora incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxHoraAct.Focus();
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
                    else if (descripcion == null)
                    {
                        textBoxDescripcionAct.Focus();
                    }
                }
            }
            //---------------------------------EDITAR ACTIVIDAD------------------------------
            else
            {
                if (nomAct != "" && lugar != "" && fecha != null && descripcion != "")
                {
                    act.nombre = nomAct;
                    act.lugar = lugar;
                    act.tipo = tipo;
                    act.fecha = fecha;
                    act.hora = hora;
                    act.descripcion = descripcion;
                    if (listBoxLibreriasAct.SelectedItems.Count > 0)
                    {
                        foreach (Libreria item in listBoxLibreriasAct.SelectedItems)
                        {
                            libs.Add(item.nombre);
                        }
                    }
                    else
                    {
                        libs = null;
                    }
                    act.librerias = libs;
                   
                    Boolean encontrado = repetido(act);

                    if (!encontrado)
                    {
                        MessageBox.Show("Actividad modificada satisfactoriamente", "Modificar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void FormActividad_Activated(object sender, EventArgs e)
        {
            textBoxNomAct.Focus();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (Utilitats.cancelarForm(sender, e))
            {
                this.Close();
            }
        }
    }
}
