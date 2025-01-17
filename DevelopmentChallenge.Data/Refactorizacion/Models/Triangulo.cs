using System;

namespace DevelopmentChallenge.Data.Refactorizacion.Models
{
    public class Triangulo : FormaBase
    {
        public Triangulo(decimal lado) : base(lado, "Triangulo") { }

        public override decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        public override decimal CalcularPerimetro() => _lado * 3;
    }
}
