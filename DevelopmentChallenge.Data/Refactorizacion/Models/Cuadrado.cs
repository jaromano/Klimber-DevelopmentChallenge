namespace DevelopmentChallenge.Data.Refactorizacion.Models
{
    public class Cuadrado : FormaBase
    {
        public Cuadrado(decimal lado) : base(lado, "Cuadrado") { }

        public override decimal CalcularArea() => _lado * _lado;
        public override decimal CalcularPerimetro() => _lado * 4;
    }
}
