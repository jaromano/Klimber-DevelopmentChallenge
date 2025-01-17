using DevelopmentChallenge.Data.Refactorizacion.Enums;
using DevelopmentChallenge.Data.Refactorizacion.Interfaces;
using DevelopmentChallenge.Data.Refactorizacion.Services.Idiomas;
using System;

namespace DevelopmentChallenge.Data.Refactorizacion.Factories
{
    public static class FabricaProveedorIdioma
    {
        public static IProveedorIdioma Crear(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Espanol:
                    return new ProveedorEspanol();
                case Idioma.Ingles:
                    return new ProveedorIngles();
                case Idioma.Italiano:
                    return new ProveedorItaliano();
                case Idioma.Portugues:
                    return new ProveedorPortugues();
                default:
                    throw new ArgumentException("Idioma no soportado", nameof(idioma));
            }
        }
    }
}
