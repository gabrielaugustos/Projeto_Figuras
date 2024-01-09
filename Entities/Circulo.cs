using System;
using Project3.Entities.Enums;

namespace Project3.Entities
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double radio, Color color) : base(color)
        {
            Raio = radio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
