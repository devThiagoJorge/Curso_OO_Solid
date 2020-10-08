using System;

namespace Aula_8_AsAndIs
{
    class Program
    {
        static void Main(string[] args)
        {
            //DownCasting: 
            Forma f = new Forma();
            Circulo c = f as Circulo;


            // Down Casting AS
            if (c != null)
                c.PintarCirculo();
            else
                Console.WriteLine("Operação inválida");

            // Down Casting Is

            if (f is Circulo)
                ((Circulo)f).PintarCirculo();   
            else
                Console.WriteLine("Conversão não é possível.");
        }

        class Forma
        {
            public virtual void Desenhar()
            {
                Console.WriteLine("Forma");
            }
        }
        class Circulo : Forma
        {
            public override void Desenhar()
            {
                Console.WriteLine("Desenhando circulo");
            }
            public void PintarCirculo()
            {
                Console.WriteLine("Pintando circulo");
            }
        }
    }
}
