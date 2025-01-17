using System.Collections.Generic;
using DevelopmentChallenge.Data.Refactorizacion.Interfaces;


namespace DevelopmentChallenge.Data.Refactorizacion.Services.Idiomas
{
    public class ProveedorEspanol : IProveedorIdioma
    {
        public string ObtenerTituloReporte() =>              "Reporte de Formas";
        public string ObtenerMensajeListaVacia() =>          "Lista vacía de formas!";
        public string ObtenerEtiquetaTotal() =>              "TOTAL:";
        public string ObtenerEtiquetaFormas(int cantidad) => "formas";
        public string ObtenerEtiquetaPerimetro() =>          "Perimetro";
        public string ObtenerEtiquetaArea() =>               "Area";

        public Dictionary<string, (string Singular, string Plural)> ObtenerNombresFormas() =>
            new Dictionary<string, (string Singular, string Plural)>
            {
            { "Cuadrado",   ("Cuadrado", "Cuadrados") },
            { "Circulo",    ("Círculo", "Círculos") },
            { "Triangulo",  ("Triángulo", "Triángulos") },
            { "Rectangulo", ("Rectangulo", "Rectangulos") },
            { "Trapecio",   ("Trapecio", "Trapecios") }
            };
    }
}
