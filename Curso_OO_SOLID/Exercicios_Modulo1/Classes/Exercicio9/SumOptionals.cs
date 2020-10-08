using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_Modulo1.Classes.Exercicio9
{
    class SumOptionals
    {
        public static int Sum(int num1 = 0, int num2 = 0, int num3 = 0, int num4 = 0)
        {
            return num1 + num2 + num3 + num4;
        }
    }
}
