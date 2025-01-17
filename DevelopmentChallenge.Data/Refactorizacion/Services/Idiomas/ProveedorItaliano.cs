using System.Collections.Generic;
using DevelopmentChallenge.Data.Refactorizacion.Interfaces;

namespace DevelopmentChallenge.Data.Refactorizacion.Services.Idiomas
{
    public class ProveedorItaliano : IProveedorIdioma
    {
        public string ObtenerTituloReporte() =>              "Rapporto delle Forme";
        public string ObtenerMensajeListaVacia() =>          "Lista vuota di forme!";
        public string ObtenerEtiquetaTotal() =>              "TOTALE:";
        public string ObtenerEtiquetaFormas(int cantidad) => "forme";
        public string ObtenerEtiquetaPerimetro() =>          "Perimetro";
        public string ObtenerEtiquetaArea() =>               "Area";

        public Dictionary<string, (string Singular, string Plural)> ObtenerNombresFormas() =>
            new Dictionary<string, (string Singular, string Plural)>
            {
                { "Cuadrado",   ("Quadrato",  "Quadrati") },
                { "Circulo",    ("Cerchio",   "Cerchi") },
                { "Triangulo",  ("Triangolo", "Triangoli") },
                { "Rectangulo", ("Rettangolare", "Rettangolare") },
                { "Trapecio",   ("Trapezio",  "Trapezi") }
            };
    }
}
