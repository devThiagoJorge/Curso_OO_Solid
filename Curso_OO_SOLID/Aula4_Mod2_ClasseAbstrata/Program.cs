using Aula4_Mod2_ClasseAbstrata.Classes;
using System;

namespace Aula4_Mod2_ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new Quadrado();

            Console.WriteLine(q.Descricao());

            Console.WriteLine("Informe a cor da figura: ");
            q.Cor = Console.ReadLine();

            Console.WriteLine("Informe o lado do quadrado: ");
            q.Lado = int.Parse(Console.ReadLine());

            q.CalcularArea();
            q.CalcularPerimetro();

            Console.WriteLine($"A área do quadrado é: {q.Area} m2");
            Console.WriteLine($"O perimetro do quadrado é: {q.Perimetro} m");
            Console.WriteLine($"O quadrado tem a cor: {q.Cor}");
        }
    }
}
