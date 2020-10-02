using System;

namespace Aula_5_ParametroOpcional
{
    class Program { 
    
        static public int Sum (int num1, int x=10, int y=20, int z=30)
        {
            return num1 + x + y + z;
        }
        static void Main(string[] args)
        {   // caso não especificar o valor é aplicado o padrão;
            int result1 = Sum(100,100,100,100);
            int result2 = Sum(100, 100,100);
            int result3 = Sum(100,100);
            int result4 = Sum(100);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
    }
}
