using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olor_a_Libro
{
    public partial class FormLibros : Form
    {
        List<Libro> libro = new List<Libro>();

        
        public FormLibros()
        {
            InitializeComponent();
            libro = Utilitats.libros;

            dataGridViewLibros.DataSource = null;
            dataGridViewLibros.DataSource = libro;
        }

        private void buttonAnyadir_Click(object sender, EventArgs e)
        {
            Libro l = new Libro();

            l.titulo = textBoxTitulo.Text;
            l.autor = textBoxTitulo.Text;
            l.anyo = int.Parse(textBoxAnyoEdicion.Text);
            l.precio = int.Parse(textBoxPrecio.Text);
            foreach (string item in listBoxGeneros.SelectedItems)
            {
                l.genero.Add(item);
            }

            libro.Add(l);
            dataGridViewLibros.DataSource = null;
            dataGridViewLibros.DataSource = libro;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            libro.RemoveAt(dataGridViewLibros.SelectedRows[0].Index);

            dataGridViewLibros.DataSource = null;
            dataGridViewLibros.DataSource = libro;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }
    }
    }
}
