using DevelopmentChallenge.Data.Refactorizacion.Interfaces;

namespace DevelopmentChallenge.Data.Refactorizacion.Models
{
    public abstract class FormaBase : IFormaGeometrica
    {
        protected readonly decimal _lado;
        protected readonly string _claveForma;

        protected FormaBase(decimal lado, string claveForma)
        {
            _lado = lado;
            _claveForma = claveForma;
        }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();

        public string ObtenerNombre(IProveedorIdioma proveedorIdioma, int cantidad)
        {
            var nombres = proveedorIdioma.ObtenerNombresFormas()[_claveForma];
            return cantidad == 1 ? nombres.Singular : nombres.Plural;
        }
    }
}
