using System;

namespace Aula_2_Construtores
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            var pessoa = new Pessoa(name, age);

            pessoa.SayHello();
        }
    }
}
