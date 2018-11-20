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
    public partial class FormLibros : Form
    {
        Libreria lib;
        

        public FormLibros(Libreria lib)
        {
            this.lib = lib;
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

        private void FormLibros_Load(object sender, EventArgs e)
        {
            Utilitats.libros = lib.libros;
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridViewLibros.DataSource = Utilitats.libros;
            dataGridViewLibros.Refresh();
        }

        // Metodos Del Formulario

        private void buttonAnyadir_Click(object sender, EventArgs e)
        {
            
            Libro l = new Libro();
            anyadirLibro(l);

            Utilitats.libros.Add(l);
            dataGridViewLibros.Refresh();
        }
        private void anyadirLibro(Libro l)
        {
            //int id = Utilitats.generarid(new BindingList<object>(Utilitats.libros.Cast<object>().ToList()));
            l.id = 1;
            l.titulo = textBoxTitulo.Text;
            l.autor = textBoxAutor.Text;
            l.anyo = int.Parse(textBoxAnyoEdicion.Text);
            l.precio = int.Parse(textBoxPrecio.Text);
            l.genero = new List<String>();
            foreach (string item in listBoxGeneros.SelectedItems)
            {
                l.genero.Add(item);
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            lib.libros.RemoveAt(dataGridViewLibros.SelectedRows[0].Index);

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Libro l = (Libro)dataGridViewLibros.SelectedRows[0].DataBoundItem;

            anyadirLibro(l);

        }

       /* private void refrescarGrid()
        {
            dataGridViewLibros.DataSource = lib.libros;
        }*/

        private void dataGridViewLibros_SelectionChanged(object sender, EventArgs e)
        {
            Libro l = (Libro)dataGridViewLibros.SelectedRows[0].DataBoundItem;

            textBoxTitulo.Text = l.titulo;
            textBoxAutor.Text = l.autor;
            textBoxAnyoEdicion.Text = l.anyo.ToString();
            textBoxPrecio.Text = l.precio.ToString();
            foreach (string item in l.genero)
            {
                listBoxGeneros.SelectedItems.Add(item);
            }
        }

        private void FormLibros_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utilitats.closeit(sender, e);
        }
    }
    
}
