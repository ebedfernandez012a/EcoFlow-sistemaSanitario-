using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace sistemaSanitario
{
    public partial class Form1 : Form
    {
        private bool salirConfirmado = false;
        public static RepositorioLocales<EstablecimientoBase> Repositorio = new RepositorioLocales<EstablecimientoBase>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salirConfirmado) return;
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir del sistema?","Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
                if (hijo is FormInspeccion)
                    hijo.Dock = DockStyle.Fill;
        }

        //BOTÓN NUEVO LOCAL
        private void btnNuevoLocal_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is FormInspeccion)
                {
                    hijo.Focus();
                    return;
                }
            }
            AbrirFormInspeccion();
        }

        private void AbrirFormInspeccion()
        {
            FormInspeccion nuevoHijo = new FormInspeccion();
            nuevoHijo.MdiParent = this;
            nuevoHijo.MaximizeBox = false;
            nuevoHijo.MinimizeBox = false;
            nuevoHijo.AutoScroll = false;
            nuevoHijo.FormBorderStyle = FormBorderStyle.None;
            nuevoHijo.Show();
            nuevoHijo.Dock = DockStyle.Fill;
        }

        //ACTUALIZAR LISTA DE LOCALES
        public void ActualizarListaLocales()
        {
            pnlListaLocales.Controls.Clear();

            var localesUnicos = Repositorio.ObtenerTodos().GroupBy(l => l.IdLocal).Select(g => g.OrderByDescending(l => l.NumeroInspeccion).First()).ToList();

            foreach (var local in localesUnicos)
            {
                Button btnLocal = new Button();
                btnLocal.Text = $"{local.IdLocal}\n{local.Nombre}";
                btnLocal.Tag = local.IdLocal;
                btnLocal.Dock = DockStyle.Top;
                btnLocal.Height = 52;
                btnLocal.TextAlign = ContentAlignment.MiddleLeft;
                btnLocal.Padding = new Padding(6, 8, 6, 8);
                btnLocal.FlatStyle = FlatStyle.Flat;
                btnLocal.FlatAppearance.BorderColor = Color.FromArgb(26, 95, 168);
                btnLocal.BackColor = local.Estado == "CLAUSURADO" ? Color.FromArgb(255, 220, 220) : Color.White;
                btnLocal.ForeColor = local.Estado == "CLAUSURADO" ? Color.DarkRed : Color.Black;
                btnLocal.Click += BtnLocal_Click;
                pnlListaLocales.Controls.Add(btnLocal);
            }

            lblContador.Text = $"En memoria: {Repositorio.ObtenerTodos().Count} Registros";
        }

        //CLIC EN LOCAL
        private string idLocalSeleccionado = null;

        private void BtnLocal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            idLocalSeleccionado = btn.Tag.ToString();

            foreach (Control ctrl in pnlListaLocales.Controls)
            {
                if (ctrl is Button b)
                    b.BackColor = b.Tag.ToString() == idLocalSeleccionado ? Color.FromArgb(200, 220, 255)
                    : (Repositorio.BuscarPorId(b.Tag.ToString())?.Estado == "CLAUSURADO" ? Color.FromArgb(255, 220, 220) : Color.White);
            }
        }

        //MENÚ: REINSPECCIONAR
        private void ReinspeccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idLocalSeleccionado == null)
            {
                MessageBox.Show("Selecciona un local de la lista para reinspeccionar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EstablecimientoBase local = Repositorio.BuscarPorId(idLocalSeleccionado);
            if (local == null) return;

            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is FormInspeccion fi)
                {
                    fi.CargarLocalParaReinspeccion(local);
                    fi.Focus();
                    return;
                }
            }

            AbrirFormInspeccion();

            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is FormInspeccion fi)
                {
                    fi.CargarLocalParaReinspeccion(local);
                    break;
                }
            }
        }

        //MENÚ: LIMPIAR CAMPOS
        private void LimpiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is FormInspeccion fi)
                {
                    fi.LimpiarCampos();
                    break;
                }
            }
        }

        //MENÚ: SALIR
        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir del sistema?","Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                salirConfirmado = true;
                Application.Exit();
            }
        }

        //MENÚ: ESTADÍSTICAS 
        private void generarReporteDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstadisticas stats = new FormEstadisticas();
            stats.ShowDialog();
        }

        //MENÚ: BORRAR LOCAL
        private void borrarLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idLocalSeleccionado == null)
            {
                MessageBox.Show("Selecciona un local de la lista primero.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EstablecimientoBase local = Repositorio.BuscarPorId(idLocalSeleccionado);
            if (local == null) return;

            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de que desea eliminar el local:\n" + $"{local.IdLocal} — {local.Nombre}?\n\n" +
                $"Esta acción no se puede deshacer.","Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                Repositorio.Eliminar(idLocalSeleccionado);
                idLocalSeleccionado = null;
                ActualizarListaLocales();
                MessageBox.Show("Local eliminado del repositorio.","Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //BOTÓN GENERAR ACTA
        private void btnGenerarActa_Click(object sender, EventArgs e)
        {
            if (idLocalSeleccionado == null) return;
            EstablecimientoBase local = Repositorio.ObtenerTodos().Where(l => l.IdLocal == idLocalSeleccionado).OrderByDescending(l => l.NumeroInspeccion).FirstOrDefault();
            if (local == null) return;

            //Rutas 
            string carpetaActas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"EcoFlow", "Actas");
            string plantilla = Path.Combine(Application.StartupPath, "plantilla.docx");
            string folio = $"ACTA-{DateTime.Now:yyyyMMddHHmmss}";
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            string ruta = Path.Combine(carpetaActas, $"{folio}_{local.IdLocal}.docx");

            if (!File.Exists(plantilla)) 
            {
                MessageBox.Show($"No se encontró la plantilla en:\n{plantilla}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Directory.CreateDirectory(carpetaActas);
            File.Copy(plantilla, ruta, true);

            string faltas = local.FaltasCriticas.Count > 0 ? string.Join("\n", local.FaltasCriticas) : "Sin faltas críticas. Local aprobado.";

            using (var doc = DocX.Load(ruta))
            {
                doc.ReplaceText("«FOLIO»", folio);
                doc.ReplaceText("«FECHA»", fecha);
                doc.ReplaceText("«ID_LOCAL»", local.IdLocal);
                doc.ReplaceText("«NOMBRE»", local.Nombre);
                doc.ReplaceText("«PROPIETARIO»", local.Propietario);
                doc.ReplaceText("«TIPO»", local.ObtenerTipo());
                doc.ReplaceText("«INSPECTOR»", local.Inspector);
                doc.ReplaceText("«FECHA_INSP»", local.FechaInspeccion);
                doc.ReplaceText("«ESTADO»", local.Estado);
                doc.ReplaceText("«FALTAS»", faltas);
                doc.ReplaceText("«OBSERVACIONES»", string.IsNullOrWhiteSpace(local.Observaciones) ? "Sin observaciones adicionales." : local.Observaciones);
                doc.Save();
            }

            local.RutaActa = ruta;
            MessageBox.Show($"Acta generada:\n{ruta}", "Acta generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //MENÚ: LIMPIAR REPOSITORIO
        private void limpiarRepositorioClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Repositorio.ObtenerTodos().Count == 0)
            {
                MessageBox.Show("El repositorio ya está vacío.", "Sin registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de que desea borrar todos los locales?\n" +
                $"Se eliminarán {Repositorio.ObtenerTodos().Count} registros.\n\n" + $"Esta acción no se puede deshacer.",
                "Limpiar repositorio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                foreach (var local in Repositorio.ObtenerTodos().ToList())
                Repositorio.Eliminar(local.IdLocal);
                idLocalSeleccionado = null;
                ActualizarListaLocales();
                MessageBox.Show("Repositorio limpiado correctamente.","Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ── MENÚ: ACERCA DEL SISTEMA ────────────────────────────
        private void acercaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje =
                "EcoFlow Health - Sistema de Vigilancia Sanitaria Municipal\n\n" +
                "Versión: 1.0 (Build 2026)\n" +
                "Desarrollador: Ebed Ezequiel Fernandez Antonio\n\n" +
                "Herramienta digital (Juez Digital) diseñada para la estandarización, " +
                "captura y gestión del historial de inspecciones sanitarias en " +
                "establecimientos y mercados municipales.\n\n" +
                "© 2026 Todos los derechos reservados.";
            MessageBox.Show(mensaje, "Acerca de EcoFlow Health",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //BOTON HISTORIAL
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is FormInspeccion fi)
                {
                    fi.IrAHistorial();
                    fi.Focus();
                    return;
                }
            }
        }

        //MENE: ARCHIVO 
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}