using System;
using Project3.Entities.Enums;

namespace Project3.Entities
{
    class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Triangulo(double base_, double altura, Color color) : base(color)
        {
            Base = base_;
            Altura = altura;
        }

        public override double Area()
        {
            return (Base * Altura) / 2.00;
        }
    }
}
