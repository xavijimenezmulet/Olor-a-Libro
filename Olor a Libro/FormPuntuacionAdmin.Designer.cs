namespace Olor_a_Libro
{
    partial class FormPuntuacionAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libreríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLibreríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirLibreríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anyadirActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntuaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPuntosAct = new System.Windows.Forms.TextBox();
            this.textBoxPuntosLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPuntosLibreria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPuntosLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.textBoxPuntosComentar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStripAccesosDirectos = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLibrerias = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonActividades = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEstadisticas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSalir = new System.Windows.Forms.ToolStripButton();
            this.menuStripMainMenu.SuspendLayout();
            this.toolStripAccesosDirectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStripMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.libreríasToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.estadísticasToolStripMenuItem,
            this.puntuaciónToolStripMenuItem});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMainMenu.Size = new System.Drawing.Size(612, 24);
            this.menuStripMainMenu.TabIndex = 0;
            this.menuStripMainMenu.Text = "Menu Principal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // inicioToolStripMenuItem
            // 
     //       this.inicioToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.Sin_título_2_copia;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonInicio_Click);
            // 
            // guardarToolStripMenuItem
            // 
    //        this.guardarToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.floppy_disk;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // salirToolStripMenuItem
            // 
   //         this.salirToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources._040_fired;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // libreríasToolStripMenuItem
            // 
            this.libreríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLibreríasToolStripMenuItem,
            this.añadirLibreríasToolStripMenuItem});
            this.libreríasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.libreríasToolStripMenuItem.Name = "libreríasToolStripMenuItem";
            this.libreríasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.libreríasToolStripMenuItem.Text = "Librerías";
            // 
            // verLibreríasToolStripMenuItem
            // 
     //       this.verLibreríasToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.books;
            this.verLibreríasToolStripMenuItem.Name = "verLibreríasToolStripMenuItem";
            this.verLibreríasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.verLibreríasToolStripMenuItem.Text = "Ver Librerías";
            this.verLibreríasToolStripMenuItem.Click += new System.EventHandler(this.verLibreriaToolStripMenuItem_Click);
            // 
            // añadirLibreríasToolStripMenuItem
            // 
    //        this.añadirLibreríasToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add_file;
            this.añadirLibreríasToolStripMenuItem.Name = "añadirLibreríasToolStripMenuItem";
            this.añadirLibreríasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.añadirLibreríasToolStripMenuItem.Text = "Añadir Librerías";
            this.añadirLibreríasToolStripMenuItem.Click += new System.EventHandler(this.añadirLibreríaToolStripMenuItem_Click);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verActividadesToolStripMenuItem,
            this.anyadirActividadToolStripMenuItem});
            this.actividadesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // verActividadesToolStripMenuItem
            // 
    //        this.verActividadesToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.reading;
            this.verActividadesToolStripMenuItem.Name = "verActividadesToolStripMenuItem";
            this.verActividadesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.verActividadesToolStripMenuItem.Text = "Ver Actividades";
            this.verActividadesToolStripMenuItem.Click += new System.EventHandler(this.verActividadesToolStripMenuItem_Click);
            // 
            // anyadirActividadToolStripMenuItem
            // 
     //       this.anyadirActividadToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add_file;
            this.anyadirActividadToolStripMenuItem.Name = "anyadirActividadToolStripMenuItem";
            this.anyadirActividadToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.anyadirActividadToolStripMenuItem.Text = "Añadir Actividad";
            this.anyadirActividadToolStripMenuItem.Click += new System.EventHandler(this.anyadirActividadToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUsuariosToolStripMenuItem,
            this.añadirToolStripMenuItem});
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // verUsuariosToolStripMenuItem
            // 
    //        this.verUsuariosToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources._038_hired;
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // añadirToolStripMenuItem
            // 
   //         this.añadirToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add;
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.añadirToolStripMenuItem.Text = "Añadir Usuarios";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirUsuarioToolStripMenuItem_Click);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Por Actividad";
            // 
            // textBoxPuntosAct
            // 
            this.textBoxPuntosAct.Location = new System.Drawing.Point(121, 89);
            this.textBoxPuntosAct.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPuntosAct.Name = "textBoxPuntosAct";
            this.textBoxPuntosAct.Size = new System.Drawing.Size(212, 20);
            this.textBoxPuntosAct.TabIndex = 3;
            // 
            // textBoxPuntosLibro
            // 
            this.textBoxPuntosLibro.Location = new System.Drawing.Point(121, 128);
            this.textBoxPuntosLibro.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPuntosLibro.Name = "textBoxPuntosLibro";
            this.textBoxPuntosLibro.Size = new System.Drawing.Size(212, 20);
            this.textBoxPuntosLibro.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Por Libro";
            // 
            // textBoxPuntosLibreria
            // 
            this.textBoxPuntosLibreria.Location = new System.Drawing.Point(121, 162);
            this.textBoxPuntosLibreria.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPuntosLibreria.Name = "textBoxPuntosLibreria";
            this.textBoxPuntosLibreria.Size = new System.Drawing.Size(212, 20);
            this.textBoxPuntosLibreria.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Por Librería";
            // 
            // textBoxPuntosLogin
            // 
            this.textBoxPuntosLogin.Location = new System.Drawing.Point(121, 200);
            this.textBoxPuntosLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPuntosLogin.Name = "textBoxPuntosLogin";
            this.textBoxPuntosLogin.Size = new System.Drawing.Size(212, 20);
            this.textBoxPuntosLogin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Por Login";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(425, 89);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(92, 31);
            this.buttonAceptar.TabIndex = 10;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(425, 145);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(92, 31);
            this.buttonBorrar.TabIndex = 11;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // textBoxPuntosComentar
            // 
            this.textBoxPuntosComentar.Location = new System.Drawing.Point(121, 235);
            this.textBoxPuntosComentar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPuntosComentar.Name = "textBoxPuntosComentar";
            this.textBoxPuntosComentar.Size = new System.Drawing.Size(212, 20);
            this.textBoxPuntosComentar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Por Comentar";
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
            this.toolStripSeparator2,
            this.toolStripButtonEstadisticas,
            this.toolStripSeparator3,
            this.toolStripButtonSalir});
            this.toolStripAccesosDirectos.Location = new System.Drawing.Point(0, 24);
            this.toolStripAccesosDirectos.Name = "toolStripAccesosDirectos";
            this.toolStripAccesosDirectos.Size = new System.Drawing.Size(612, 25);
            this.toolStripAccesosDirectos.TabIndex = 14;
            this.toolStripAccesosDirectos.Text = "Accesos Directos";
            // 
            // toolStripButtonInicio
            // 
            this.toolStripButtonInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
  //          this.toolStripButtonInicio.Image = global::Olor_a_Libro.Properties.Resources.Sin_título_2_copia__1_1;
            this.toolStripButtonInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInicio.Name = "toolStripButtonInicio";
            this.toolStripButtonInicio.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInicio.Text = "Inicio";
            this.toolStripButtonInicio.Click += new System.EventHandler(this.toolStripButtonInicio_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLibrerias
            // 
            this.toolStripButtonLibrerias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    //        this.toolStripButtonLibrerias.Image = global::Olor_a_Libro.Properties.Resources.books;
            this.toolStripButtonLibrerias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLibrerias.Name = "toolStripButtonLibrerias";
            this.toolStripButtonLibrerias.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLibrerias.Text = "Ver Librerias";
            this.toolStripButtonLibrerias.Click += new System.EventHandler(this.verLibreriaToolStripMenuItem_Click);
            // 
            // toolStripButtonActividades
            // 
            this.toolStripButtonActividades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    //        this.toolStripButtonActividades.Image = global::Olor_a_Libro.Properties.Resources.reading;
            this.toolStripButtonActividades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonActividades.Name = "toolStripButtonActividades";
            this.toolStripButtonActividades.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonActividades.Text = "Ver Actividades";
            this.toolStripButtonActividades.Click += new System.EventHandler(this.verActividadesToolStripMenuItem_Click);
            // 
            // toolStripButtonUsuarios
            // 
            this.toolStripButtonUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
   //         this.toolStripButtonUsuarios.Image = global::Olor_a_Libro.Properties.Resources._038_hired;
            this.toolStripButtonUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsuarios.Name = "toolStripButtonUsuarios";
            this.toolStripButtonUsuarios.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUsuarios.Text = "Ver Usuarios";
            this.toolStripButtonUsuarios.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEstadisticas
            // 
            this.toolStripButtonEstadisticas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
   //         this.toolStripButtonEstadisticas.Image = global::Olor_a_Libro.Properties.Resources._025_presentation;
            this.toolStripButtonEstadisticas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEstadisticas.Name = "toolStripButtonEstadisticas";
            this.toolStripButtonEstadisticas.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEstadisticas.Text = "Ver Estadísticas";
            this.toolStripButtonEstadisticas.Click += new System.EventHandler(this.estadísticasToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSalir
            // 
            this.toolStripButtonSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    //        this.toolStripButtonSalir.Image = global::Olor_a_Libro.Properties.Resources._040_fired;
            this.toolStripButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalir.Name = "toolStripButtonSalir";
            this.toolStripButtonSalir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSalir.Text = "Salir";
            this.toolStripButtonSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormPuntuacionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 418);
            this.Controls.Add(this.toolStripAccesosDirectos);
            this.Controls.Add(this.textBoxPuntosComentar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxPuntosLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPuntosLibreria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPuntosLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPuntosAct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripMainMenu);
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPuntuacionAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor a Libro: Puntuación administrador";
            this.Load += new System.EventHandler(this.FormPuntuacionAdmin_Load);
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
        private System.Windows.Forms.ToolStripMenuItem libreríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntuaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLibreríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirLibreríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anyadirActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPuntosAct;
        private System.Windows.Forms.TextBox textBoxPuntosLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPuntosLibreria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPuntosLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.TextBox textBoxPuntosComentar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStripAccesosDirectos;
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonLibrerias;
        private System.Windows.Forms.ToolStripButton toolStripButtonActividades;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonEstadisticas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalir;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
    }
}