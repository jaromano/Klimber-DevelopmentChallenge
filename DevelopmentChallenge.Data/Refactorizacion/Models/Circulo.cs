using System;

namespace DevelopmentChallenge.Data.Refactorizacion.Models
{
    public class Circulo : FormaBase
    {
        public Circulo(decimal radio) : base(radio, "Circulo") { }
        public override decimal CalcularArea() => (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        public override decimal CalcularPerimetro() => (decimal)Math.PI * _lado;
    }
}
