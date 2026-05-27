namespace sistemaSanitario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlTitulo = new Panel();
            lblFechaHora = new Label();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            ReinspeccionarToolStripMenuItem = new ToolStripMenuItem();
            LimpiarToolStripMenuItem1 = new ToolStripMenuItem();
            borrarLocalToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem2 = new ToolStripMenuItem();
            repositorioToolStripMenuItem = new ToolStripMenuItem();
            limpiarRepositorioClearToolStripMenuItem = new ToolStripMenuItem();
            herramientasToolStripMenuItem = new ToolStripMenuItem();
            generarReporteDelDiaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            pnlHeader = new Panel();
            pnlToolbar = new Panel();
            pictureBox4 = new PictureBox();
            lblMercado = new Label();
            btnHistorial = new Button();
            btnGenerarActa = new Button();
            btnNuevoLocal = new Button();
            pnlSidebar = new Panel();
            pnlFooter = new Panel();
            lblContador = new Label();
            pnlListaLocales = new Panel();
            lblEstablemientos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlSidebar.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(47, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(361, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema de Vigilancia Sanitaria Municipal";
            // 
            // pnlTitulo
            // 
            pnlTitulo.AutoSize = true;
            pnlTitulo.BackColor = Color.FromArgb(76, 126, 179);
            pnlTitulo.Controls.Add(lblFechaHora);
            pnlTitulo.Controls.Add(pictureBox2);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Controls.Add(pictureBox1);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(895, 37);
            pnlTitulo.TabIndex = 0;
            // 
            // lblFechaHora
            // 
            lblFechaHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaHora.Location = new Point(696, 10);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(51, 20);
            lblFechaHora.TabIndex = 4;
            lblFechaHora.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(659, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(239, 239, 239);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, repositorioToolStripMenuItem, herramientasToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 37);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(895, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.BackColor = Color.FromArgb(239, 239, 239);
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ReinspeccionarToolStripMenuItem, LimpiarToolStripMenuItem1, borrarLocalToolStripMenuItem, salirToolStripMenuItem2 });
            archivoToolStripMenuItem.Image = (Image)resources.GetObject("archivoToolStripMenuItem.Image");
            archivoToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(93, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // ReinspeccionarToolStripMenuItem
            // 
            ReinspeccionarToolStripMenuItem.Image = (Image)resources.GetObject("ReinspeccionarToolStripMenuItem.Image");
            ReinspeccionarToolStripMenuItem.Name = "ReinspeccionarToolStripMenuItem";
            ReinspeccionarToolStripMenuItem.Size = new Size(224, 26);
            ReinspeccionarToolStripMenuItem.Text = "Reinspeccionar";
            ReinspeccionarToolStripMenuItem.Click += ReinspeccionarToolStripMenuItem_Click;
            // 
            // LimpiarToolStripMenuItem1
            // 
            LimpiarToolStripMenuItem1.Image = (Image)resources.GetObject("LimpiarToolStripMenuItem1.Image");
            LimpiarToolStripMenuItem1.Name = "LimpiarToolStripMenuItem1";
            LimpiarToolStripMenuItem1.Size = new Size(224, 26);
            LimpiarToolStripMenuItem1.Text = "Limpiar Campos";
            LimpiarToolStripMenuItem1.Click += LimpiarToolStripMenuItem1_Click;
            // 
            // borrarLocalToolStripMenuItem
            // 
            borrarLocalToolStripMenuItem.ForeColor = Color.Red;
            borrarLocalToolStripMenuItem.Image = (Image)resources.GetObject("borrarLocalToolStripMenuItem.Image");
            borrarLocalToolStripMenuItem.Name = "borrarLocalToolStripMenuItem";
            borrarLocalToolStripMenuItem.Size = new Size(224, 26);
            borrarLocalToolStripMenuItem.Text = "Borrar Local";
            borrarLocalToolStripMenuItem.Click += borrarLocalToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem2
            // 
            salirToolStripMenuItem2.ForeColor = Color.Red;
            salirToolStripMenuItem2.Image = (Image)resources.GetObject("salirToolStripMenuItem2.Image");
            salirToolStripMenuItem2.ImageAlign = ContentAlignment.MiddleLeft;
            salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            salirToolStripMenuItem2.Size = new Size(224, 26);
            salirToolStripMenuItem2.Text = "Salir";
            salirToolStripMenuItem2.Click += salirToolStripMenuItem2_Click;
            // 
            // repositorioToolStripMenuItem
            // 
            repositorioToolStripMenuItem.BackColor = Color.FromArgb(239, 239, 239);
            repositorioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { limpiarRepositorioClearToolStripMenuItem });
            repositorioToolStripMenuItem.Image = (Image)resources.GetObject("repositorioToolStripMenuItem.Image");
            repositorioToolStripMenuItem.Name = "repositorioToolStripMenuItem";
            repositorioToolStripMenuItem.Size = new Size(120, 24);
            repositorioToolStripMenuItem.Text = "Repositorio";
            // 
            // limpiarRepositorioClearToolStripMenuItem
            // 
            limpiarRepositorioClearToolStripMenuItem.Image = (Image)resources.GetObject("limpiarRepositorioClearToolStripMenuItem.Image");
            limpiarRepositorioClearToolStripMenuItem.Name = "limpiarRepositorioClearToolStripMenuItem";
            limpiarRepositorioClearToolStripMenuItem.Size = new Size(267, 26);
            limpiarRepositorioClearToolStripMenuItem.Text = "Limpiar Repositorio(Clear)";
            limpiarRepositorioClearToolStripMenuItem.Click += limpiarRepositorioClearToolStripMenuItem_Click;
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarReporteDelDiaToolStripMenuItem });
            herramientasToolStripMenuItem.Image = (Image)resources.GetObject("herramientasToolStripMenuItem.Image");
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Size = new Size(132, 24);
            herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // generarReporteDelDiaToolStripMenuItem
            // 
            generarReporteDelDiaToolStripMenuItem.Image = (Image)resources.GetObject("generarReporteDelDiaToolStripMenuItem.Image");
            generarReporteDelDiaToolStripMenuItem.Name = "generarReporteDelDiaToolStripMenuItem";
            generarReporteDelDiaToolStripMenuItem.Size = new Size(247, 26);
            generarReporteDelDiaToolStripMenuItem.Text = "Generar reporte del dia";
            generarReporteDelDiaToolStripMenuItem.Click += generarReporteDelDiaToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDelSistemaToolStripMenuItem });
            ayudaToolStripMenuItem.Image = (Image)resources.GetObject("ayudaToolStripMenuItem.Image");
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(85, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDelSistemaToolStripMenuItem
            // 
            acercaDelSistemaToolStripMenuItem.Image = (Image)resources.GetObject("acercaDelSistemaToolStripMenuItem.Image");
            acercaDelSistemaToolStripMenuItem.Name = "acercaDelSistemaToolStripMenuItem";
            acercaDelSistemaToolStripMenuItem.Size = new Size(224, 26);
            acercaDelSistemaToolStripMenuItem.Text = "Acerca del sistema";
            acercaDelSistemaToolStripMenuItem.Click += acercaDelSistemaToolStripMenuItem_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(239, 239, 239);
            pnlHeader.Controls.Add(pnlTitulo);
            pnlHeader.Controls.Add(menuStrip1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(895, 65);
            pnlHeader.TabIndex = 6;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.FromArgb(246, 247, 249);
            pnlToolbar.Controls.Add(pictureBox4);
            pnlToolbar.Controls.Add(lblMercado);
            pnlToolbar.Controls.Add(btnHistorial);
            pnlToolbar.Controls.Add(btnGenerarActa);
            pnlToolbar.Controls.Add(btnNuevoLocal);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 65);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(895, 82);
            pnlToolbar.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(634, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 41);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // lblMercado
            // 
            lblMercado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMercado.AutoSize = true;
            lblMercado.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMercado.Location = new Point(684, 28);
            lblMercado.Name = "lblMercado";
            lblMercado.Size = new Size(208, 25);
            lblMercado.TabIndex = 3;
            lblMercado.Text = "| Mercado Pino Suarez \r\n";
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(76, 126, 179);
            btnHistorial.Location = new Point(281, 8);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(94, 61);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnGenerarActa
            // 
            btnGenerarActa.BackColor = Color.FromArgb(219, 219, 219);
            btnGenerarActa.Location = new Point(147, 8);
            btnGenerarActa.Name = "btnGenerarActa";
            btnGenerarActa.Size = new Size(94, 61);
            btnGenerarActa.TabIndex = 1;
            btnGenerarActa.Text = "Generar Acta .docx";
            btnGenerarActa.UseVisualStyleBackColor = false;
            btnGenerarActa.Click += btnGenerarActa_Click;
            // 
            // btnNuevoLocal
            // 
            btnNuevoLocal.BackColor = Color.FromArgb(83, 169, 96);
            btnNuevoLocal.Location = new Point(12, 8);
            btnNuevoLocal.Name = "btnNuevoLocal";
            btnNuevoLocal.Size = new Size(94, 61);
            btnNuevoLocal.TabIndex = 0;
            btnNuevoLocal.Text = "+Nueva Local";
            btnNuevoLocal.UseVisualStyleBackColor = false;
            btnNuevoLocal.Click += btnNuevoLocal_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(pnlFooter);
            pnlSidebar.Controls.Add(pnlListaLocales);
            pnlSidebar.Controls.Add(lblEstablemientos);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 147);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 686);
            pnlSidebar.TabIndex = 3;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(224, 224, 224);
            pnlFooter.Controls.Add(lblContador);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 650);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(250, 36);
            pnlFooter.TabIndex = 1;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(12, 7);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(169, 20);
            lblContador.TabIndex = 0;
            lblContador.Text = "En memoria: 0 Registros";
            // 
            // pnlListaLocales
            // 
            pnlListaLocales.BackColor = Color.White;
            pnlListaLocales.Dock = DockStyle.Fill;
            pnlListaLocales.Location = new Point(0, 25);
            pnlListaLocales.Name = "pnlListaLocales";
            pnlListaLocales.Size = new Size(250, 661);
            pnlListaLocales.TabIndex = 2;
            // 
            // lblEstablemientos
            // 
            lblEstablemientos.BackColor = Color.FromArgb(76, 126, 179);
            lblEstablemientos.Dock = DockStyle.Top;
            lblEstablemientos.Location = new Point(0, 0);
            lblEstablemientos.Name = "lblEstablemientos";
            lblEstablemientos.Size = new Size(250, 25);
            lblEstablemientos.TabIndex = 10;
            lblEstablemientos.Text = "Establecimientos";
            lblEstablemientos.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(895, 833);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlTitulo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem ReinspeccionarToolStripMenuItem;
        private ToolStripMenuItem LimpiarToolStripMenuItem1;
        private ToolStripMenuItem repositorioToolStripMenuItem;
        private ToolStripMenuItem limpiarRepositorioClearToolStripMenuItem;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem generarReporteDelDiaToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDelSistemaToolStripMenuItem;
        private PictureBox pictureBox2;
        private ToolStripMenuItem salirToolStripMenuItem2;
        private Panel pnlHeader;
        private Panel pnlToolbar;
        private PictureBox pictureBox4;
        private Label lblMercado;
        private Button btnHistorial;
        private Button btnGenerarActa;
        private Button btnNuevoLocal;
        private Panel pnlSidebar;
        private Panel pnlListaLocales;
        private Panel pnlFooter;
        private Label lblContador;
        private Label lblEstablemientos;
        private Label lblFechaHora;
        private ToolStripMenuItem borrarLocalToolStripMenuItem;
    }
}
