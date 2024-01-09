using Project3.Entities.Enums;

namespace Project3.Entities
{
    class Retangulo : Figura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Color color) : base(color)
        {
           Largura = largura;
           Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
