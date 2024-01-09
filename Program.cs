using Project3.Entities;
using Project3.Entities.Enums;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List<Figura> list = new List<Figura>();
        Console.Write("Entre com a quantidade de figuras: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Figura {i}");
            Console.Write("Retangulo, Triangulo ou Circulo (r/t/c)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Cor (Preto/Azul/Vermelho): ");
            Color cor = Enum.Parse<Color>(Console.ReadLine());
            if (ch == 'r')
            {
                Console.Write("Largura: ");
                double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Retangulo(largura, altura, cor));
            }
            else if (ch == 't')
            {
                Console.Write("Base: ");
                double base_ = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Triangulo(base_, altura, cor));
            }
            else
            {
                Console.Write("Raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Circulo(raio, cor));
            }

        }

        Console.WriteLine();
        Console.WriteLine("Area da Figura");
        foreach (Figura figura in list)
        {
            Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}