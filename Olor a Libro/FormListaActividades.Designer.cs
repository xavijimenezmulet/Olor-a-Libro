namespace Olor_a_Libro
{
    partial class FormListaActividades
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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libreriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLibreriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirLibreríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anyadirActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntuaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxActividades = new System.Windows.Forms.GroupBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.toolStripAccesosDirectos = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.menuStripMainMenu.SuspendLayout();
            this.groupBoxActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
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
            this.menuStripMainMenu.Size = new System.Drawing.Size(766, 24);
            this.menuStripMainMenu.TabIndex = 2;
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
            this.archivoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.Sin_título_2_copia;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonInicio_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.floppy_disk;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(113, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources._040_fired;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
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
            // 
            // verLibreriaToolStripMenuItem
            // 
            this.verLibreriaToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.books;
            this.verLibreriaToolStripMenuItem.Name = "verLibreriaToolStripMenuItem";
            this.verLibreriaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.verLibreriaToolStripMenuItem.Text = "Ver Librerias";
            this.verLibreriaToolStripMenuItem.Click += new System.EventHandler(this.verLibreriaToolStripMenuItem_Click);
            // 
            // añadirLibreríaToolStripMenuItem
            // 
            this.añadirLibreríaToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add_file;
            this.añadirLibreríaToolStripMenuItem.Name = "añadirLibreríaToolStripMenuItem";
            this.añadirLibreríaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.añadirLibreríaToolStripMenuItem.Text = "Añadir Librería";
            this.añadirLibreríaToolStripMenuItem.Click += new System.EventHandler(this.añadirLibreríaToolStripMenuItem_Click);
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
            this.verActividadesToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.reading;
            this.verActividadesToolStripMenuItem.Name = "verActividadesToolStripMenuItem";
            this.verActividadesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.verActividadesToolStripMenuItem.Text = "Ver Actividades";
            this.verActividadesToolStripMenuItem.Click += new System.EventHandler(this.verActividadesToolStripMenuItem_Click);
            // 
            // anyadirActividadToolStripMenuItem
            // 
            this.anyadirActividadToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add_file;
            this.anyadirActividadToolStripMenuItem.Name = "anyadirActividadToolStripMenuItem";
            this.anyadirActividadToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.anyadirActividadToolStripMenuItem.Text = "Añadir Actividad";
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
            // groupBoxActividades
            // 
            this.groupBoxActividades.Controls.Add(this.buttonEditar);
            this.groupBoxActividades.Controls.Add(this.buttonEliminar);
            this.groupBoxActividades.Controls.Add(this.dataGridViewActividades);
            this.groupBoxActividades.Controls.Add(this.buttonAdd);
            this.groupBoxActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxActividades.Location = new System.Drawing.Point(47, 68);
            this.groupBoxActividades.Name = "groupBoxActividades";
            this.groupBoxActividades.Size = new System.Drawing.Size(683, 338);
            this.groupBoxActividades.TabIndex = 9;
            this.groupBoxActividades.TabStop = false;
            this.groupBoxActividades.Text = "Actividades";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(586, 74);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(586, 115);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Borrar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.AllowUserToAddRows = false;
            this.dataGridViewActividades.AllowUserToDeleteRows = false;
            this.dataGridViewActividades.Location = new System.Drawing.Point(16, 31);
            this.dataGridViewActividades.MultiSelect = false;
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.ReadOnly = true;
            this.dataGridViewActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActividades.Size = new System.Drawing.Size(551, 282);
            this.dataGridViewActividades.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(586, 31);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // toolStripAccesosDirectos
            // 
            this.toolStripAccesosDirectos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripAccesosDirectos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInicio,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.toolStripButton4,
            this.toolStripSeparator6,
            this.toolStripButton5});
            this.toolStripAccesosDirectos.Location = new System.Drawing.Point(0, 24);
            this.toolStripAccesosDirectos.Name = "toolStripAccesosDirectos";
            this.toolStripAccesosDirectos.Size = new System.Drawing.Size(766, 25);
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
            this.toolStripButtonInicio.Click += new System.EventHandler(this.toolStripButtonInicio_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Olor_a_Libro.Properties.Resources.books;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Ver Librerias";
            this.toolStripButton1.Click += new System.EventHandler(this.verLibreriaToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Olor_a_Libro.Properties.Resources.reading;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Ver Actividades";
            this.toolStripButton2.Click += new System.EventHandler(this.verActividadesToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Olor_a_Libro.Properties.Resources._038_hired;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Ver Usuarios";
            this.toolStripButton3.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Olor_a_Libro.Properties.Resources._025_presentation;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Ver Estadísticas";
            this.toolStripButton4.Click += new System.EventHandler(this.estadísticasToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Olor_a_Libro.Properties.Resources._040_fired;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Salir";
            this.toolStripButton5.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormListaActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 418);
            this.Controls.Add(this.toolStripAccesosDirectos);
            this.Controls.Add(this.groupBoxActividades);
            this.Controls.Add(this.menuStripMainMenu);
            this.Name = "FormListaActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor a Libro: Actividades";
            this.Activated += new System.EventHandler(this.FormListaActividades_Activated);
            this.Load += new System.EventHandler(this.FormListaActividades_Load);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.groupBoxActividades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            this.toolStripAccesosDirectos.ResumeLayout(false);
            this.toolStripAccesosDirectos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libreriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLibreriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirLibreríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxActividades;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewActividades;
        private System.Windows.Forms.ToolStripMenuItem puntuaciónToolStripMenuItem;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.ToolStrip toolStripAccesosDirectos;
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anyadirActividadToolStripMenuItem;
    }
}