namespace Olor_a_Libro
{
    partial class FormVerUsuario
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
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.textBoxPuntos = new System.Windows.Forms.TextBox();
            this.textBoxDescuento = new System.Windows.Forms.TextBox();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.textBoxRanking = new System.Windows.Forms.TextBox();
            this.labelRanking = new System.Windows.Forms.Label();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelContrasenya = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.menuStripMainMenu.SuspendLayout();
            this.toolStripAccesosDirectos.SuspendLayout();
            this.groupBoxUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStripMainMenu.Enabled = false;
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.libreriasToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.estadísticasToolStripMenuItem,
            this.puntuaciónToolStripMenuItem});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(381, 24);
            this.menuStripMainMenu.TabIndex = 1;
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
            this.inicioToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.Sin_titulo_2_copia;
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
            this.anyadirActividadToolStripMenuItem.Click += new System.EventHandler(this.anyadirActividadToolStripMenuItem_Click);
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
            this.toolStripAccesosDirectos.Enabled = false;
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
            this.toolStripAccesosDirectos.Size = new System.Drawing.Size(381, 25);
            this.toolStripAccesosDirectos.TabIndex = 3;
            this.toolStripAccesosDirectos.Text = "Accesos Directos";
            // 
            // toolStripButtonInicio
            // 
            this.toolStripButtonInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInicio.Image = global::Olor_a_Libro.Properties.Resources.Sin_titulo_2_copia__1_1;
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
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(this.textBoxPuntos);
            this.groupBoxUsuario.Controls.Add(this.textBoxDescuento);
            this.groupBoxUsuario.Controls.Add(this.labelDescuento);
            this.groupBoxUsuario.Controls.Add(this.textBoxCiudad);
            this.groupBoxUsuario.Controls.Add(this.labelCiudad);
            this.groupBoxUsuario.Controls.Add(this.textBoxRanking);
            this.groupBoxUsuario.Controls.Add(this.labelRanking);
            this.groupBoxUsuario.Controls.Add(this.labelPuntos);
            this.groupBoxUsuario.Controls.Add(this.textBoxApellidos);
            this.groupBoxUsuario.Controls.Add(this.textBoxContrasenya);
            this.groupBoxUsuario.Controls.Add(this.textBoxNombre);
            this.groupBoxUsuario.Controls.Add(this.textBoxUsuario);
            this.groupBoxUsuario.Controls.Add(this.labelContrasenya);
            this.groupBoxUsuario.Controls.Add(this.labelApellidos);
            this.groupBoxUsuario.Controls.Add(this.labelNombre);
            this.groupBoxUsuario.Controls.Add(this.labelUsuario);
            this.groupBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsuario.Location = new System.Drawing.Point(12, 63);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(422, 309);
            this.groupBoxUsuario.TabIndex = 4;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Usuario";
            // 
            // textBoxPuntos
            // 
            this.textBoxPuntos.Location = new System.Drawing.Point(115, 211);
            this.textBoxPuntos.Name = "textBoxPuntos";
            this.textBoxPuntos.ReadOnly = true;
            this.textBoxPuntos.Size = new System.Drawing.Size(202, 23);
            this.textBoxPuntos.TabIndex = 5;
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.Location = new System.Drawing.Point(115, 274);
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.ReadOnly = true;
            this.textBoxDescuento.Size = new System.Drawing.Size(202, 23);
            this.textBoxDescuento.TabIndex = 7;
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescuento.Location = new System.Drawing.Point(21, 284);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(59, 13);
            this.labelDescuento.TabIndex = 20;
            this.labelDescuento.Text = "Descuento";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(215, 397);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(66, 397);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(115, 133);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(202, 23);
            this.textBoxCiudad.TabIndex = 3;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudad.Location = new System.Drawing.Point(21, 143);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(40, 13);
            this.labelCiudad.TabIndex = 14;
            this.labelCiudad.Text = "Ciudad";
            // 
            // textBoxRanking
            // 
            this.textBoxRanking.Location = new System.Drawing.Point(115, 243);
            this.textBoxRanking.Name = "textBoxRanking";
            this.textBoxRanking.ReadOnly = true;
            this.textBoxRanking.Size = new System.Drawing.Size(202, 23);
            this.textBoxRanking.TabIndex = 6;
            // 
            // labelRanking
            // 
            this.labelRanking.AutoSize = true;
            this.labelRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRanking.Location = new System.Drawing.Point(21, 253);
            this.labelRanking.Name = "labelRanking";
            this.labelRanking.Size = new System.Drawing.Size(47, 13);
            this.labelRanking.TabIndex = 12;
            this.labelRanking.Text = "Ranking";
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.Location = new System.Drawing.Point(21, 221);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(40, 13);
            this.labelPuntos.TabIndex = 10;
            this.labelPuntos.Text = "Puntos";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(115, 91);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(202, 23);
            this.textBoxApellidos.TabIndex = 2;
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Location = new System.Drawing.Point(115, 168);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(202, 23);
            this.textBoxContrasenya.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(115, 55);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(202, 23);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(115, 18);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(202, 23);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // labelContrasenya
            // 
            this.labelContrasenya.AutoSize = true;
            this.labelContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenya.Location = new System.Drawing.Point(21, 178);
            this.labelContrasenya.Name = "labelContrasenya";
            this.labelContrasenya.Size = new System.Drawing.Size(61, 13);
            this.labelContrasenya.TabIndex = 4;
            this.labelContrasenya.Text = "Contraseña";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.Location = new System.Drawing.Point(21, 101);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 3;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(21, 65);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(21, 28);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // FormVerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 443);
            this.Controls.Add(this.groupBoxUsuario);
            this.Controls.Add(this.toolStripAccesosDirectos);
            this.Controls.Add(this.menuStripMainMenu);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "FormVerUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor a Libro: Ver Usuario";
            this.Load += new System.EventHandler(this.FormVerUsuario_Load);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.toolStripAccesosDirectos.ResumeLayout(false);
            this.toolStripAccesosDirectos.PerformLayout();
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelContrasenya;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.TextBox textBoxRanking;
        private System.Windows.Forms.Label labelRanking;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxDescuento;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anyadirActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntuaciónToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPuntos;
    }
}