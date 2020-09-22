using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_2_Construtores
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // constructor padrão
        public Pessoa()
        {

        }
        // construtor com parâmento
        public Pessoa(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // ocorre uma sobrecarga metodos iguais com
        // parâmentros diferentes;
        public void SayHello()
        {
            Console.WriteLine($"Hello {Name}, {Age} yo.");
        }
    }
}
