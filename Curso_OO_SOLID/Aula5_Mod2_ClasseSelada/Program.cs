using System;

namespace Aula5_Mod2_ClasseSelada
{
    class Program
    {
        public sealed class CalculaSoma
        {
            public int Somar(int n1, int n2)
            {
                return n1 + n2;
            }
        }

        //class Calculadora  : CalculaSoma
        //{
          
        //}
        static void Main(string[] args)
        {
            CalculaSoma soma = new CalculaSoma();

            Console.WriteLine(soma.Somar(10, 20)); 

        }
    }
}
