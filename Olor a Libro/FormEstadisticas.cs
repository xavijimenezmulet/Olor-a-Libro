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

        //public FormEstadisticas(Actividad act)
        //{
        //    InitializeComponent();
        //    this.act = act;
        //}
        public void tablas()
        {
            
        }
        public void participacionTabla()
        {
            int filas = dataGridViewParticipacion.RowCount;
            DataColumn col = new DataColumn();
            int i = 0;
            foreach (var item in Utilitats.actividades)
            {
                dataGridViewParticipacion.Rows[i].Cells[0].Value = act.nombre;
                int participantesActividad = numeroParticipantes(item.visitas);
                //for (int i = 0; i < filas; i++)
                //{
                    dataGridViewParticipacion.Rows[i].Cells[1].Value = participantesActividad;
                i++;
               // }
            }
            //DataGridView1.Rows[rowindex].Cells[nombrecol].Selected = true;

            

            //dataGridViewParticipacion.Columns[1].
        }
        
        public static int numeroParticipantes(BindingList<Visita> ListaVisitas)
        {
            int participantes = 0;

            foreach (var item in ListaVisitas)
            {
                participantes = item.user.Count();
            }

            return participantes;
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
        }

       
    }
}
