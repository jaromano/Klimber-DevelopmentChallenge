using System;
using NUnit.Framework;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Refactorizacion.Enums;
using DevelopmentChallenge.Data.Refactorizacion.Factories;
using DevelopmentChallenge.Data.Refactorizacion.Interfaces;
using DevelopmentChallenge.Data.Refactorizacion.Models;
using DevelopmentChallenge.Data.Refactorizacion.Services;
using DevelopmentChallenge.Data.Refactorizacion.Services.Idiomas;


namespace DevelopmentChallenge.Data.Tests.Refactorizacion
{
    [TestFixture]
    public class RefactorizacionDataTests
    {
        [TestCase(1, "Lista vacía de formas!")]
        [TestCase(2, "Empty list of shapes!")]
        [TestCase(3, "Lista vuota di forme!")]
        [TestCase(4, "Lista vazia de formas!")]
        public void TestResumenListaVacia(int idiomaId, string mensajeEsperado)
        {
            Assert.That(FormaGeometrica.Imprimir(new List<FormaGeometrica>(), idiomaId),
                       Is.EqualTo($"<h1>{mensajeEsperado}</h1>"));
        }

        [TestCase(5, 25)]
        [TestCase(3, 9)]
        [TestCase(4, 16)]
        public void TestCuadradoArea(decimal lado, decimal areaEsperada)
        {
            var cuadrado = new Cuadrado(lado);
            Assert.That(cuadrado.CalcularArea(), Is.EqualTo(areaEsperada));
        }

        [TestCase(5, 20)]
        [TestCase(3, 12)]
        [TestCase(4, 16)]
        public void TestCuadradoPerimetro(decimal lado, decimal perimetroEsperado)
        {
            var cuadrado = new Cuadrado(lado);
            Assert.That(cuadrado.CalcularPerimetro(), Is.EqualTo(perimetroEsperado));
        }


        [TestCase(5,2,10)]
        [TestCase(3,9,27)]
        [TestCase(4,5,20)]
        public void TestRectanguloArea(decimal lado, decimal alto,decimal areaEsperada)
        {
            var rectangulo = new Rectangulo(lado,alto);
            Assert.That(rectangulo.CalcularArea(), Is.EqualTo(areaEsperada));
        }

        [TestCase(5, 2, 14)]
        [TestCase(3, 9, 24)]
        [TestCase(4, 5, 18)]
        public void TestRectanguloPerimetro(decimal lado, decimal alto, decimal perimetroEsperado)
        {
            var rectangulo = new Rectangulo(lado, alto);
            Assert.That(rectangulo.CalcularPerimetro(), Is.EqualTo(perimetroEsperado));
        }


        [TestCase(5, 10.825)]
        [TestCase(3, 3.897)]
        [TestCase(4, 6.928)]
        public void TestTrianguloArea(decimal lado, decimal areaEsperada)
        {
            var triangulo = new Triangulo(lado);
            Assert.That(decimal.Round(triangulo.CalcularArea(), 3), Is.EqualTo(areaEsperada));
        }

        [TestCase(5, 15)]
        [TestCase(3, 9)]
        [TestCase(4, 12)]
        public void TestTrianguloPerimetro(decimal lado, decimal perimetroEsperado)
        {
            var triangulo = new Triangulo(lado);
            Assert.That(triangulo.CalcularPerimetro(), Is.EqualTo(perimetroEsperado));
        }

        [TestCase(3, 7.069)]
        [TestCase(5, 19.635)]
        [TestCase(4, 12.566)]
        public void TestCirculoArea(decimal radio, decimal areaEsperada)
        {
            var circulo = new Circulo(radio);
            Assert.That(decimal.Round(circulo.CalcularArea(), 3), Is.EqualTo(areaEsperada));
        }

        [TestCase(3, 9.425)]
        [TestCase(5, 15.708)]
        [TestCase(4, 12.566)]
        public void TestCirculoPerimetro(decimal radio, decimal perimetroEsperado)
        {
            var circulo = new Circulo(radio);
            Assert.That(decimal.Round(circulo.CalcularPerimetro(), 3), Is.EqualTo(perimetroEsperado));
        }

        [TestCase(6, 4, 4, 20)]
        [TestCase(8, 6, 5, 35)]
        [TestCase(10, 8, 6, 54)]
        public void TestTrapecioArea(decimal baseInferior, decimal baseSuperior, decimal altura, decimal areaEsperada)
        {
            var trapecio = new Trapecio(baseInferior, baseSuperior, altura);
            Assert.That(trapecio.CalcularArea(), Is.EqualTo(areaEsperada));
        }

        [TestCase(6, 4, 4, 18.246)]
        [TestCase(8, 6, 5, 24.198)]
        [TestCase(10, 8, 6, 30.166)]
        public void TestTrapecioPerimetro(decimal baseInferior, decimal baseSuperior, decimal altura, decimal perimetroEsperado)
        {
            var trapecio = new Trapecio(baseInferior, baseSuperior, altura);
            Assert.That(decimal.Round(trapecio.CalcularPerimetro(), 3), Is.EqualTo(perimetroEsperado));
        }

        [TestCase(Idioma.Espanol,   "Reporte de Formas", "formas", "Perimetro")]
        [TestCase(Idioma.Ingles,    "Shapes Report", "shapes", "Perimeter")]
        [TestCase(Idioma.Italiano,  "Rapporto delle Forme", "forme", "Perimetro")]
        [TestCase(Idioma.Portugues, "Relatório de Formas", "formas", "Perímetro")]
        public void TestProveedorIdioma(Idioma idioma, string tituloEsperado, string etiquetaFormasEsperada, string etiquetaPerimetroEsperada)
        {
            var proveedor = FabricaProveedorIdioma.Crear(idioma);
            Assert.That(proveedor.ObtenerTituloReporte(), Is.EqualTo(tituloEsperado));
            Assert.That(proveedor.ObtenerEtiquetaFormas(2), Is.EqualTo(etiquetaFormasEsperada));
            Assert.That(proveedor.ObtenerEtiquetaPerimetro(), Is.EqualTo(etiquetaPerimetroEsperada));
        }

        [Test]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(1, 5) };
            var resultado = FormaGeometrica.Imprimir(cuadrados, 1).Replace("\r","").Replace("\n", "");

            var esperado = "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25";
            Assert.That(resultado, Is.EqualTo(esperado));
        }

        [Test]
        public void TestIdiomaInvalidoLanzaExcepcion()
        {
            Assert.Throws<ArgumentException>(() => FabricaProveedorIdioma.Crear((Idioma)999));
        }

        [Test]
        public void TestFormaInvalidaLanzaExcepcion()
        {
            var formaInvalida = new FormaGeometrica(999, 5);
            Assert.Throws<ArgumentOutOfRangeException>(() => formaInvalida.ConvertirAFormaGeometrica());
        }

        [Test]
        public void TestListaVariasFormasEspanol()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(1, 5),  // Cuadrado
                new FormaGeometrica(2, 4),  // Triangulo
                new FormaGeometrica(3, 3),  // Círculo
                new FormaGeometrica(4, 6),  // Trapecio
                new FormaGeometrica(5, 2)   // Rectangulo
            };

            var resultado = FormaGeometrica.Imprimir(formas, 1);
            Assert.That(resultado, Does.Contain("Reporte de Formas"));
            Assert.That(resultado, Does.Contain("Cuadrado"));
            Assert.That(resultado, Does.Contain("Triángulo"));
            Assert.That(resultado, Does.Contain("Círculo"));
            Assert.That(resultado, Does.Contain("Trapecio"));
            Assert.That(resultado, Does.Contain("Rectangulo"));
        }

        [TestCase("Cuadrado", "Cuadrado", "Cuadrados")]
        [TestCase("Circulo", "Círculo", "Círculos")]
        [TestCase("Triangulo", "Triángulo", "Triángulos")]
        [TestCase("Trapecio", "Trapecio", "Trapecios")]
        [TestCase("Rectangulo", "Rectangulo", "Rectangulos")]
        public void TestTraduccionSingularPlural(string clave, string esperadoSingular, string esperadoPlural)
        {
            var proveedorEspanol = new ProveedorEspanol();
            var nombres = proveedorEspanol.ObtenerNombresFormas();

            Assert.That(nombres[clave].Singular, Is.EqualTo(esperadoSingular));
            Assert.That(nombres[clave].Plural, Is.EqualTo(esperadoPlural));
        }
    }
}