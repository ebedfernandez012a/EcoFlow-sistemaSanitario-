namespace sistemaSanitario
{
    partial class FormInspeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInspeccion));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnClausurar = new Button();
            btnGuardar = new Button();
            pnlAlertaContenedor = new Panel();
            pnlAlertaCuerpo = new Panel();
            pictureBox3 = new PictureBox();
            lblAlertaTitulo = new Label();
            lblAlertaMensaje = new Label();
            pnlMonitor = new Panel();
            txtObservaciones = new TextBox();
            lblTituloObservaciones = new Label();
            chkBasureroTapa = new CheckBox();
            chkPermisoVigente = new CheckBox();
            chkPlagas = new CheckBox();
            chkPiso = new CheckBox();
            chkSuperficies = new CheckBox();
            chkCubreboca = new CheckBox();
            lblMonitor = new Label();
            pnlDatoslocal = new Panel();
            txtInspector = new TextBox();
            txtFechaInsp = new TextBox();
            txtPropietario = new TextBox();
            lblInspector = new Label();
            lblFechaInsp = new Label();
            lblPropietario = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            lblNombre = new Label();
            lblIdLocal = new Label();
            lblTituloficha = new Label();
            tabPage2 = new TabPage();
            btnExportar = new Button();
            btnLimpiar = new Button();
            pnlReincidencias = new Panel();
            gbTotalFaltas = new GroupBox();
            lblFaltas = new Label();
            gbClausuras = new GroupBox();
            lblClausuras = new Label();
            gbAprobados = new GroupBox();
            lblAprobados = new Label();
            lblResumen = new Label();
            pnlHistorial = new Panel();
            dgvHistorial = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            btnBuscarHistorial = new Button();
            cmbFiltroEstado = new ComboBox();
            lblEstado = new Label();
            cmbFiltroLocal = new ComboBox();
            lblFiltrarLocal = new Label();
            lblHistorial = new Label();
            tabPage3 = new TabPage();
            btnVerResumen = new Button();
            btnCerrarVista = new Button();
            pnlResumen = new Panel();
            rtbVistaResumen = new RichTextBox();
            lblResumenActa = new Label();
            pnlActasGeneradas = new Panel();
            btnBuscarActa = new Button();
            txtBuscarActa = new TextBox();
            lblBuscar = new Label();
            dgvActas = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewButtonColumn();
            lblTituloPanel = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            pnlAlertaContenedor.SuspendLayout();
            pnlAlertaCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlMonitor.SuspendLayout();
            pnlDatoslocal.SuspendLayout();
            tabPage2.SuspendLayout();
            pnlReincidencias.SuspendLayout();
            gbTotalFaltas.SuspendLayout();
            gbClausuras.SuspendLayout();
            gbAprobados.SuspendLayout();
            pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            tabPage3.SuspendLayout();
            pnlResumen.SuspendLayout();
            pnlActasGeneradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1019, 861);
            tabControl1.TabIndex = 5;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ActiveCaption;
            tabPage1.Controls.Add(btnClausurar);
            tabPage1.Controls.Add(btnGuardar);
            tabPage1.Controls.Add(pnlAlertaContenedor);
            tabPage1.Controls.Add(pnlMonitor);
            tabPage1.Controls.Add(pnlDatoslocal);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1011, 828);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ficha de Inspeccion";
            // 
            // btnClausurar
            // 
            btnClausurar.Anchor = AnchorStyles.Top;
            btnClausurar.BackColor = Color.FromArgb(200, 55, 55);
            btnClausurar.Font = new Font("Segoe UI", 10.8F);
            btnClausurar.Location = new Point(640, 627);
            btnClausurar.Name = "btnClausurar";
            btnClausurar.Size = new Size(187, 60);
            btnClausurar.TabIndex = 17;
            btnClausurar.Text = "Clausurar y generar acta";
            btnClausurar.UseVisualStyleBackColor = false;
            btnClausurar.Click += btnClausurar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.FromArgb(76, 126, 179);
            btnGuardar.Font = new Font("Segoe UI", 10.8F);
            btnGuardar.Location = new Point(408, 627);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 60);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar en repositorio";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pnlAlertaContenedor
            // 
            pnlAlertaContenedor.Anchor = AnchorStyles.Top;
            pnlAlertaContenedor.BackColor = Color.FromArgb(76, 126, 179);
            pnlAlertaContenedor.BorderStyle = BorderStyle.FixedSingle;
            pnlAlertaContenedor.Controls.Add(pnlAlertaCuerpo);
            pnlAlertaContenedor.Location = new Point(250, 693);
            pnlAlertaContenedor.Name = "pnlAlertaContenedor";
            pnlAlertaContenedor.Padding = new Padding(1);
            pnlAlertaContenedor.Size = new Size(518, 115);
            pnlAlertaContenedor.TabIndex = 14;
            pnlAlertaContenedor.Visible = false;
            // 
            // pnlAlertaCuerpo
            // 
            pnlAlertaCuerpo.BackColor = SystemColors.MenuBar;
            pnlAlertaCuerpo.Controls.Add(pictureBox3);
            pnlAlertaCuerpo.Controls.Add(lblAlertaTitulo);
            pnlAlertaCuerpo.Controls.Add(lblAlertaMensaje);
            pnlAlertaCuerpo.Location = new Point(4, 4);
            pnlAlertaCuerpo.Name = "pnlAlertaCuerpo";
            pnlAlertaCuerpo.Size = new Size(508, 105);
            pnlAlertaCuerpo.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(9, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 67);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblAlertaTitulo
            // 
            lblAlertaTitulo.AutoSize = true;
            lblAlertaTitulo.Location = new Point(73, 2);
            lblAlertaTitulo.Name = "lblAlertaTitulo";
            lblAlertaTitulo.Size = new Size(58, 20);
            lblAlertaTitulo.TabIndex = 1;
            lblAlertaTitulo.Text = "label11";
            // 
            // lblAlertaMensaje
            // 
            lblAlertaMensaje.Location = new Point(73, 22);
            lblAlertaMensaje.Name = "lblAlertaMensaje";
            lblAlertaMensaje.Size = new Size(409, 71);
            lblAlertaMensaje.TabIndex = 2;
            lblAlertaMensaje.Text = "label12";
            // 
            // pnlMonitor
            // 
            pnlMonitor.Anchor = AnchorStyles.Top;
            pnlMonitor.BackColor = SystemColors.MenuBar;
            pnlMonitor.Controls.Add(txtObservaciones);
            pnlMonitor.Controls.Add(lblTituloObservaciones);
            pnlMonitor.Controls.Add(chkBasureroTapa);
            pnlMonitor.Controls.Add(chkPermisoVigente);
            pnlMonitor.Controls.Add(chkPlagas);
            pnlMonitor.Controls.Add(chkPiso);
            pnlMonitor.Controls.Add(chkSuperficies);
            pnlMonitor.Controls.Add(chkCubreboca);
            pnlMonitor.Controls.Add(lblMonitor);
            pnlMonitor.Location = new Point(81, 322);
            pnlMonitor.Name = "pnlMonitor";
            pnlMonitor.Size = new Size(827, 296);
            pnlMonitor.TabIndex = 13;
            // 
            // txtObservaciones
            // 
            txtObservaciones.BorderStyle = BorderStyle.FixedSingle;
            txtObservaciones.Location = new Point(50, 177);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(741, 84);
            txtObservaciones.TabIndex = 8;
            // 
            // lblTituloObservaciones
            // 
            lblTituloObservaciones.AutoSize = true;
            lblTituloObservaciones.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloObservaciones.ForeColor = Color.Black;
            lblTituloObservaciones.Location = new Point(16, 149);
            lblTituloObservaciones.Name = "lblTituloObservaciones";
            lblTituloObservaciones.Size = new Size(142, 25);
            lblTituloObservaciones.TabIndex = 7;
            lblTituloObservaciones.Text = "Observaciones:";
            // 
            // chkBasureroTapa
            // 
            chkBasureroTapa.AutoSize = true;
            chkBasureroTapa.Checked = true;
            chkBasureroTapa.CheckState = CheckState.Checked;
            chkBasureroTapa.Font = new Font("Segoe UI", 10.8F);
            chkBasureroTapa.Location = new Point(559, 70);
            chkBasureroTapa.Name = "chkBasureroTapa";
            chkBasureroTapa.Size = new Size(177, 29);
            chkBasureroTapa.TabIndex = 6;
            chkBasureroTapa.Text = "Basurero con tapa";
            chkBasureroTapa.UseVisualStyleBackColor = true;
            // 
            // chkPermisoVigente
            // 
            chkPermisoVigente.AutoSize = true;
            chkPermisoVigente.Checked = true;
            chkPermisoVigente.CheckState = CheckState.Checked;
            chkPermisoVigente.Font = new Font("Segoe UI", 10.8F);
            chkPermisoVigente.Location = new Point(559, 32);
            chkPermisoVigente.Name = "chkPermisoVigente";
            chkPermisoVigente.Size = new Size(232, 29);
            chkPermisoVigente.TabIndex = 5;
            chkPermisoVigente.Text = "Permiso sanitario vigente";
            chkPermisoVigente.UseVisualStyleBackColor = true;
            // 
            // chkPlagas
            // 
            chkPlagas.AutoSize = true;
            chkPlagas.Checked = true;
            chkPlagas.CheckState = CheckState.Checked;
            chkPlagas.Font = new Font("Segoe UI", 10.8F);
            chkPlagas.ForeColor = Color.FromArgb(255, 128, 128);
            chkPlagas.Location = new Point(559, 108);
            chkPlagas.Name = "chkPlagas";
            chkPlagas.Size = new Size(244, 29);
            chkPlagas.TabIndex = 4;
            chkPlagas.Text = "Sin presencia de plagas⚠";
            chkPlagas.UseVisualStyleBackColor = true;
            chkPlagas.CheckedChanged += chkPlagas_CheckedChanged;
            // 
            // chkPiso
            // 
            chkPiso.AutoSize = true;
            chkPiso.Checked = true;
            chkPiso.CheckState = CheckState.Checked;
            chkPiso.Font = new Font("Segoe UI", 10.8F);
            chkPiso.ForeColor = Color.FromArgb(255, 128, 128);
            chkPiso.Location = new Point(50, 108);
            chkPiso.Name = "chkPiso";
            chkPiso.Size = new Size(251, 29);
            chkPiso.TabIndex = 3;
            chkPiso.Text = "Sin productos en el piso⚠";
            chkPiso.UseVisualStyleBackColor = true;
            chkPiso.CheckedChanged += chkPiso_CheckedChanged;
            // 
            // chkSuperficies
            // 
            chkSuperficies.AutoSize = true;
            chkSuperficies.Checked = true;
            chkSuperficies.CheckState = CheckState.Checked;
            chkSuperficies.Font = new Font("Segoe UI", 10.8F);
            chkSuperficies.Location = new Point(50, 73);
            chkSuperficies.Name = "chkSuperficies";
            chkSuperficies.Size = new Size(332, 29);
            chkSuperficies.TabIndex = 2;
            chkSuperficies.Text = "¿Alimentos en superficies aprobadas?";
            chkSuperficies.UseVisualStyleBackColor = true;
            chkSuperficies.CheckedChanged += chkSuperficies_CheckedChanged;
            // 
            // chkCubreboca
            // 
            chkCubreboca.AutoSize = true;
            chkCubreboca.Checked = true;
            chkCubreboca.CheckState = CheckState.Checked;
            chkCubreboca.Font = new Font("Segoe UI", 10.8F);
            chkCubreboca.Location = new Point(50, 32);
            chkCubreboca.Name = "chkCubreboca";
            chkCubreboca.Size = new Size(290, 29);
            chkCubreboca.TabIndex = 1;
            chkCubreboca.Text = "¿Manipuladores con cubreboca?";
            chkCubreboca.UseVisualStyleBackColor = true;
            // 
            // lblMonitor
            // 
            lblMonitor.BackColor = Color.FromArgb(76, 126, 179);
            lblMonitor.Dock = DockStyle.Top;
            lblMonitor.ForeColor = Color.White;
            lblMonitor.Location = new Point(0, 0);
            lblMonitor.Name = "lblMonitor";
            lblMonitor.Size = new Size(827, 20);
            lblMonitor.TabIndex = 0;
            lblMonitor.Text = "Monitor de Diagnostico";
            lblMonitor.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlDatoslocal
            // 
            pnlDatoslocal.Anchor = AnchorStyles.Top;
            pnlDatoslocal.BackColor = SystemColors.MenuBar;
            pnlDatoslocal.Controls.Add(txtInspector);
            pnlDatoslocal.Controls.Add(txtFechaInsp);
            pnlDatoslocal.Controls.Add(txtPropietario);
            pnlDatoslocal.Controls.Add(lblInspector);
            pnlDatoslocal.Controls.Add(lblFechaInsp);
            pnlDatoslocal.Controls.Add(lblPropietario);
            pnlDatoslocal.Controls.Add(txtId);
            pnlDatoslocal.Controls.Add(txtNombre);
            pnlDatoslocal.Controls.Add(cmbTipo);
            pnlDatoslocal.Controls.Add(lblTipo);
            pnlDatoslocal.Controls.Add(lblNombre);
            pnlDatoslocal.Controls.Add(lblIdLocal);
            pnlDatoslocal.Controls.Add(lblTituloficha);
            pnlDatoslocal.Location = new Point(81, 22);
            pnlDatoslocal.Name = "pnlDatoslocal";
            pnlDatoslocal.Size = new Size(827, 265);
            pnlDatoslocal.TabIndex = 12;
            // 
            // txtInspector
            // 
            txtInspector.Location = new Point(507, 179);
            txtInspector.Name = "txtInspector";
            txtInspector.Size = new Size(284, 27);
            txtInspector.TabIndex = 12;
            // 
            // txtFechaInsp
            // 
            txtFechaInsp.Location = new Point(507, 116);
            txtFechaInsp.Name = "txtFechaInsp";
            txtFechaInsp.Size = new Size(284, 27);
            txtFechaInsp.TabIndex = 11;
            // 
            // txtPropietario
            // 
            txtPropietario.Location = new Point(507, 52);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.Size = new Size(284, 27);
            txtPropietario.TabIndex = 10;
            // 
            // lblInspector
            // 
            lblInspector.AutoSize = true;
            lblInspector.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInspector.Location = new Point(411, 176);
            lblInspector.Name = "lblInspector";
            lblInspector.Size = new Size(90, 25);
            lblInspector.TabIndex = 9;
            lblInspector.Text = "Inspector:";
            // 
            // lblFechaInsp
            // 
            lblFechaInsp.AutoSize = true;
            lblFechaInsp.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaInsp.Location = new Point(401, 115);
            lblFechaInsp.Name = "lblFechaInsp";
            lblFechaInsp.Size = new Size(100, 25);
            lblFechaInsp.TabIndex = 8;
            lblFechaInsp.Text = "Fecha Insp:";
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPropietario.Location = new Point(398, 51);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(103, 25);
            lblPropietario.TabIndex = 7;
            lblPropietario.Text = "Propietario:";
            // 
            // txtId
            // 
            txtId.Location = new Point(101, 55);
            txtId.Name = "txtId";
            txtId.Size = new Size(284, 27);
            txtId.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 27);
            txtNombre.TabIndex = 5;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "LocalComercial", "PuestoAmbulante" });
            cmbTipo.Location = new Point(101, 176);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(284, 28);
            cmbTipo.TabIndex = 4;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(50, 176);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(51, 25);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(19, 115);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblIdLocal
            // 
            lblIdLocal.AutoSize = true;
            lblIdLocal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdLocal.Location = new Point(24, 55);
            lblIdLocal.Name = "lblIdLocal";
            lblIdLocal.Size = new Size(77, 25);
            lblIdLocal.TabIndex = 1;
            lblIdLocal.Text = "Id Local:";
            // 
            // lblTituloficha
            // 
            lblTituloficha.BackColor = Color.FromArgb(76, 126, 179);
            lblTituloficha.Dock = DockStyle.Top;
            lblTituloficha.ForeColor = Color.White;
            lblTituloficha.Location = new Point(0, 0);
            lblTituloficha.Name = "lblTituloficha";
            lblTituloficha.Size = new Size(827, 25);
            lblTituloficha.TabIndex = 0;
            lblTituloficha.Text = "Ficha de Inspeccion";
            lblTituloficha.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveCaption;
            tabPage2.Controls.Add(btnExportar);
            tabPage2.Controls.Add(btnLimpiar);
            tabPage2.Controls.Add(pnlReincidencias);
            tabPage2.Controls.Add(pnlHistorial);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1011, 828);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Historial/Reincidencias";
            tabPage2.Click += tabPage2_Click;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top;
            btnExportar.BackColor = Color.FromArgb(76, 126, 179);
            btnExportar.Font = new Font("Segoe UI", 10.8F);
            btnExportar.Location = new Point(656, 523);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(140, 64);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar registro a Excel";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top;
            btnLimpiar.BackColor = Color.FromArgb(219, 219, 219);
            btnLimpiar.Font = new Font("Segoe UI", 10.8F);
            btnLimpiar.Location = new Point(525, 541);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(114, 33);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar Filtros";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pnlReincidencias
            // 
            pnlReincidencias.Anchor = AnchorStyles.Top;
            pnlReincidencias.BackColor = SystemColors.MenuBar;
            pnlReincidencias.Controls.Add(gbTotalFaltas);
            pnlReincidencias.Controls.Add(gbClausuras);
            pnlReincidencias.Controls.Add(gbAprobados);
            pnlReincidencias.Controls.Add(lblResumen);
            pnlReincidencias.Location = new Point(220, 315);
            pnlReincidencias.Name = "pnlReincidencias";
            pnlReincidencias.Size = new Size(591, 186);
            pnlReincidencias.TabIndex = 1;
            // 
            // gbTotalFaltas
            // 
            gbTotalFaltas.BackColor = Color.FromArgb(219, 219, 219);
            gbTotalFaltas.Controls.Add(lblFaltas);
            gbTotalFaltas.Location = new Point(436, 40);
            gbTotalFaltas.Name = "gbTotalFaltas";
            gbTotalFaltas.Size = new Size(118, 113);
            gbTotalFaltas.TabIndex = 3;
            gbTotalFaltas.TabStop = false;
            gbTotalFaltas.Text = "Total faltas:";
            // 
            // lblFaltas
            // 
            lblFaltas.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFaltas.ForeColor = Color.FromArgb(76, 126, 179);
            lblFaltas.Location = new Point(23, 21);
            lblFaltas.Name = "lblFaltas";
            lblFaltas.Size = new Size(72, 71);
            lblFaltas.TabIndex = 1;
            lblFaltas.Text = "0";
            lblFaltas.TextAlign = ContentAlignment.MiddleCenter;
            lblFaltas.Click += lblFaltas_Click;
            // 
            // gbClausuras
            // 
            gbClausuras.BackColor = Color.FromArgb(219, 219, 219);
            gbClausuras.Controls.Add(lblClausuras);
            gbClausuras.Location = new Point(238, 40);
            gbClausuras.Name = "gbClausuras";
            gbClausuras.Size = new Size(118, 113);
            gbClausuras.TabIndex = 2;
            gbClausuras.TabStop = false;
            gbClausuras.Text = "Clausuras:";
            // 
            // lblClausuras
            // 
            lblClausuras.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClausuras.ForeColor = Color.FromArgb(200, 55, 55);
            lblClausuras.Location = new Point(23, 21);
            lblClausuras.Name = "lblClausuras";
            lblClausuras.Size = new Size(72, 71);
            lblClausuras.TabIndex = 1;
            lblClausuras.Text = "0";
            lblClausuras.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbAprobados
            // 
            gbAprobados.BackColor = Color.FromArgb(219, 219, 219);
            gbAprobados.Controls.Add(lblAprobados);
            gbAprobados.Location = new Point(31, 40);
            gbAprobados.Name = "gbAprobados";
            gbAprobados.Size = new Size(118, 113);
            gbAprobados.TabIndex = 1;
            gbAprobados.TabStop = false;
            gbAprobados.Text = "Aprobados:";
            // 
            // lblAprobados
            // 
            lblAprobados.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAprobados.Location = new Point(24, 23);
            lblAprobados.Name = "lblAprobados";
            lblAprobados.Size = new Size(72, 71);
            lblAprobados.TabIndex = 0;
            lblAprobados.Text = "0";
            lblAprobados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResumen
            // 
            lblResumen.BackColor = Color.FromArgb(76, 126, 179);
            lblResumen.Dock = DockStyle.Top;
            lblResumen.ForeColor = Color.White;
            lblResumen.Location = new Point(0, 0);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(591, 20);
            lblResumen.TabIndex = 0;
            lblResumen.Text = "Resumen de Reincidencias";
            lblResumen.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlHistorial
            // 
            pnlHistorial.Anchor = AnchorStyles.Top;
            pnlHistorial.BackColor = SystemColors.MenuBar;
            pnlHistorial.Controls.Add(dgvHistorial);
            pnlHistorial.Controls.Add(btnBuscarHistorial);
            pnlHistorial.Controls.Add(cmbFiltroEstado);
            pnlHistorial.Controls.Add(lblEstado);
            pnlHistorial.Controls.Add(cmbFiltroLocal);
            pnlHistorial.Controls.Add(lblFiltrarLocal);
            pnlHistorial.Controls.Add(lblHistorial);
            pnlHistorial.Location = new Point(90, 28);
            pnlHistorial.Name = "pnlHistorial";
            pnlHistorial.Size = new Size(827, 265);
            pnlHistorial.TabIndex = 0;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = SystemColors.MenuBar;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(76, 126, 179);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.Location = new Point(0, 66);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(827, 199);
            dgvHistorial.TabIndex = 6;
            dgvHistorial.CellClick += dgvHistorial_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Fecha";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Falta Critica:";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Estado Resultante:";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Acta Generada";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Accion";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Text = "Ver";
            Column5.UseColumnTextForButtonValue = true;
            // 
            // btnBuscarHistorial
            // 
            btnBuscarHistorial.BackgroundImage = (Image)resources.GetObject("btnBuscarHistorial.BackgroundImage");
            btnBuscarHistorial.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscarHistorial.Location = new Point(747, 32);
            btnBuscarHistorial.Name = "btnBuscarHistorial";
            btnBuscarHistorial.Size = new Size(44, 29);
            btnBuscarHistorial.TabIndex = 5;
            btnBuscarHistorial.UseVisualStyleBackColor = true;
            btnBuscarHistorial.Click += btnBuscarHistorial_Click;
            // 
            // cmbFiltroEstado
            // 
            cmbFiltroEstado.FormattingEnabled = true;
            cmbFiltroEstado.Location = new Point(488, 33);
            cmbFiltroEstado.Name = "cmbFiltroEstado";
            cmbFiltroEstado.Size = new Size(233, 28);
            cmbFiltroEstado.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(412, 31);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(70, 25);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado:";
            // 
            // cmbFiltroLocal
            // 
            cmbFiltroLocal.FormattingEnabled = true;
            cmbFiltroLocal.Location = new Point(163, 32);
            cmbFiltroLocal.Name = "cmbFiltroLocal";
            cmbFiltroLocal.Size = new Size(233, 28);
            cmbFiltroLocal.TabIndex = 2;
            // 
            // lblFiltrarLocal
            // 
            lblFiltrarLocal.AutoSize = true;
            lblFiltrarLocal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFiltrarLocal.ForeColor = SystemColors.ControlText;
            lblFiltrarLocal.Location = new Point(56, 33);
            lblFiltrarLocal.Name = "lblFiltrarLocal";
            lblFiltrarLocal.Size = new Size(101, 25);
            lblFiltrarLocal.TabIndex = 1;
            lblFiltrarLocal.Text = "Filtrar local:";
            // 
            // lblHistorial
            // 
            lblHistorial.BackColor = Color.FromArgb(76, 126, 179);
            lblHistorial.Dock = DockStyle.Top;
            lblHistorial.ForeColor = Color.White;
            lblHistorial.Location = new Point(0, 0);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(827, 25);
            lblHistorial.TabIndex = 0;
            lblHistorial.Text = "Historial de Reincidencias";
            lblHistorial.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ActiveCaption;
            tabPage3.Controls.Add(btnVerResumen);
            tabPage3.Controls.Add(btnCerrarVista);
            tabPage3.Controls.Add(pnlResumen);
            tabPage3.Controls.Add(pnlActasGeneradas);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1011, 828);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Actas Generadas";
            tabPage3.Click += tabPage3_Click;
            // 
            // btnVerResumen
            // 
            btnVerResumen.Anchor = AnchorStyles.Top;
            btnVerResumen.BackColor = Color.FromArgb(76, 126, 179);
            btnVerResumen.Font = new Font("Segoe UI", 10.8F);
            btnVerResumen.Location = new Point(705, 744);
            btnVerResumen.Name = "btnVerResumen";
            btnVerResumen.Size = new Size(136, 51);
            btnVerResumen.TabIndex = 3;
            btnVerResumen.Text = "Ver Resumen";
            btnVerResumen.UseVisualStyleBackColor = false;
            btnVerResumen.Click += btnVerResumen_Click;
            // 
            // btnCerrarVista
            // 
            btnCerrarVista.Anchor = AnchorStyles.Top;
            btnCerrarVista.BackColor = Color.FromArgb(219, 219, 219);
            btnCerrarVista.Font = new Font("Segoe UI", 10.8F);
            btnCerrarVista.Location = new Point(514, 744);
            btnCerrarVista.Name = "btnCerrarVista";
            btnCerrarVista.Size = new Size(175, 51);
            btnCerrarVista.TabIndex = 2;
            btnCerrarVista.Text = "CerrarResumen";
            btnCerrarVista.UseVisualStyleBackColor = false;
            btnCerrarVista.Click += btnCerrarVista_Click;
            // 
            // pnlResumen
            // 
            pnlResumen.Anchor = AnchorStyles.Top;
            pnlResumen.BackColor = SystemColors.MenuBar;
            pnlResumen.Controls.Add(rtbVistaResumen);
            pnlResumen.Controls.Add(lblResumenActa);
            pnlResumen.Location = new Point(168, 321);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Size = new Size(663, 388);
            pnlResumen.TabIndex = 1;
            // 
            // rtbVistaResumen
            // 
            rtbVistaResumen.Anchor = AnchorStyles.None;
            rtbVistaResumen.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbVistaResumen.Location = new Point(39, 29);
            rtbVistaResumen.Name = "rtbVistaResumen";
            rtbVistaResumen.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtbVistaResumen.Size = new Size(578, 348);
            rtbVistaResumen.TabIndex = 1;
            rtbVistaResumen.Text = "";
            // 
            // lblResumenActa
            // 
            lblResumenActa.BackColor = Color.FromArgb(76, 126, 179);
            lblResumenActa.Dock = DockStyle.Top;
            lblResumenActa.ForeColor = Color.White;
            lblResumenActa.Location = new Point(0, 0);
            lblResumenActa.Name = "lblResumenActa";
            lblResumenActa.Size = new Size(663, 25);
            lblResumenActa.TabIndex = 0;
            lblResumenActa.Text = "Resumen del acta:";
            lblResumenActa.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlActasGeneradas
            // 
            pnlActasGeneradas.Anchor = AnchorStyles.Top;
            pnlActasGeneradas.BackColor = SystemColors.MenuBar;
            pnlActasGeneradas.Controls.Add(btnBuscarActa);
            pnlActasGeneradas.Controls.Add(txtBuscarActa);
            pnlActasGeneradas.Controls.Add(lblBuscar);
            pnlActasGeneradas.Controls.Add(dgvActas);
            pnlActasGeneradas.Controls.Add(lblTituloPanel);
            pnlActasGeneradas.Location = new Point(80, 41);
            pnlActasGeneradas.Name = "pnlActasGeneradas";
            pnlActasGeneradas.Size = new Size(827, 265);
            pnlActasGeneradas.TabIndex = 0;
            // 
            // btnBuscarActa
            // 
            btnBuscarActa.BackColor = Color.FromArgb(76, 126, 179);
            btnBuscarActa.Location = new Point(629, 29);
            btnBuscarActa.Name = "btnBuscarActa";
            btnBuscarActa.Size = new Size(80, 29);
            btnBuscarActa.TabIndex = 4;
            btnBuscarActa.Text = "Buscar";
            btnBuscarActa.UseVisualStyleBackColor = false;
            btnBuscarActa.Click += btnBuscarActa_Click;
            // 
            // txtBuscarActa
            // 
            txtBuscarActa.Location = new Point(203, 29);
            txtBuscarActa.Name = "txtBuscarActa";
            txtBuscarActa.Size = new Size(406, 27);
            txtBuscarActa.TabIndex = 3;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(98, 27);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(107, 25);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar Acta:";
            // 
            // dgvActas
            // 
            dgvActas.AllowUserToAddRows = false;
            dgvActas.AllowUserToResizeColumns = false;
            dgvActas.AllowUserToResizeRows = false;
            dgvActas.BackgroundColor = SystemColors.MenuBar;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(76, 126, 179);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(76, 126, 179);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvActas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvActas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActas.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column10 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvActas.DefaultCellStyle = dataGridViewCellStyle7;
            dgvActas.EnableHeadersVisualStyles = false;
            dgvActas.Location = new Point(-3, 65);
            dgvActas.MultiSelect = false;
            dgvActas.Name = "dgvActas";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvActas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvActas.RowHeadersVisible = false;
            dgvActas.RowHeadersWidth = 51;
            dgvActas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActas.Size = new Size(827, 200);
            dgvActas.TabIndex = 1;
            dgvActas.CellClick += dgvActas_CellClick;
            dgvActas.CellContentClick += dgvActas_CellContentClick;
            // 
            // Column6
            // 
            Column6.HeaderText = "Archivo";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 260;
            // 
            // Column7
            // 
            Column7.HeaderText = "Local";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 170;
            // 
            // Column8
            // 
            Column8.HeaderText = "Motivo";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 170;
            // 
            // Column9
            // 
            Column9.FillWeight = 21.4790268F;
            Column9.HeaderText = "Fecha";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 128;
            // 
            // Column10
            // 
            Column10.HeaderText = "Accion";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Resizable = DataGridViewTriState.True;
            Column10.SortMode = DataGridViewColumnSortMode.Automatic;
            Column10.Text = "Ver";
            Column10.UseColumnTextForButtonValue = true;
            Column10.Width = 115;
            // 
            // lblTituloPanel
            // 
            lblTituloPanel.BackColor = Color.FromArgb(76, 126, 179);
            lblTituloPanel.Dock = DockStyle.Top;
            lblTituloPanel.ForeColor = Color.White;
            lblTituloPanel.Location = new Point(0, 0);
            lblTituloPanel.Name = "lblTituloPanel";
            lblTituloPanel.Size = new Size(827, 23);
            lblTituloPanel.TabIndex = 0;
            lblTituloPanel.Text = "Actas Generadas";
            lblTituloPanel.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormInspeccion
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1019, 861);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInspeccion";
            StartPosition = FormStartPosition.Manual;
            Text = "FormInspeccion";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pnlAlertaContenedor.ResumeLayout(false);
            pnlAlertaCuerpo.ResumeLayout(false);
            pnlAlertaCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlMonitor.ResumeLayout(false);
            pnlMonitor.PerformLayout();
            pnlDatoslocal.ResumeLayout(false);
            pnlDatoslocal.PerformLayout();
            tabPage2.ResumeLayout(false);
            pnlReincidencias.ResumeLayout(false);
            gbTotalFaltas.ResumeLayout(false);
            gbClausuras.ResumeLayout(false);
            gbAprobados.ResumeLayout(false);
            pnlHistorial.ResumeLayout(false);
            pnlHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            tabPage3.ResumeLayout(false);
            pnlResumen.ResumeLayout(false);
            pnlActasGeneradas.ResumeLayout(false);
            pnlActasGeneradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnExportar;
        private Button btnLimpiar;
        private Panel pnlReincidencias;
        private GroupBox gbTotalFaltas;
        private Label lblFaltas;
        private GroupBox gbClausuras;
        private Label lblClausuras;
        private GroupBox gbAprobados;
        private Label lblAprobados;
        private Label lblResumen;
        private Panel pnlHistorial;
        private DataGridView dgvHistorial;
        private Button btnBuscarHistorial;
        private ComboBox cmbFiltroEstado;
        private Label lblEstado;
        private ComboBox cmbFiltroLocal;
        private Label lblFiltrarLocal;
        private Label lblHistorial;
        private TabPage tabPage3;
        private Panel pnlActasGeneradas;
        private Button btnBuscarActa;
        private TextBox txtBuscarActa;
        private Label lblBuscar;
        private DataGridView dgvActas;
        private Label lblTituloPanel;
        private Panel pnlResumen;
        private Label lblResumenActa;
        private Button btnVerResumen;
        private Button btnCerrarVista;
        private RichTextBox rtbVistaResumen;
        private Button btnClausurar;
        private Button btnGuardar;
        private Panel pnlAlertaContenedor;
        private Panel pnlAlertaCuerpo;
        private PictureBox pictureBox3;
        private Label lblAlertaTitulo;
        private Label lblAlertaMensaje;
        private Panel pnlMonitor;
        private TextBox txtObservaciones;
        private Label lblTituloObservaciones;
        private CheckBox chkBasureroTapa;
        private CheckBox chkPermisoVigente;
        private CheckBox chkPlagas;
        private CheckBox chkPiso;
        private CheckBox chkSuperficies;
        private CheckBox chkCubreboca;
        private Label lblMonitor;
        private Panel pnlDatoslocal;
        private TextBox txtInspector;
        private TextBox txtFechaInsp;
        private TextBox txtPropietario;
        private Label lblInspector;
        private Label lblFechaInsp;
        private Label lblPropietario;
        private TextBox txtId;
        private TextBox txtNombre;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private Label lblNombre;
        private Label lblIdLocal;
        private Label lblTituloficha;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewButtonColumn Column10;
    }
}