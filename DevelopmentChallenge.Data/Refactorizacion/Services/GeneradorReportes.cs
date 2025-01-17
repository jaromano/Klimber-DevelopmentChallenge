using System.Linq;
using System.Text;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Refactorizacion.Interfaces;

namespace DevelopmentChallenge.Data.Refactorizacion.Services
{
    public class GeneradorReportes
    {
        private readonly IProveedorIdioma _proveedorIdioma;

        public GeneradorReportes(IProveedorIdioma proveedorIdioma)
        {
            _proveedorIdioma = proveedorIdioma;
        }

        public string GenerarReporte(List<IFormaGeometrica> formas)
        {
            if (!formas.Any())
            {
                return $"<h1>{_proveedorIdioma.ObtenerMensajeListaVacia()}</h1>";
            }

            var sb = new StringBuilder();
            sb.AppendLine($"<h1>{_proveedorIdioma.ObtenerTituloReporte()}</h1>");

            var formasAgrupadas = formas.GroupBy(f => f.GetType())
                .Select(g => new
                {
                    Tipo = g.Key,
                    Cantidad = g.Count(),
                    AreaTotal = g.Sum(f => f.CalcularArea()),
                    PerimetroTotal = g.Sum(f => f.CalcularPerimetro()),
                    Muestra = g.First()
                });

            foreach (var grupo in formasAgrupadas)
            {
                sb.AppendLine($"{grupo.Cantidad} {grupo.Muestra.ObtenerNombre(_proveedorIdioma, grupo.Cantidad)} | " +
                             $"{_proveedorIdioma.ObtenerEtiquetaArea()} {grupo.AreaTotal:#.##} | " +
                             $"{_proveedorIdioma.ObtenerEtiquetaPerimetro()} {grupo.PerimetroTotal:#.##} <br/>");
            }

            // Totales
            var totalFormas = formas.Count;
            var perimetroTotal = formas.Sum(f => f.CalcularPerimetro());
            var areaTotal = formas.Sum(f => f.CalcularArea());

            sb.AppendLine($"{_proveedorIdioma.ObtenerEtiquetaTotal()}<br/>");
            sb.AppendLine($"{totalFormas} {_proveedorIdioma.ObtenerEtiquetaFormas(totalFormas)} " +
                         $"{_proveedorIdioma.ObtenerEtiquetaPerimetro()} {perimetroTotal:#.##} " +
                         $"{_proveedorIdioma.ObtenerEtiquetaArea()} {areaTotal:#.##}");

            return sb.ToString();
        }
    }
}
