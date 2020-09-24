using System;

namespace Aula_3_Modelo_Dominio_Rico
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteAnemico cliente = new ClienteAnemico();

            cliente.Id = -40;
            cliente.Name = "";
            Console.WriteLine($"Id: {cliente.Id}\nName: {cliente.Name}");

            ClienteRico clienteRyco = new ClienteRico(10, "Thiago");

            Console.WriteLine($"ID: {clienteRyco.Id} \nNOME: {clienteRyco.Name}");


        }
    }
}
