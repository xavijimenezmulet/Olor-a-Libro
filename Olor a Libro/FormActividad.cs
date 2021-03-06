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
                textBoxDiaAct.Text = act.fecha;
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
                                //Utilitats.librerias[i].actividades.Remove(act.nombre); //-----proba per solucionar problemas al editar les llibreries de l'activitat
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
            String tipo = null;
            if (comboBoxTipoAct.SelectedItem != null)
            {
                tipo = comboBoxTipoAct.SelectedItem.ToString(); //comprobar tipo------------
            }
            else
            {
                tipo = "";
            }
            String fecha = textBoxDiaAct.Text;
            String hora = textBoxHoraAct.Text;
            String descripcion = textBoxDescripcionAct.Text;
            BindingList<String> libs = new BindingList<String>();
            //---------------------------------AÑADIR ACTIVIDAD-------------------------------
            if (act == null)
            {
                if (nomAct != "" && lugar != "" && tipo != "" && fecha != null && descripcion != "")
                {
                    if (hora.Length == 5 && hora[0].ToString().All(Char.IsDigit) && hora[1].ToString().All(Char.IsDigit) && hora[3].ToString().All(Char.IsDigit) && hora[4].ToString().All(Char.IsDigit))
                    {
                        int hores = int.Parse(hora[0].ToString() + hora[1].ToString());
                        int minuts = int.Parse(hora[3].ToString() + hora[4].ToString());
                        //-------------COMPROBAR HORA-----------

                        if (hora[2] == ':' && hores < 24 && minuts < 60)
                        {
                            string checkdate = DateTime.Now.ToString("yyyy");
                            int chkanyo = int.Parse(checkdate);
                            int anyo = int.Parse(fecha[6].ToString() + fecha[7].ToString() + fecha[8].ToString() + fecha[9].ToString());
                            int dia = int.Parse(fecha[0].ToString() + fecha[1].ToString());
                            int mes = int.Parse(fecha[3].ToString() + fecha[4].ToString());
                            if (fecha[2] == '/' && fecha[5] == '/' && anyo >= chkanyo && dia <= 31 && dia > 00 && mes <= 12 && mes > 00)
                            {
                                if (((mes == 01 || mes == 03 || mes == 05 || mes == 07 || mes == 08 || mes == 10 || mes == 12)  && dia <= 31) || ((mes == 02 || mes == 04 || mes == 06 || mes == 09 || mes == 11) && dia <= 30))
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
                                    //Boolean encontrado = repetido(act);

                                    if (!Utilitats.actividades.Contains(act))
                                    {
                                        Utilitats.actividades.Add(act);
                                        //------------------Comprobar---------------------------
                                        if (act.librerias != null)
                                        {
                                            foreach (String item in act.librerias) //recorre les llibreries asignadesa l'activitat
                                            {
                                                for (int i = 0; i < Utilitats.librerias.Count(); i++)//recorre les llibreries
                                                {
                                                    if (item == Utilitats.librerias[i].nombre)//per cada lib mira si el nom es el matix que la llibreria de l'activitat
                                                    {
                                                        Utilitats.librerias[i].actividades.Add(act.nombre);
                                                    }
                                                }
                                            }
                                        }
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
                                    MessageBox.Show("Has introducido una fecha incorrecta", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBoxDiaAct.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Formato de fecha incorrecto", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxDiaAct.Focus();
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
                        textBoxDiaAct.Focus();
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
                if (nomAct != "" && lugar != "" && fecha != null && descripcion != "" && tipo != "")
                {
                    if (hora.Length == 5 && hora[0].ToString().All(Char.IsDigit) && hora[1].ToString().All(Char.IsDigit) && hora[3].ToString().All(Char.IsDigit) && hora[4].ToString().All(Char.IsDigit))
                    {
                        int hores = int.Parse(hora[0].ToString() + hora[1].ToString());
                        int minuts = int.Parse(hora[3].ToString() + hora[4].ToString());
                        //-------------COMPROBAR HORA-----------

                        if (hora[2] == ':' && hores < 24 && minuts < 60)
                        {
                            Actividad actAux = new Actividad();
                            actAux.id = act.id;
                            actAux.nombre = nomAct;
                            actAux.lugar = lugar;
                            actAux.tipo = tipo;
                            actAux.fecha = fecha;
                            actAux.hora = hora;
                            actAux.descripcion = descripcion;
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
                            actAux.librerias = libs;
                            // ----------------buscar si actividad ya existe en la lista sin contarse a si misma  -----------------
                            if (Utilitats.buscarId(sender, e, actAux, new BindingList<object>(Utilitats.actividades.Cast<object>().ToList()))) // detecta la propia actividad que se edita como repetida.
                            {
                                MessageBox.Show("Esta actividad ya fue añadida.", "Actividad repetida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                //-----------borrem la activitat de les anteriors llibreries------------ ya esta hecho en el load
                                if (act.librerias != null)
                                {
                                    foreach (String item in act.librerias)
                                    {
                                        for (int i = 0; i < Utilitats.librerias.Count; i++)
                                        {
                                            if (Utilitats.librerias[i].nombre == item)
                                            {
                                               Utilitats.librerias[i].actividades.Remove(act.nombre);
                                            }
                                        }
                                    }
                                }
                                //----------comprobacio si les llibreries ja contenen la activitat i la afegim si no es aixi----------------
                                if (libs != null)
                                {
                                    foreach (String item in libs) //recorre les llibreries asignadesa l'activitat
                                    {
                                        for (int i = 0; i < Utilitats.librerias.Count(); i++)//recorre les llibreries
                                        {
                                            if (item == Utilitats.librerias[i].nombre)//per cada lib mira si el nom es el matix que la llibreria de l'activitat
                                            {
                                                bool trobat = false;
                                                for (int j = 0; j < Utilitats.librerias[i].actividades.Count; j++) //recorre les activitats de la llibreria
                                                {
                                                    if (Utilitats.librerias[i].actividades[j] == nomAct) //si la activitat existeix en la llibreria guardem que ja existeix
                                                    {
                                                        trobat = true;
                                                    }
                                                }
                                                if (trobat == false) //si no esta ja en la llibreria, l'afegim
                                                {
                                                    Utilitats.librerias[i].actividades.Add(nomAct);
                                                }
                                            }
                                        }
                                    }
                                }
                                act.nombre = actAux.nombre;
                                act.lugar = actAux.lugar;
                                act.tipo = actAux.tipo;
                                act.fecha = actAux.fecha;
                                act.hora = actAux.hora;
                                act.descripcion = actAux.descripcion;
                                act.librerias = actAux.librerias;
                                MessageBox.Show("Actividad modificada satisfactoriamente", "Modificar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.Close();
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
                        textBoxDiaAct.Focus();
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
