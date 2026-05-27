using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

namespace sistemaSanitario
{
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            lblFechaReporte.Text = DateTime.Now.ToString("dd MMM yyyy").ToUpper();
            lblMercado.Text = "Mercado Pino Suarez";
            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            var todos = Form1.Repositorio.ObtenerTodos();

            // 1. GRÁFICO DE PASTEL 
            int aprobados = todos.Count(l => l.Estado == "Aprobado");
            int conFaltas = todos.Count(l => l.Estado == "Con faltas");
            int clausurados = todos.Count(l => l.Estado == "CLAUSURADO");

            ConfigurarGraficoPastel(aprobados, conFaltas, clausurados);

            // 2. BARRAS DE PROGRESO 
            var localesUnicos = todos.GroupBy(l => l.IdLocal).Select(g => g.First()).ToList();

            int totalUnicos = localesUnicos.Count;

            // Contamos cuántos hay de cada tipo en esa lista sin repeticiones
            int locales = localesUnicos.Count(l => l.ObtenerTipo() == "LocalComercial");
            int puestos = localesUnicos.Count(l => l.ObtenerTipo() == "PuestoAmbulante");

            pbLocalComercial.Maximum = 100;
            pbPuestoAmbulante.Maximum = 100;
            if (totalUnicos > 0)
            {
                pbLocalComercial.Value = (locales * 100) / totalUnicos;
                pbPuestoAmbulante.Value = (puestos * 100) / totalUnicos;
            }
            else
            {
                pbLocalComercial.Value = 0;
                pbPuestoAmbulante.Value = 0;
            }

            lblContadorL.Text = locales.ToString();
            lblContadorP.Text = puestos.ToString();
        }

        private void ConfigurarGraficoPastel(int aprobados, int conFaltas, int clausurados)
        {
            int total = aprobados + conFaltas + clausurados;

            chartPastel.Series.Clear();
            chartPastel.ChartAreas.Clear();
            chartPastel.Legends.Clear();

            ChartArea area = new ChartArea();
            area.BackColor = Color.Transparent;
            chartPastel.ChartAreas.Add(area);

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = false;
            serie["PieLabelStyle"] = "Outside";
            serie["PieLineColor"] = "Black";

            if (total == 0)
            {
                //Mostrar gráfico vacío
                serie.Points.AddXY("Sin datos", 1);
                serie.Points[0].Color = Color.LightGray;
                serie.Points[0].Label = "Sin datos";
                serie.Points[0].LegendText = "Sin datos";
            }
            else
            {
                serie.Points.AddXY("Aprobados", aprobados);
                serie.Points[0].Color = Color.FromArgb(46, 125, 50);
                serie.Points[0].LegendText = $"Aprobados ({aprobados})";
                serie.Points[0].Label = $"{aprobados * 100 / total}%";

                serie.Points.AddXY("Con faltas", conFaltas);
                serie.Points[1].Color = Color.FromArgb(230, 81, 0);
                serie.Points[1].LegendText = $"Con faltas ({conFaltas})";
                serie.Points[1].Label = $"{conFaltas * 100 / total}%";

                serie.Points.AddXY("Clausurados", clausurados);
                serie.Points[2].Color = Color.FromArgb(183, 28, 28);
                serie.Points[2].LegendText = $"Clausurados ({clausurados})";
                serie.Points[2].Label = $"{clausurados * 100 / total}%";
            }

            chartPastel.Series.Add(serie);

            Legend leyenda = new Legend();
            leyenda.Docking = Docking.Bottom;
            leyenda.Font = new Font("Segoe UI", 9f);
            leyenda.BackColor = Color.Transparent;
            chartPastel.Legends.Add(leyenda);

            chartPastel.BackColor = Color.Transparent;
            chartPastel.BorderlineColor = Color.Transparent;
        }
        //SIN USO
        private void lblFechaReporte_Click(object sender, EventArgs e){}
    }
}