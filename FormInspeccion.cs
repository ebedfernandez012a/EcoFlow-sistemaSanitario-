using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace sistemaSanitario
{
    public partial class FormInspeccion : Form
    {
        private int contadorFolios = 992;
        private bool modoReinspeccion = false;
        private string idLocalReinspeccion = null;

        public FormInspeccion()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private void FormInspeccion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlAlertaContenedor.Visible = false;
            CentrarPaneles();
            ActualizarCombosHistorial();
            pnlResumen.Visible = false;

            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("LocalComercial");
            cmbTipo.Items.Add("PuestoAmbulante");
        }

        private void FormInspeccion_Resize(object sender, EventArgs e)
        {
            CentrarPaneles();
        }

        //CENTRAR PANELES
        private void CentrarPaneles()
        {
            int centro = this.Width / 2;
            pnlDatoslocal.Left = centro - pnlDatoslocal.Width / 2;
            pnlMonitor.Left = centro - pnlMonitor.Width / 2;
            pnlAlertaContenedor.Left = centro - pnlAlertaContenedor.Width / 2;
            btnGuardar.Left = centro - 80;
            btnClausurar.Left = centro + 50;
        }

        //LIMPIAR CAMPOS
        public void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPropietario.Clear();
            txtFechaInsp.Clear();
            txtInspector.Clear();
            txtObservaciones.Clear();
            cmbTipo.SelectedIndex = -1;

            chkCubreboca.Checked = true;
            chkSuperficies.Checked = true;
            chkPiso.Checked = true;
            chkPlagas.Checked = true;
            chkPermisoVigente.Checked = true;
            chkBasureroTapa.Checked = true;

            pnlAlertaContenedor.Visible = false;
            DesbloquearFicha();

            modoReinspeccion = false;
            idLocalReinspeccion = null;
        }

        //BLOQUEAR / DESBLOQUEAR
        private void BloquearFicha()
        {
            txtId.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtPropietario.ReadOnly = true;
            txtFechaInsp.ReadOnly = true;
            txtInspector.ReadOnly = true;
            txtObservaciones.ReadOnly = true;
            cmbTipo.Enabled = false;
            pnlMonitor.Enabled = false;
            btnGuardar.Enabled = false;
            btnClausurar.Enabled = false;
        }

        private void DesbloquearFicha()
        {
            txtId.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtPropietario.ReadOnly = false;
            txtFechaInsp.ReadOnly = false;
            txtInspector.ReadOnly = false;
            txtObservaciones.ReadOnly = false;
            cmbTipo.Enabled = true;
            pnlMonitor.Enabled = true;
            btnGuardar.Enabled = true;
            btnClausurar.Enabled = true;
        }

        //CARGAR LOCAL PARA REINSPECCIÓN
        public void CargarLocalParaReinspeccion(EstablecimientoBase local)
        {
            LimpiarCampos();
            modoReinspeccion = true;
            idLocalReinspeccion = local.IdLocal;

            txtId.Text = local.IdLocal;
            txtNombre.Text = local.Nombre;
            txtPropietario.Text = local.Propietario;
            txtInspector.Text = local.Inspector;
            txtFechaInsp.Text = "";
            cmbTipo.Text = local.ObtenerTipo();

            DesbloquearFicha();
        }

        //CHECKBOXES — ADVERTENCIAS
        private void ActualizarAdvertencia()
        {
            int faltas = 0;
            var listaFaltas = new List<string>();

            if (!chkPlagas.Checked) { faltas++; listaFaltas.Add("Presencia de plagas"); }
            if (!chkPiso.Checked) { faltas++; listaFaltas.Add("Almacenamiento en piso"); }
            if (!chkSuperficies.Checked) { faltas++; listaFaltas.Add("Falta de higiene en superficies"); }

            if (faltas == 0) { pnlAlertaContenedor.Visible = false; return; }

            pnlAlertaContenedor.Visible = true;

            if (faltas == 1)
            {
                pnlAlertaContenedor.BackColor = Color.FromArgb(255, 243, 205);
                lblAlertaTitulo.ForeColor = Color.FromArgb(133, 79, 11);
                lblAlertaTitulo.Text = "⚠ Advertencia #1 — Falta menor detectada";
                lblAlertaMensaje.Text = $"Se ha detectado: {listaFaltas[0]}. Corrija antes de la próxima inspección.";
            }
            else if (faltas == 2)
            {
                pnlAlertaContenedor.BackColor = Color.FromArgb(255, 220, 177);
                lblAlertaTitulo.ForeColor = Color.FromArgb(163, 45, 45);
                lblAlertaTitulo.Text = "⚠⚠ Advertencia #2 — Faltas graves detectadas";
                lblAlertaMensaje.Text = $"Se detectaron: {string.Join(", ", listaFaltas)}. Riesgo sanitario moderado. Acción inmediata requerida.";
            }
            else
            {
                pnlAlertaContenedor.BackColor = Color.FromArgb(252, 235, 235);
                lblAlertaTitulo.ForeColor = Color.FromArgb(121, 31, 31);
                lblAlertaTitulo.Text = "🚨 CLAUSURA INMINENTE — 3 faltas críticas detectadas";
                lblAlertaMensaje.Text = "Se detectaron: " + string.Join(", ", listaFaltas) + ". Este local será clausurado al guardar.";
            }
        }

        private void chkPlagas_CheckedChanged(object sender, EventArgs e) => ActualizarAdvertencia();
        private void chkPiso_CheckedChanged(object sender, EventArgs e) => ActualizarAdvertencia();
        private void chkSuperficies_CheckedChanged(object sender, EventArgs e) => ActualizarAdvertencia();

        //BOTÓN GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Complete al menos el ID y el Nombre del local.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EstablecimientoBase local = cmbTipo.Text == "PuestoAmbulante" ? (EstablecimientoBase)new PuestoAmbulante() : new LocalComercial();

            local.IdLocal = txtId.Text.Trim();
            local.Nombre = txtNombre.Text.Trim();
            local.Propietario = txtPropietario.Text.Trim();
            local.Inspector = txtInspector.Text.Trim();
            local.FechaInspeccion = txtFechaInsp.Text.Trim();
            local.Observaciones = txtObservaciones.Text.Trim();

            if (!chkPlagas.Checked) local.FaltasCriticas.Add("Presencia de plagas");
            if (!chkPiso.Checked) local.FaltasCriticas.Add("Almacenamiento en piso");
            if (!chkSuperficies.Checked) local.FaltasCriticas.Add("Falta de higiene en superficies");

            int faltasCount = local.FaltasCriticas.Count;
            local.Estado = faltasCount >= 3 ? "CLAUSURADO" : faltasCount > 0 ? "Con faltas" : "Aprobado";

            local.NumeroInspeccion = Form1.Repositorio.ObtenerTodos().Count(l => l.IdLocal == local.IdLocal) + 1;

            local.RutaActa = "";
            Form1.Repositorio.Agregar(local);

            Form1 padre = (Form1)this.MdiParent;
            padre.ActualizarListaLocales();

            MessageBox.Show($"Local '{local.Nombre}' guardado correctamente.\nEstado: {local.Estado}", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BloquearFicha();
            LimpiarCampos();
        }

        //BOTÓN CLAUSURAR
        private void btnClausurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Complete el ID del local antes de clausurar.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var listaFaltas = new List<string>();
            if (!chkPlagas.Checked) listaFaltas.Add("Presencia de plagas.");
            if (!chkPiso.Checked) listaFaltas.Add("Almacenamiento en piso.");
            if (!chkSuperficies.Checked) listaFaltas.Add("Falta de higiene en superficies.");
            if (listaFaltas.Count == 0) listaFaltas.Add("Clausura manual por el inspector.");

            string folio = $"ACTA-{DateTime.Now:yyyyMMddHHmmss}";
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");

            // Rutas 
            string carpetaActas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"EcoFlow", "Actas");
            string plantilla = Path.Combine(Application.StartupPath, "plantilla.docx");
            string ruta = Path.Combine(carpetaActas, $"{folio}_{txtId.Text.Trim()}.docx");

            if (!File.Exists(plantilla))
            {
                MessageBox.Show($"No se encontró la plantilla en:\n{plantilla}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Directory.CreateDirectory(carpetaActas);
            File.Copy(plantilla, ruta, true);

            string faltasStr = string.Join("\n", listaFaltas);

            using (var doc = Xceed.Words.NET.DocX.Load(ruta))
            {
                doc.ReplaceText("«FOLIO»", folio);
                doc.ReplaceText("«FECHA»", fecha);
                doc.ReplaceText("«ID_LOCAL»", txtId.Text.Trim());
                doc.ReplaceText("«NOMBRE»", txtNombre.Text.Trim());
                doc.ReplaceText("«PROPIETARIO»", txtPropietario.Text.Trim());
                doc.ReplaceText("«TIPO»", cmbTipo.Text);
                doc.ReplaceText("«INSPECTOR»", txtInspector.Text.Trim());
                doc.ReplaceText("«FECHA_INSP»", txtFechaInsp.Text.Trim());
                doc.ReplaceText("«ESTADO»", "CLAUSURADO");
                doc.ReplaceText("«FALTAS»", faltasStr);
                doc.ReplaceText("«OBSERVACIONES»", string.IsNullOrWhiteSpace(txtObservaciones.Text) ? "Sin observaciones adicionales." : txtObservaciones.Text.Trim());
                doc.Save();
            }

            EstablecimientoBase local = cmbTipo.Text == "PuestoAmbulante" ? (EstablecimientoBase)new PuestoAmbulante() : new LocalComercial();

            local.IdLocal = txtId.Text.Trim();
            local.Nombre = txtNombre.Text.Trim();
            local.Propietario = txtPropietario.Text.Trim();
            local.Inspector = txtInspector.Text.Trim();
            local.FechaInspeccion = fecha;
            local.Observaciones = txtObservaciones.Text.Trim();
            local.Estado = "CLAUSURADO";
            local.FaltasCriticas = listaFaltas;
            local.NumeroInspeccion = Form1.Repositorio.ObtenerTodos().Count(l => l.IdLocal == local.IdLocal) + 1;
            local.RutaActa = ruta;

            Form1.Repositorio.Agregar(local);

            Form1 padre = (Form1)this.MdiParent;
            padre.ActualizarListaLocales();

            MessageBox.Show($"Acta Word generada:\n{ruta}", "Clausura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BloquearFicha();
            LimpiarCampos();
        }

        //IR A HISTORIAL
        public void IrAHistorial()
        {
            tabControl1.SelectedTab = tabPage2;
        }

        //CAMBIO DE PESTAÑA
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                ActualizarCombosHistorial();
            if (tabControl1.SelectedIndex == 2)
                CargarActasGeneradas();
        }

        //PESTAÑA 2: HISTORIAL
        private void ActualizarCombosHistorial()
        {
            cmbFiltroLocal.Items.Clear();
            cmbFiltroEstado.Items.Clear();

            cmbFiltroEstado.Items.Add("Todos");
            cmbFiltroEstado.Items.Add("Aprobado");
            cmbFiltroEstado.Items.Add("Con faltas");
            cmbFiltroEstado.Items.Add("CLAUSURADO");
            cmbFiltroEstado.SelectedIndex = 0;

            var localesUnicos = Form1.Repositorio.ObtenerTodos()
                .GroupBy(l => l.IdLocal)
                .Select(g => g.First())
                .ToList();

            foreach (var local in localesUnicos)
                cmbFiltroLocal.Items.Add(local.IdLocal + " | " + local.Nombre);
        }

        private void btnBuscarHistorial_Click(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.AutoGenerateColumns = false;
            dgvHistorial.Rows.Clear();

            var lista = Form1.Repositorio.ObtenerTodos();

            if (cmbFiltroLocal.SelectedIndex >= 0)
            {
                string idSeleccionado = cmbFiltroLocal.SelectedItem.ToString().Split('|')[0].Trim();
                lista = lista.Where(l => l.IdLocal == idSeleccionado).ToList();
            }

            if (cmbFiltroEstado.SelectedItem?.ToString() != "Todos" && cmbFiltroEstado.SelectedIndex >= 0)
                lista = lista.Where(l => l.Estado == cmbFiltroEstado.SelectedItem.ToString()).ToList();

            foreach (var local in lista)
            {
                string faltas = local.FaltasCriticas.Count > 0 ? string.Join(", ", local.FaltasCriticas) : "Sin faltas";
                string rutaActa = local.RutaActa ?? "";
                string actaMostrar = !string.IsNullOrEmpty(rutaActa) && File.Exists(rutaActa) ? Path.GetFileName(rutaActa) : "— sin acta —";

                int idx = dgvHistorial.Rows.Add(local.FechaInspeccion, faltas, local.Estado, actaMostrar);
                dgvHistorial.Rows[idx].Tag = rutaActa;
            }

            lblAprobados.Text = lista.Count(l => l.Estado == "Aprobado").ToString();
            lblClausuras.Text = lista.Count(l => l.Estado == "CLAUSURADO").ToString();
            lblFaltas.Text = lista.Count(l => l.FaltasCriticas.Count > 0).ToString();
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 4) return;

            string ruta = dgvHistorial.Rows[e.RowIndex].Tag?.ToString();

            if (string.IsNullOrEmpty(ruta) || !File.Exists(ruta))
            {
                MessageBox.Show("No se encontró el acta de esta inspección.", "Sin acta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Intentamos abrir el acta de forma segura
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Capturamos cualquier error en la apertura
                MessageBox.Show($"No se pudo abrir el archivo:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbFiltroLocal.SelectedIndex = -1;
            cmbFiltroEstado.SelectedIndex = 0;
            dgvHistorial.Rows.Clear();
            lblAprobados.Text = "0";
            lblClausuras.Text = "0";
            lblFaltas.Text = "0";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar. Realiza una búsqueda primero.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ruta
            string carpetaActas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"EcoFlow", "Actas");
            string ruta = Path.Combine(carpetaActas, $"Historial_{DateTime.Now:yyyyMMddHHmm}.xlsx");
            Directory.CreateDirectory(carpetaActas);

            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Historial de Reincidencias");

                ws.Cell("A1").Value = "MUNICIPIO DE MINATITLÁN - CONTROL SANITARIO";
                ws.Range("A1:E1").Merge();
                ws.Cell("A1").Style
                    .Font.SetBold(true).Font.SetFontSize(14)
                    .Font.SetFontColor(XLColor.White)
                    .Fill.SetBackgroundColor(XLColor.FromArgb(26, 95, 168))
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                ws.Cell("A2").Value = "Historial de Reincidencias — Sistema de Vigilancia Sanitaria";
                ws.Range("A2:E2").Merge();
                ws.Cell("A2").Style
                    .Font.SetItalic(true).Font.SetFontSize(10)
                    .Font.SetFontColor(XLColor.FromArgb(80, 120, 180))
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                ws.Cell("A3").Value = $"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}";
                ws.Range("A3:E3").Merge();
                ws.Cell("A3").Style
                    .Font.SetFontSize(9).Font.SetFontColor(XLColor.Gray)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);

                ws.Row(4).Height = 8;

                string[] encabezados = { "Fecha", "Falta Crítica", "Estado Resultante", "Acta Generada", "# Inspección" };
                for (int i = 0; i < encabezados.Length; i++)
                {
                    var celda = ws.Cell(5, i + 1);
                    celda.Value = encabezados[i];
                    celda.Style
                        .Font.SetBold(true).Font.SetFontColor(XLColor.White)
                        .Font.SetFontSize(11)
                        .Fill.SetBackgroundColor(XLColor.FromArgb(26, 95, 168))
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                        .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
                        .Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                        .Border.SetOutsideBorderColor(XLColor.White);
                }
                ws.Row(5).Height = 22;

                int fila = 6;
                bool esAlterna = false;

                foreach (DataGridViewRow dgvFila in dgvHistorial.Rows)
                {
                    string fecha = dgvFila.Cells[0].Value?.ToString() ?? "";
                    string falta = dgvFila.Cells[1].Value?.ToString() ?? "";
                    string estado = dgvFila.Cells[2].Value?.ToString() ?? "";
                    string acta = dgvFila.Cells[3].Value?.ToString() ?? "";

                    ws.Cell(fila, 1).Value = fecha;
                    ws.Cell(fila, 2).Value = falta;
                    ws.Cell(fila, 3).Value = estado;
                    ws.Cell(fila, 4).Value = acta;
                    ws.Cell(fila, 5).Value = fila - 5;

                    XLColor colorFondo = esAlterna ? XLColor.FromArgb(235, 243, 251) : XLColor.White;
                    if (estado == "CLAUSURADO")
                        colorFondo = XLColor.FromArgb(255, 220, 220);
                    else if (estado == "Con faltas")
                        colorFondo = XLColor.FromArgb(255, 243, 205);
                    else if (estado == "Aprobado")
                        colorFondo = XLColor.FromArgb(234, 250, 234);

                    var rango = ws.Range(fila, 1, fila, 5);
                    rango.Style
                        .Fill.SetBackgroundColor(colorFondo)
                        .Font.SetFontSize(10)
                        .Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                        .Border.SetOutsideBorderColor(XLColor.FromArgb(200, 200, 200))
                        .Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                    if (estado == "CLAUSURADO")
                        rango.Style.Font.SetFontColor(XLColor.DarkRed);
                    else if (estado == "Con faltas")
                        rango.Style.Font.SetFontColor(XLColor.FromArgb(133, 79, 11));

                    ws.Row(fila).Height = 18;
                    esAlterna = !esAlterna;
                    fila++;
                }

                fila++;
                ws.Cell(fila, 1).Value = "RESUMEN";
                ws.Range(fila, 1, fila, 5).Merge();
                ws.Cell(fila, 1).Style.Font.SetBold(true).Font.SetFontColor(XLColor.White).Fill.SetBackgroundColor(XLColor.FromArgb(26, 95, 168))
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                fila++;
                ws.Cell(fila, 1).Value = "Advertencias:";
                ws.Cell(fila, 2).Value = lblAprobados.Text;
                ws.Cell(fila, 1).Style.Font.SetBold(true); fila++;
                ws.Cell(fila, 1).Value = "Clausuras:";
                ws.Cell(fila, 2).Value = lblClausuras.Text;
                ws.Cell(fila, 1).Style.Font.SetBold(true); fila++;
                ws.Cell(fila, 1).Value = "Total faltas:";
                ws.Cell(fila, 2).Value = lblFaltas.Text;
                ws.Cell(fila, 1).Style.Font.SetBold(true);

                ws.Column(1).Width = 20; ws.Column(2).Width = 35;
                ws.Column(3).Width = 20; ws.Column(4).Width = 30;
                ws.Column(5).Width = 15;

                wb.SaveAs(ruta);
            }

            MessageBox.Show($"Excel generado:\n{ruta}", "Exportado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = ruta, UseShellExecute = true });
        }

        //PESTAÑA 3: ACTAS
        private void CargarActasGeneradas()
        {
            dgvActas.DataSource = null;
            dgvActas.AutoGenerateColumns = false;
            dgvActas.Rows.Clear();

            var localesConActa = Form1.Repositorio.ObtenerTodos().Where(l => !string.IsNullOrEmpty(l.RutaActa)).ToList();

            foreach (var local in localesConActa)
            {
                string archivo = Path.GetFileName(local.RutaActa);
                string faltas = local.FaltasCriticas.Count > 0 ? string.Join(", ", local.FaltasCriticas) : "Sin faltas";

                int idx = dgvActas.Rows.Add(archivo, local.Nombre, faltas, local.FechaInspeccion);
                dgvActas.Rows[idx].Tag = local;
            }

            pnlResumen.Visible = false;
            rtbVistaResumen.Clear();
        }

        private void btnBuscarActa_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarActa.Text.Trim().ToLower();

            dgvActas.DataSource = null;
            dgvActas.AutoGenerateColumns = false;
            dgvActas.Rows.Clear();

            var localesConActa = Form1.Repositorio.ObtenerTodos().Where(l => !string.IsNullOrEmpty(l.RutaActa)).ToList();

            if (!string.IsNullOrEmpty(busqueda))
                localesConActa = localesConActa.Where(l => l.Nombre.ToLower().Contains(busqueda) || l.IdLocal.ToLower().Contains(busqueda) ||
                    Path.GetFileName(l.RutaActa).ToLower().Contains(busqueda)).ToList();

            foreach (var local in localesConActa)
            {
                string archivo = Path.GetFileName(local.RutaActa);
                string faltas = local.FaltasCriticas.Count > 0 ? string.Join(", ", local.FaltasCriticas) : "Sin faltas";

                int idx = dgvActas.Rows.Add(archivo, local.Nombre, faltas, local.FechaInspeccion);
                dgvActas.Rows[idx].Tag = local;
            }

            if (dgvActas.Rows.Count == 0)
                MessageBox.Show("No se encontraron actas con ese criterio.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerResumen_Click(object sender, EventArgs e)
        {
            if (dgvActas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro del historial primero.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EstablecimientoBase local = dgvActas.SelectedRows[0].Tag as EstablecimientoBase;
            if (local == null) return;

            string folio = Path.GetFileNameWithoutExtension(local.RutaActa ?? "SIN-FOLIO");
            string faltas = local.FaltasCriticas.Count > 0 ? string.Join("\n   • ", local.FaltasCriticas) : "Sin faltas críticas";

            rtbVistaResumen.Text =
                "==================================================\n" +
                "  VISTA PREVIA RESTRINGIDA — ACTA SANITARIA\n" +
                "==================================================\n" +
                $"  Folio: {folio}\n\n" +
                "  DATOS DEL ESTABLECIMIENTO\n" +
                "--------------------------------------------------\n" +
                $"  Nombre Comercial : {local.Nombre}\n" +
                $"  Identificador ID : {local.IdLocal}\n" +
                $"  Tipo             : {local.ObtenerTipo()}\n" +
                $"  Propietario      : {local.Propietario}\n\n" +
                "==================================================\n" +
                "  DETALLES DE LA AUDITORÍA\n" +
                "--------------------------------------------------\n" +
                $"  Inspector        : {local.Inspector}\n" +
                $"  Fecha Aplicación : {local.FechaInspeccion}\n\n" +
                "==================================================\n" +
                "  DIAGNÓSTICO Y DICTAMEN\n" +
                "--------------------------------------------------\n" +
                $"  Estado Actual    : {local.Estado}\n" +
                $"  Faltas Críticas  :\n   • {faltas}\n\n" +
                "  OBSERVACIONES ADICIONALES\n" +
                "--------------------------------------------------\n" +
                $"  {(string.IsNullOrWhiteSpace(local.Observaciones) ? "Sin observaciones adicionales." : local.Observaciones)}\n\n" +
                "==================================================";

            pnlResumen.Visible = true;
        }

        private void btnCerrarVista_Click(object sender, EventArgs e)
        {
            pnlResumen.Visible = false;
            rtbVistaResumen.Clear();
        }

        private void dgvActas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dgvActas.Rows[e.RowIndex].Selected = true;

            if (e.ColumnIndex == 4)
            {
                EstablecimientoBase local = dgvActas.Rows[e.RowIndex].Tag as EstablecimientoBase;

                if (local == null || string.IsNullOrEmpty(local.RutaActa)) return;

                if (!File.Exists(local.RutaActa))
                {
                    MessageBox.Show("No se encontró el archivo del acta.", "Sin archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    // Intentamos abrir el acta de forma segura
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = local.RutaActa,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    // Capturamos cualquier error en la apertura
                    MessageBox.Show($"No se pudo abrir el archivo:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //EVENTOS VACÍOS
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
        private void tabPage3_Click(object sender, EventArgs e) { }
        private void dgvActas_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblFaltas_Click(object sender, EventArgs e){}
    }
}