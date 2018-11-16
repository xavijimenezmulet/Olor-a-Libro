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
    public partial class SplashInicio : Form
    {
        public SplashInicio()
        {
            InitializeComponent();
            Tiempo.Enabled = true;
            Tiempo.Interval = 6000;
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SplashInicio_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Gray;
            this.TransparencyKey = Color.Gray;
        }
    }
}
