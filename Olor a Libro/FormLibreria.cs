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
    public partial class FormLibreria : Form
    {
        public FormLibreria()
        {
            InitializeComponent();
        }

        private void toolStripButtonInicio_Click(object sender, EventArgs e)
        {
            MetodosMenu.Inicio();
        }

        private void FormLibreria_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
