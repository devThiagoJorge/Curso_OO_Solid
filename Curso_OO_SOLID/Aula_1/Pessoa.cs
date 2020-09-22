using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_1
{
    class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello {Name}, {Age} yo.");
        }
    }
}
