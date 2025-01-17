using System;
using System.Linq;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Refactorizacion.Enums;
using DevelopmentChallenge.Data.Refactorizacion.Factories;
using DevelopmentChallenge.Data.Refactorizacion.Interfaces;
using DevelopmentChallenge.Data.Refactorizacion.Services;


namespace DevelopmentChallenge.Data.Refactorizacion.Models
{
    public class FormaGeometrica
    {
        private readonly decimal _lado;
        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var formasGeometricas = formas.Select(f => f.ConvertirAFormaGeometrica()).ToList();

            Idioma idiomaSeleccionado;
            switch (idioma)
            {
                case 1:
                    idiomaSeleccionado = Idioma.Espanol;
                    break;
                case 2:
                    idiomaSeleccionado = Idioma.Ingles;
                    break;
                case 3:
                    idiomaSeleccionado = Idioma.Italiano;
                    break;
                case 4:
                    idiomaSeleccionado = Idioma.Portugues;
                    break;
                default:
                    throw new ArgumentException("Idioma no soportado", nameof(idioma));
            }

            var proveedorIdioma = FabricaProveedorIdioma.Crear(idiomaSeleccionado);
            var generador = new GeneradorReportes(proveedorIdioma);
            return generador.GenerarReporte(formasGeometricas);
        }

        public IFormaGeometrica ConvertirAFormaGeometrica()
        {
            switch (Tipo)
            {
                case 1:
                    return new Cuadrado(_lado);
                case 2:
                    return new Triangulo(_lado);
                case 3:
                    return new Circulo(_lado);
                case 4:
                    return new Trapecio(_lado, _lado * 0.8m, _lado * 0.5m); // Valoress por defecto para el trapecio
                case 5:
                    return new Rectangulo(_lado, _lado +1); // Valores por defecto para el rectangulo
                default:
                    throw new ArgumentOutOfRangeException($"Forma desconoccida: {Tipo}");
            }
        }
    }
}
