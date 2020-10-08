using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_Modulo1.Classes.Exercicio1
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Construido...");
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
