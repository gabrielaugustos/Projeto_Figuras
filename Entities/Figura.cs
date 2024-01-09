using Project3.Entities.Enums;

namespace Project3.Entities
{
    abstract class Figura
    {
        public Color Color { get; set; }

        public Figura(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
