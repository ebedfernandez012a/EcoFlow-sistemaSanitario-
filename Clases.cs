using System.Collections.Generic;
using System.Linq;

namespace sistemaSanitario
{
    // CONTRATO DE INTERFAZ — abstracción pura
 
    public interface IRepositorio<T>
    {
        void Agregar(T item);
        void Eliminar(string id);
        T BuscarPorId(string id);
        List<T> ObtenerTodos();
        List<T> FiltrarPorEstado(string estado);
    }

    // ABSTRACCIÓN PURA — clase base abstracta

    public abstract class EstablecimientoBase
    {
        public string IdLocal { get; set; }
        public int NumeroInspeccion { get; set; } = 1;

        public string Nombre { get; set; }
        public string Propietario { get; set; }
        public string Inspector { get; set; }
        public string FechaInspeccion { get; set; }
        public string Estado { get; set; } = "Activo";
        public string Observaciones { get; set; }
        public string RutaActa { get; set; } = "";
        public List<string> FaltasCriticas { get; set; } = new List<string>();

        // MÉTODO ABSTRACTO — polimorfismo de inclusión
        public abstract string ObtenerTipo();
        public abstract string ObtenerDescripcionTipo();
    }

    // POLIMORFISMO DE INCLUSIÓN — LocalComercial
 
    public class LocalComercial : EstablecimientoBase
    {
        public override string ObtenerTipo() => "LocalComercial";
        public override string ObtenerDescripcionTipo() => "Local comercial fijo dentro del mercado";
    }

    // POLIMORFISMO DE INCLUSIÓN — PuestoAmbulante

    public class PuestoAmbulante : EstablecimientoBase
    {
        public override string ObtenerTipo() => "PuestoAmbulante";
        public override string ObtenerDescripcionTipo() => "Puesto ambulante con movilidad dentro del mercado";
    }

    // POLIMORFISMO PARAMÉTRICO — Repositorio<T>
    public class RepositorioLocales<T> : IRepositorio<T>  where T : EstablecimientoBase
    {
        private List<T> _lista = new List<T>();

        public void Agregar(T item)
        {
            _lista.Add(item);
        }

        public void Eliminar(string id)
        {
            _lista.RemoveAll(i => i.IdLocal == id);
        }

        public T BuscarPorId(string id)
        {
            return _lista.FirstOrDefault(i => i.IdLocal == id);
        }

        public List<T> ObtenerTodos()
        {
            return _lista.ToList();
        }

        public List<T> FiltrarPorEstado(string estado)
        {
            return _lista.Where(i => i.Estado == estado).ToList();
        }

        public int ContarFaltasPorLocal(string idLocal)
        {
            var local = BuscarPorId(idLocal);
            return local?.FaltasCriticas.Count ?? 0;
        }
    }
}
