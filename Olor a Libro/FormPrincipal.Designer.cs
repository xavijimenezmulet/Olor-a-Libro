namespace Olor_a_Libro
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libreriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLibreriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirLibreríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntuaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAccesosDirectos = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLibrerias = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonActividades = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEstadisticas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSalir = new System.Windows.Forms.ToolStripButton();
            this.añadirActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainMenu.SuspendLayout();
            this.toolStripAccesosDirectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.libreriasToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.estadísticasToolStripMenuItem,
            this.puntuaciónToolStripMenuItem});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(769, 24);
            this.menuStripMainMenu.TabIndex = 0;
            this.menuStripMainMenu.Text = "Menu Principal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator3,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.archivoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.DropDownClosed += new System.EventHandler(this.archivoToolStripMenuItem_DropDownClosed);
            this.archivoToolStripMenuItem.DropDownOpened += new System.EventHandler(this.archivoToolStripMenuItem_DropDownOpened);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.Sin_título_2_copia__1_1;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.floppy_disk;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources._040_fired;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // libreriasToolStripMenuItem
            // 
            this.libreriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLibreriaToolStripMenuItem,
            this.añadirLibreríaToolStripMenuItem});
            this.libreriasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.libreriasToolStripMenuItem.Name = "libreriasToolStripMenuItem";
            this.libreriasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.libreriasToolStripMenuItem.Text = "Librerias";
            this.libreriasToolStripMenuItem.DropDownClosed += new System.EventHandler(this.libreriasToolStripMenuItem_DropDownClosed);
            this.libreriasToolStripMenuItem.DropDownOpened += new System.EventHandler(this.libreriasToolStripMenuItem_DropDownOpened);
            // 
            // verLibreriaToolStripMenuItem
            // 
            this.verLibreriaToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.books;
            this.verLibreriaToolStripMenuItem.Name = "verLibreriaToolStripMenuItem";
            this.verLibreriaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verLibreriaToolStripMenuItem.Text = "Ver Librerias";
            this.verLibreriaToolStripMenuItem.Click += new System.EventHandler(this.verLibreriaToolStripMenuItem_Click);
            // 
            // añadirLibreríaToolStripMenuItem
            // 
            this.añadirLibreríaToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add_file;
            this.añadirLibreríaToolStripMenuItem.Name = "añadirLibreríaToolStripMenuItem";
            this.añadirLibreríaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.añadirLibreríaToolStripMenuItem.Text = "Añadir Librería";
            this.añadirLibreríaToolStripMenuItem.Click += new System.EventHandler(this.añadirLibreríaToolStripMenuItem_Click);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verActividadesToolStripMenuItem,
            this.añadirActividadToolStripMenuItem});
            this.actividadesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            this.actividadesToolStripMenuItem.DropDownClosed += new System.EventHandler(this.actividadesToolStripMenuItem_DropDownClosed);
            this.actividadesToolStripMenuItem.DropDownOpened += new System.EventHandler(this.actividadesToolStripMenuItem_DropDownOpened);
            // 
            // verActividadesToolStripMenuItem
            // 
            this.verActividadesToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.reading;
            this.verActividadesToolStripMenuItem.Name = "verActividadesToolStripMenuItem";
            this.verActividadesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.verActividadesToolStripMenuItem.Text = "Ver Actividades";
            this.verActividadesToolStripMenuItem.Click += new System.EventHandler(this.verActividadesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUsuariosToolStripMenuItem,
            this.añadirUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.DropDownClosed += new System.EventHandler(this.usuariosToolStripMenuItem_DropDownClosed);
            this.usuariosToolStripMenuItem.DropDownOpened += new System.EventHandler(this.usuariosToolStripMenuItem_DropDownOpened);
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources._038_hired;
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // añadirUsuarioToolStripMenuItem
            // 
            this.añadirUsuarioToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add;
            this.añadirUsuarioToolStripMenuItem.Name = "añadirUsuarioToolStripMenuItem";
            this.añadirUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.añadirUsuarioToolStripMenuItem.Text = "Añadir Usuario";
            this.añadirUsuarioToolStripMenuItem.Click += new System.EventHandler(this.añadirUsuarioToolStripMenuItem_Click);
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            this.estadísticasToolStripMenuItem.Click += new System.EventHandler(this.estadísticasToolStripMenuItem_Click);
            // 
            // puntuaciónToolStripMenuItem
            // 
            this.puntuaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.puntuaciónToolStripMenuItem.Name = "puntuaciónToolStripMenuItem";
            this.puntuaciónToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.puntuaciónToolStripMenuItem.Text = "Puntuación";
            this.puntuaciónToolStripMenuItem.Click += new System.EventHandler(this.puntuaciónToolStripMenuItem_Click);
            // 
            // toolStripAccesosDirectos
            // 
            this.toolStripAccesosDirectos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripAccesosDirectos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInicio,
            this.toolStripSeparator4,
            this.toolStripButtonLibrerias,
            this.toolStripButtonActividades,
            this.toolStripButtonUsuarios,
            this.toolStripSeparator1,
            this.toolStripButtonEstadisticas,
            this.toolStripSeparator2,
            this.toolStripButtonSalir});
            this.toolStripAccesosDirectos.Location = new System.Drawing.Point(0, 24);
            this.toolStripAccesosDirectos.Name = "toolStripAccesosDirectos";
            this.toolStripAccesosDirectos.Size = new System.Drawing.Size(769, 25);
            this.toolStripAccesosDirectos.TabIndex = 11;
            this.toolStripAccesosDirectos.Text = "Accesos Directos";
            // 
            // toolStripButtonInicio
            // 
            this.toolStripButtonInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInicio.Image = global::Olor_a_Libro.Properties.Resources.Sin_título_2_copia__1_1;
            this.toolStripButtonInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInicio.Name = "toolStripButtonInicio";
            this.toolStripButtonInicio.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInicio.Text = "Inicio";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLibrerias
            // 
            this.toolStripButtonLibrerias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLibrerias.Image = global::Olor_a_Libro.Properties.Resources.books;
            this.toolStripButtonLibrerias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLibrerias.Name = "toolStripButtonLibrerias";
            this.toolStripButtonLibrerias.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLibrerias.Text = "Ver Librerias";
            this.toolStripButtonLibrerias.Click += new System.EventHandler(this.verLibreriaToolStripMenuItem_Click);
            // 
            // toolStripButtonActividades
            // 
            this.toolStripButtonActividades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonActividades.Image = global::Olor_a_Libro.Properties.Resources.reading;
            this.toolStripButtonActividades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonActividades.Name = "toolStripButtonActividades";
            this.toolStripButtonActividades.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonActividades.Text = "Ver Actividades";
            this.toolStripButtonActividades.Click += new System.EventHandler(this.verActividadesToolStripMenuItem_Click);
            // 
            // toolStripButtonUsuarios
            // 
            this.toolStripButtonUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUsuarios.Image = global::Olor_a_Libro.Properties.Resources._038_hired;
            this.toolStripButtonUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsuarios.Name = "toolStripButtonUsuarios";
            this.toolStripButtonUsuarios.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUsuarios.Text = "Ver Usuarios";
            this.toolStripButtonUsuarios.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEstadisticas
            // 
            this.toolStripButtonEstadisticas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEstadisticas.Image = global::Olor_a_Libro.Properties.Resources._025_presentation;
            this.toolStripButtonEstadisticas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEstadisticas.Name = "toolStripButtonEstadisticas";
            this.toolStripButtonEstadisticas.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEstadisticas.Text = "Ver Estadísticas";
            this.toolStripButtonEstadisticas.Click += new System.EventHandler(this.estadísticasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSalir
            // 
            this.toolStripButtonSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSalir.Image = global::Olor_a_Libro.Properties.Resources._040_fired;
            this.toolStripButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalir.Name = "toolStripButtonSalir";
            this.toolStripButtonSalir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSalir.Text = "Salir";
            this.toolStripButtonSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // añadirActividadToolStripMenuItem
            // 
            this.añadirActividadToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add_file;
            this.añadirActividadToolStripMenuItem.Name = "añadirActividadToolStripMenuItem";
            this.añadirActividadToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.añadirActividadToolStripMenuItem.Text = "Añadir Actividad";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Olor_a_Libro.Properties.Resources.Sin_título_1_copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(769, 512);
            this.Controls.Add(this.toolStripAccesosDirectos);
            this.Controls.Add(this.menuStripMainMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor a Libro: Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.toolStripAccesosDirectos.ResumeLayout(false);
            this.toolStripAccesosDirectos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libreriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLibreriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirLibreríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntuaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripAccesosDirectos;
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonLibrerias;
        private System.Windows.Forms.ToolStripButton toolStripButtonActividades;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEstadisticas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalir;
        private System.Windows.Forms.ToolStripMenuItem añadirActividadToolStripMenuItem;
    }
}

