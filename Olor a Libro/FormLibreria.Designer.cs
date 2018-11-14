namespace Olor_a_Libro
{
    partial class FormLibreria
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
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libreríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLibreríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirLibreríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anyadirActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntuaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAccesosDirectos = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLibrerias = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonActividades = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonestadisticas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSalir = new System.Windows.Forms.ToolStripButton();
            this.textBoxNombreLib = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDirccionLib = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCorreoLib = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelefonoLib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBoxLlibreria = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuscarImg = new System.Windows.Forms.Button();
            this.textBoxImgLib = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonLibros = new System.Windows.Forms.Button();
            this.buttonActividades = new System.Windows.Forms.Button();
            this.pictureBoxImgLib = new System.Windows.Forms.PictureBox();
            this.menuStripMainMenu.SuspendLayout();
            this.toolStripAccesosDirectos.SuspendLayout();
            this.groupBoxLlibreria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgLib)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStripMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.libreríasToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.estadísticasToolStripMenuItem,
            this.puntuaciónToolStripMenuItem});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripMainMenu.Size = new System.Drawing.Size(831, 24);
            this.menuStripMainMenu.TabIndex = 2;
            this.menuStripMainMenu.Text = "Menu Principal";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirtoolStripMenuItem});
            this.archivoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.Sin_título_2_copia;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonInicio_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.floppy_disk;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // salirtoolStripMenuItem
            // 
            this.salirtoolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources._040_fired;
            this.salirtoolStripMenuItem.Name = "salirtoolStripMenuItem";
            this.salirtoolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.salirtoolStripMenuItem.Text = "Salir";
            this.salirtoolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.verLibreríasToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.books;
            this.verLibreríasToolStripMenuItem.Name = "verLibreríasToolStripMenuItem";
            this.verLibreríasToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.verLibreríasToolStripMenuItem.Text = "Ver Librerías";
            this.verLibreríasToolStripMenuItem.Click += new System.EventHandler(this.verLibreriaToolStripMenuItem_Click);
            // 
            // añadirLibreríasToolStripMenuItem
            // 
            this.añadirLibreríasToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add_file;
            this.añadirLibreríasToolStripMenuItem.Name = "añadirLibreríasToolStripMenuItem";
            this.añadirLibreríasToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.añadirLibreríasToolStripMenuItem.Text = "Añadir Librerías";
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verActividadesToolStripMenuItem,
            this.anyadirActividadesToolStripMenuItem});
            this.actividadesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // verActividadesToolStripMenuItem
            // 
            this.verActividadesToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.reading;
            this.verActividadesToolStripMenuItem.Name = "verActividadesToolStripMenuItem";
            this.verActividadesToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.verActividadesToolStripMenuItem.Text = "Ver Actividades";
            this.verActividadesToolStripMenuItem.Click += new System.EventHandler(this.verActividadesToolStripMenuItem_Click);
            // 
            // anyadirActividadesToolStripMenuItem
            // 
            this.anyadirActividadesToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add_file;
            this.anyadirActividadesToolStripMenuItem.Name = "anyadirActividadesToolStripMenuItem";
            this.anyadirActividadesToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.anyadirActividadesToolStripMenuItem.Text = "Añadir Actividades";
            this.anyadirActividadesToolStripMenuItem.Click += new System.EventHandler(this.anyadirActividadToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUsuariosToolStripMenuItem,
            this.añadirUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources._038_hired;
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // añadirUsuariosToolStripMenuItem
            // 
            this.añadirUsuariosToolStripMenuItem.Image = global::Olor_a_Libro.Properties.Resources.add;
            this.añadirUsuariosToolStripMenuItem.Name = "añadirUsuariosToolStripMenuItem";
            this.añadirUsuariosToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.añadirUsuariosToolStripMenuItem.Text = "Añadir Usuarios";
            this.añadirUsuariosToolStripMenuItem.Click += new System.EventHandler(this.añadirUsuarioToolStripMenuItem_Click);
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
            this.toolStripAccesosDirectos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripAccesosDirectos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInicio,
            this.toolStripSeparator2,
            this.toolStripButtonLibrerias,
            this.toolStripButtonActividades,
            this.toolStripButtonUsuarios,
            this.toolStripSeparator3,
            this.toolStripButtonestadisticas,
            this.toolStripSeparator4,
            this.toolStripButtonSalir});
            this.toolStripAccesosDirectos.Location = new System.Drawing.Point(0, 24);
            this.toolStripAccesosDirectos.Name = "toolStripAccesosDirectos";
            this.toolStripAccesosDirectos.Size = new System.Drawing.Size(831, 27);
            this.toolStripAccesosDirectos.TabIndex = 3;
            this.toolStripAccesosDirectos.Text = "Accesos Directos";
            // 
            // toolStripButtonInicio
            // 
            this.toolStripButtonInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInicio.Image = global::Olor_a_Libro.Properties.Resources.Sin_título_2_copia;
            this.toolStripButtonInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInicio.Name = "toolStripButtonInicio";
            this.toolStripButtonInicio.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonInicio.Text = "Inicio";
            this.toolStripButtonInicio.Click += new System.EventHandler(this.toolStripButtonInicio_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonLibrerias
            // 
            this.toolStripButtonLibrerias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLibrerias.Image = global::Olor_a_Libro.Properties.Resources.books;
            this.toolStripButtonLibrerias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLibrerias.Name = "toolStripButtonLibrerias";
            this.toolStripButtonLibrerias.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonLibrerias.Text = "Ver Librerias";
            this.toolStripButtonLibrerias.Click += new System.EventHandler(this.verLibreriaToolStripMenuItem_Click);
            // 
            // toolStripButtonActividades
            // 
            this.toolStripButtonActividades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonActividades.Image = global::Olor_a_Libro.Properties.Resources.reading;
            this.toolStripButtonActividades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonActividades.Name = "toolStripButtonActividades";
            this.toolStripButtonActividades.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonActividades.Text = "Ver Actividades";
            this.toolStripButtonActividades.Click += new System.EventHandler(this.verActividadesToolStripMenuItem_Click);
            // 
            // toolStripButtonUsuarios
            // 
            this.toolStripButtonUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUsuarios.Image = global::Olor_a_Libro.Properties.Resources._038_hired;
            this.toolStripButtonUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsuarios.Name = "toolStripButtonUsuarios";
            this.toolStripButtonUsuarios.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonUsuarios.Text = "Ver Usuarios";
            this.toolStripButtonUsuarios.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonestadisticas
            // 
            this.toolStripButtonestadisticas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonestadisticas.Image = global::Olor_a_Libro.Properties.Resources._025_presentation;
            this.toolStripButtonestadisticas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonestadisticas.Name = "toolStripButtonestadisticas";
            this.toolStripButtonestadisticas.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonestadisticas.Text = "Ver Estadisticas";
            this.toolStripButtonestadisticas.Click += new System.EventHandler(this.estadísticasToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonSalir
            // 
            this.toolStripButtonSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSalir.Image = global::Olor_a_Libro.Properties.Resources._040_fired;
            this.toolStripButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalir.Name = "toolStripButtonSalir";
            this.toolStripButtonSalir.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonSalir.Text = "Salir";
            this.toolStripButtonSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // textBoxNombreLib
            // 
            this.textBoxNombreLib.Location = new System.Drawing.Point(150, 53);
            this.textBoxNombreLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombreLib.Name = "textBoxNombreLib";
            this.textBoxNombreLib.Size = new System.Drawing.Size(289, 21);
            this.textBoxNombreLib.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Librería";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dirección";
            // 
            // textBoxDirccionLib
            // 
            this.textBoxDirccionLib.Location = new System.Drawing.Point(150, 79);
            this.textBoxDirccionLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDirccionLib.Name = "textBoxDirccionLib";
            this.textBoxDirccionLib.Size = new System.Drawing.Size(289, 21);
            this.textBoxDirccionLib.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Correo";
            // 
            // textBoxCorreoLib
            // 
            this.textBoxCorreoLib.Location = new System.Drawing.Point(150, 106);
            this.textBoxCorreoLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCorreoLib.Name = "textBoxCorreoLib";
            this.textBoxCorreoLib.Size = new System.Drawing.Size(289, 21);
            this.textBoxCorreoLib.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Teléfono";
            // 
            // textBoxTelefonoLib
            // 
            this.textBoxTelefonoLib.Location = new System.Drawing.Point(150, 131);
            this.textBoxTelefonoLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefonoLib.Name = "textBoxTelefonoLib";
            this.textBoxTelefonoLib.Size = new System.Drawing.Size(289, 21);
            this.textBoxTelefonoLib.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(150, 28);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(289, 21);
            this.textBoxID.TabIndex = 0;
            // 
            // groupBoxLlibreria
            // 
            this.groupBoxLlibreria.Controls.Add(this.label6);
            this.groupBoxLlibreria.Controls.Add(this.buttonBuscarImg);
            this.groupBoxLlibreria.Controls.Add(this.textBoxImgLib);
            this.groupBoxLlibreria.Controls.Add(this.textBoxCorreoLib);
            this.groupBoxLlibreria.Controls.Add(this.label5);
            this.groupBoxLlibreria.Controls.Add(this.textBoxNombreLib);
            this.groupBoxLlibreria.Controls.Add(this.textBoxID);
            this.groupBoxLlibreria.Controls.Add(this.label1);
            this.groupBoxLlibreria.Controls.Add(this.label4);
            this.groupBoxLlibreria.Controls.Add(this.textBoxDirccionLib);
            this.groupBoxLlibreria.Controls.Add(this.textBoxTelefonoLib);
            this.groupBoxLlibreria.Controls.Add(this.label2);
            this.groupBoxLlibreria.Controls.Add(this.label3);
            this.groupBoxLlibreria.Location = new System.Drawing.Point(205, 81);
            this.groupBoxLlibreria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLlibreria.Name = "groupBoxLlibreria";
            this.groupBoxLlibreria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLlibreria.Size = new System.Drawing.Size(455, 187);
            this.groupBoxLlibreria.TabIndex = 15;
            this.groupBoxLlibreria.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Imagen";
            // 
            // buttonBuscarImg
            // 
            this.buttonBuscarImg.Location = new System.Drawing.Point(413, 154);
            this.buttonBuscarImg.Name = "buttonBuscarImg";
            this.buttonBuscarImg.Size = new System.Drawing.Size(26, 23);
            this.buttonBuscarImg.TabIndex = 23;
            this.buttonBuscarImg.Text = "...";
            this.buttonBuscarImg.UseVisualStyleBackColor = true;
            this.buttonBuscarImg.Click += new System.EventHandler(this.buttonBuscarImg_Click);
            // 
            // textBoxImgLib
            // 
            this.textBoxImgLib.Location = new System.Drawing.Point(150, 155);
            this.textBoxImgLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxImgLib.Name = "textBoxImgLib";
            this.textBoxImgLib.Size = new System.Drawing.Size(257, 21);
            this.textBoxImgLib.TabIndex = 21;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(691, 136);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(119, 35);
            this.buttonAceptar.TabIndex = 17;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseCompatibleTextRendering = true;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(691, 177);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(119, 35);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonLibros
            // 
            this.buttonLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibros.Location = new System.Drawing.Point(157, 301);
            this.buttonLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLibros.Name = "buttonLibros";
            this.buttonLibros.Size = new System.Drawing.Size(119, 35);
            this.buttonLibros.TabIndex = 19;
            this.buttonLibros.Text = "Libros";
            this.buttonLibros.UseVisualStyleBackColor = true;
            // 
            // buttonActividades
            // 
            this.buttonActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActividades.Location = new System.Drawing.Point(493, 301);
            this.buttonActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActividades.Name = "buttonActividades";
            this.buttonActividades.Size = new System.Drawing.Size(119, 35);
            this.buttonActividades.TabIndex = 20;
            this.buttonActividades.Text = "Actividades";
            this.buttonActividades.UseVisualStyleBackColor = true;
            // 
            // pictureBoxImgLib
            // 
            this.pictureBoxImgLib.ErrorImage = global::Olor_a_Libro.Properties.Resources.OlorALibro;
            this.pictureBoxImgLib.Image = global::Olor_a_Libro.Properties.Resources.OlorALibro;
            this.pictureBoxImgLib.Location = new System.Drawing.Point(30, 99);
            this.pictureBoxImgLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImgLib.Name = "pictureBoxImgLib";
            this.pictureBoxImgLib.Size = new System.Drawing.Size(100, 150);
            this.pictureBoxImgLib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxImgLib.TabIndex = 4;
            this.pictureBoxImgLib.TabStop = false;
            // 
            // FormLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 495);
            this.Controls.Add(this.buttonActividades);
            this.Controls.Add(this.buttonLibros);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBoxLlibreria);
            this.Controls.Add(this.pictureBoxImgLib);
            this.Controls.Add(this.toolStripAccesosDirectos);
            this.Controls.Add(this.menuStripMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLibreria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor a Libro: Librería";
            this.Activated += new System.EventHandler(this.FormLibreria_Activated);
            this.Text = "Olor A Libro: Libreria";
            this.Load += new System.EventHandler(this.FormLibreria_Load);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.toolStripAccesosDirectos.ResumeLayout(false);
            this.toolStripAccesosDirectos.PerformLayout();
            this.groupBoxLlibreria.ResumeLayout(false);
            this.groupBoxLlibreria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgLib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem libreríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem verLibreríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirLibreríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripAccesosDirectos;
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonLibrerias;
        private System.Windows.Forms.ToolStripButton toolStripButtonActividades;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonestadisticas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalir;
        private System.Windows.Forms.PictureBox pictureBoxImgLib;
        private System.Windows.Forms.TextBox textBoxNombreLib;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDirccionLib;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCorreoLib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelefonoLib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.GroupBox groupBoxLlibreria;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonLibros;
        private System.Windows.Forms.Button buttonActividades;
        private System.Windows.Forms.ToolStripMenuItem anyadirActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntuaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxImgLib;
        private System.Windows.Forms.Button buttonBuscarImg;
    }
}