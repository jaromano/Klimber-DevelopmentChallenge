using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Refactorizacion.Interfaces
{
    public interface IProveedorIdioma
    {
        string ObtenerTituloReporte();
        string ObtenerMensajeListaVacia();
        string ObtenerEtiquetaTotal();
        string ObtenerEtiquetaFormas(int cantidad);
        string ObtenerEtiquetaPerimetro();
        string ObtenerEtiquetaArea();
        Dictionary<string, (string Singular, string Plural)> ObtenerNombresFormas();
    }
}
