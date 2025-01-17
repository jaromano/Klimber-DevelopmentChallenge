using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Refactorizacion.Models
{
    public class Rectangulo : FormaBase
    {
        private decimal _ancho;

        public Rectangulo(decimal largo, decimal ancho) : base(largo, "Rectangulo")
        {
            _ancho = ancho;
        }

        public override decimal CalcularArea() => _lado * _ancho; 
        public override decimal CalcularPerimetro() => 2 * (_lado + _ancho); 
    }
}
