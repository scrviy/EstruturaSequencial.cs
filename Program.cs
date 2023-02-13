using System;
using System.Globalization;

namespace EstruturaSequencial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine($"Área = {area.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Preço = {preco.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}