using System.Collections.Generic;
using DevelopmentChallenge.Data.Refactorizacion.Interfaces;

namespace DevelopmentChallenge.Data.Refactorizacion.Services.Idiomas
{
    public class ProveedorIngles : IProveedorIdioma
    {
        public string ObtenerTituloReporte() =>              "Shapes Report";
        public string ObtenerMensajeListaVacia() =>          "Empty list of shapes!";
        public string ObtenerEtiquetaTotal() =>              "TOTAL:";
        public string ObtenerEtiquetaFormas(int cantidad) => "shapes";
        public string ObtenerEtiquetaPerimetro() =>          "Perimeter";
        public string ObtenerEtiquetaArea() =>               "Area";

        public Dictionary<string, (string Singular, string Plural)> ObtenerNombresFormas() =>
            new Dictionary<string, (string Singular, string Plural)>
            {
            { "Cuadrado",   ("Square", "Squares") },
            { "Circulo",    ("Circle", "Circles") },
            { "Triangulo",  ("Triangle", "Triangles") },
            { "Rectangulo", ("Rectangle", "Rectangle") },
            { "Trapecio",   ("Trapezoid", "Trapezoids") }
            };
    }
}
