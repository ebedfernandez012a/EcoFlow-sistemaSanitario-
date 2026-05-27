namespace sistemaSanitario
{
    partial class FormEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisticas));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pictureBox1 = new PictureBox();
            lblResumenTitulo = new Label();
            lblMercado = new Label();
            gbBarras = new GroupBox();
            lblContadorP = new Label();
            lblContadorL = new Label();
            pbPuestoAmbulante = new ProgressBar();
            pbLocalComercial = new ProgressBar();
            lblPuesto = new Label();
            lblLocal = new Label();
            lblFechaReporte = new Label();
            chartPastel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPastel).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 77);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblResumenTitulo
            // 
            lblResumenTitulo.AutoSize = true;
            lblResumenTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumenTitulo.ForeColor = Color.Black;
            lblResumenTitulo.Location = new Point(109, 21);
            lblResumenTitulo.Name = "lblResumenTitulo";
            lblResumenTitulo.Size = new Size(285, 31);
            lblResumenTitulo.TabIndex = 1;
            lblResumenTitulo.Text = "Resumen de Inspecciones";
            // 
            // lblMercado
            // 
            lblMercado.AutoSize = true;
            lblMercado.Location = new Point(109, 61);
            lblMercado.Name = "lblMercado";
            lblMercado.Size = new Size(163, 20);
            lblMercado.TabIndex = 2;
            lblMercado.Text = "Mercado Pino Suarez - ";
            // 
            // gbBarras
            // 
            gbBarras.Controls.Add(lblContadorP);
            gbBarras.Controls.Add(lblContadorL);
            gbBarras.Controls.Add(pbPuestoAmbulante);
            gbBarras.Controls.Add(pbLocalComercial);
            gbBarras.Controls.Add(lblPuesto);
            gbBarras.Controls.Add(lblLocal);
            gbBarras.Location = new Point(16, 385);
            gbBarras.Name = "gbBarras";
            gbBarras.Size = new Size(551, 144);
            gbBarras.TabIndex = 8;
            gbBarras.TabStop = false;
            gbBarras.Text = "Distribucion Por Tipo";
            // 
            // lblContadorP
            // 
            lblContadorP.Location = new Point(499, 100);
            lblContadorP.Name = "lblContadorP";
            lblContadorP.Size = new Size(16, 25);
            lblContadorP.TabIndex = 5;
            lblContadorP.Text = "0";
            // 
            // lblContadorL
            // 
            lblContadorL.Location = new Point(499, 35);
            lblContadorL.Name = "lblContadorL";
            lblContadorL.Size = new Size(16, 25);
            lblContadorL.TabIndex = 4;
            lblContadorL.Text = "0";
            // 
            // pbPuestoAmbulante
            // 
            pbPuestoAmbulante.Location = new Point(160, 96);
            pbPuestoAmbulante.Name = "pbPuestoAmbulante";
            pbPuestoAmbulante.Size = new Size(333, 29);
            pbPuestoAmbulante.TabIndex = 3;
            // 
            // pbLocalComercial
            // 
            pbLocalComercial.Location = new Point(160, 31);
            pbLocalComercial.Name = "pbLocalComercial";
            pbLocalComercial.Size = new Size(333, 29);
            pbLocalComercial.TabIndex = 2;
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(10, 100);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(144, 20);
            lblPuesto.TabIndex = 1;
            lblPuesto.Text = "Puesto Ambulante - ";
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Location = new Point(29, 34);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(125, 20);
            lblLocal.TabIndex = 0;
            lblLocal.Text = "Local Comercial -";
            // 
            // lblFechaReporte
            // 
            lblFechaReporte.AutoSize = true;
            lblFechaReporte.Location = new Point(273, 61);
            lblFechaReporte.Name = "lblFechaReporte";
            lblFechaReporte.Size = new Size(50, 20);
            lblFechaReporte.TabIndex = 10;
            lblFechaReporte.Text = "label7";
            lblFechaReporte.Click += lblFechaReporte_Click;
            // 
            // chartPastel
            // 
            chartArea1.Name = "ChartArea1";
            chartPastel.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartPastel.Legends.Add(legend1);
            chartPastel.Location = new Point(109, 123);
            chartPastel.Name = "chartPastel";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPastel.Series.Add(series1);
            chartPastel.Size = new Size(400, 220);
            chartPastel.TabIndex = 11;
            chartPastel.Text = "chart1";
            // 
            // FormEstadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(588, 544);
            Controls.Add(chartPastel);
            Controls.Add(lblFechaReporte);
            Controls.Add(gbBarras);
            Controls.Add(lblMercado);
            Controls.Add(lblResumenTitulo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormEstadisticas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Estadísticas del día ";
            Load += FormEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbBarras.ResumeLayout(false);
            gbBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartPastel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblResumenTitulo;
        private Label lblMercado;
        private GroupBox gbBarras;
        private Label lblPuesto;
        private Label lblLocal;
        private ProgressBar pbPuestoAmbulante;
        private ProgressBar pbLocalComercial;
        private Label lblContadorP;
        private Label lblContadorL;
        private Label lblFechaReporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPastel;
    }
}