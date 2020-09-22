using System;

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Name = "Thiago Jorge";
            pessoa.Age = 20;

            pessoa.SayHello();
        }
    }
}
