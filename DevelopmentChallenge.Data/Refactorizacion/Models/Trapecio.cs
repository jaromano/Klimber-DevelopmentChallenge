using System;

namespace DevelopmentChallenge.Data.Refactorizacion.Models
{
    public class Trapecio : FormaBase
    {
        private readonly decimal _ladoSuperior;
        private readonly decimal _altura;

        public Trapecio(decimal ladoInferior, decimal ladoSuperior, decimal altura)
            : base(ladoInferior, "Trapecio")
        {
            _ladoSuperior = ladoSuperior;
            _altura = altura;
        }

        public override decimal CalcularArea() => (_lado + _ladoSuperior) * _altura / 2;

        public override decimal CalcularPerimetro()
        {
            var ladoLateral = (decimal)Math.Sqrt((double)((_lado - _ladoSuperior) * (_lado - _ladoSuperior) + 4 * _altura * _altura)) / 2;
            return _lado + _ladoSuperior + 2 * ladoLateral;
        }
    }
}
