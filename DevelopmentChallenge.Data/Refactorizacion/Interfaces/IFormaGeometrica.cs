
namespace DevelopmentChallenge.Data.Refactorizacion.Interfaces
{
    public interface IFormaGeometrica
    {
        decimal CalcularArea();
        decimal CalcularPerimetro();
        string ObtenerNombre(IProveedorIdioma proveedorIdioma, int cantidad);
    }
}
