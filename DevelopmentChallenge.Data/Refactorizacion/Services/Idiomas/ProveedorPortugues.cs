using System.Collections.Generic;
using DevelopmentChallenge.Data.Refactorizacion.Interfaces;

namespace DevelopmentChallenge.Data.Refactorizacion.Services.Idiomas
{
    public class ProveedorPortugues : IProveedorIdioma
    {
        public string ObtenerTituloReporte() =>              "Relatório de Formas";
        public string ObtenerMensajeListaVacia() =>          "Lista vazia de formas!";
        public string ObtenerEtiquetaTotal() =>              "TOTAL:";
        public string ObtenerEtiquetaFormas(int cantidad) => "formas";
        public string ObtenerEtiquetaPerimetro() =>          "Perímetro";
        public string ObtenerEtiquetaArea() =>               "Área";

        public Dictionary<string, (string Singular, string Plural)> ObtenerNombresFormas() =>
            new Dictionary<string, (string Singular, string Plural)>
            {
                { "Cuadrado",  ("Quadrado", "Quadrados") },
                { "Circulo",   ("Círculo", "Círculos") },
                { "Triangulo", ("Triângulo", "Triângulos") },
                { "Rectangulo", ("Retângulo", "Retângulo") },
                { "Trapecio",  ("Trapézio", "Trapézios") }
            };
    }
}
