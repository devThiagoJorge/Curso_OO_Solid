using Exercicios_Modulo1.Classes.Exercicio1;
using Exercicios_Modulo1.Classes.Exercicio8;
using Exercicios_Modulo1.Classes.Exercicio9;
using Exercicios_Modulo1.Classes.Exercicios10;
using System;

namespace Exercicios_Modulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o exercicio");
            int exercice = int.Parse(Console.ReadLine());

            switch (exercice)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                case 3:
                    Exercicio2();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 7:
                    Exercicio7();
                    break;
                case 8:
                    Exercicio8();
                    break;
                case 9:
                    Exercicio9();
                    break;
                case 10:
                    Exercicio10();
                    break;
                default:
                    Console.WriteLine("Nada a mostrar.");
                    break;
            }
        }

        public static void Exercicio1()
        {
            Pergunta("1- Defina o que é classe e o que é objeto e como podemos cria-los na linguagem C#.");

            Resposta("Classe: Podemos definir classe como um molde para a criação de objetos, ou seja é a abstração\n" +
                "Objeto: Seria a instância da classe, ou seja damos vida a classe é criada no tempo de execução. Para criar basta usarmos a palavra new.");

          

            Employee employee = new Employee();

            employee.Name = "Thiago";
            employee.Age = 20;

            Exemplo($"Exemplo de uma classe:\nName:{employee.Name}\nAge:{employee.Age}");

        }

        public static void Exercicio2()
        {
            Pergunta("Como você define o conceito de abstração usado no paradigma da Programação orientada a objetos ?");
            Resposta("Abstração pode ser definido como capacidade em abstrair como vai ser o objeto, ou seja, pegar o problema da vida real e passar para código.");

            Exemplo("Exemplo pessoa, uma pessoa ela tem várias caracteristicas, como por exemplo: nome, idade, cor do cabelo, etc... Ou seja atributos que caracterizam uma pessoa. E ela faz açoes: comer, correr, pular. A abstração trabalha em cima disso tentar entender como funciona o objeto em análise.");

        }

        public static void Exercicio4()
        {
            Pergunta("O que é encapsulamento e quais são os seus benefícios?");
            Resposta("Encapsulamento é a capacidade de esconder a implementação da classe, as suas vantagens são: maior controle do que pode ser acessado ou não. *Envolve os modificadores de acessos!");
        }

        public static void Exercicio5()
        {
            Pergunta("Quando um construtor de uma classe é chamado?");
            Resposta("O construtor é chamado assim quando a classe é instanciada. / Objeto criado");
        }
        public static void Exercicio6()
        {
            Pergunta("Se você criar 5 objetos de uma classe, quantas vezes o construtor da classe será chamado?");
            Resposta("O construtor será chamado 5 vezes.");

            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Employee e4 = new Employee();
            Employee e5 = new Employee();
        }

        public static void Exercicio7()
        {
            Pergunta("Por que você usa um construtor?");
            Resposta("Constutor serve para iniciar um objeto, então usamos para forçar que o objeto ao ser instanciado já tenha algumas regras...");
        }

        public static void Exercicio8()
        {
            Pergunta("Crie uma classe para calcular a soma de até 2 números inteiros e/ou reais usando o  " +
                "conceito de sobrecarga de métodos.Se nenhum valor for informado retorne a mensagem" +
                "“Nenhum valor informado”");

            Sum sum = new Sum();

            Resposta(sum.SumNumbers(5,3).ToString());
            Resposta(sum.SumNumbers(10.4, 1.6).ToString());
        }

        public static void Exercicio9()
        {
            Pergunta("Crie uma classe para calcular a soma de até 4 números inteiros usando o conceito de parâmetros opcionais.");

            Resposta(SumOptionals.Sum(1,2,3).ToString());
        }

        public static void Exercicio10()
        {
            Pergunta("Qual o conceito de herança? Dê um exemplo");
            Resposta("Herança pode ser entendido como literalmente uma classe filha herdar os atributos / metódos de uma classe pai.");

            PessoaFisica pessoaFisica = new PessoaFisica();

            pessoaFisica.Name = "Thiago";
            pessoaFisica.Age = 20;
            pessoaFisica.CPF = "4897130490";

            PessoaJuridica pessoaJuridica = new PessoaJuridica();

            pessoaJuridica.Name = "Thiago";
            pessoaJuridica.Age = 20;
            pessoaJuridica.CNPJ = "4897130490";

        }
        public static void Pergunta(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n\n\n{message}");
            Console.ResetColor();
        }
        public static void Resposta(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\n\n\n{message}");
            Console.ResetColor();
        }

        public static void Exemplo(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n\n\n{message}");
            Console.ResetColor();
        }
    }
}
