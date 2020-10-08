using System;

namespace Aula_7_Herança
{
    class Program
    {
       
        class Conta{
            public int Numero { get; set; }
            public double Saldo { get; set; }
            public Conta()
            {
                Console.WriteLine("Construtor também é executado...");
            }
            private void MetodoPrivado()
            {
                Console.WriteLine("Privado não pode ser herdado");
            }
            protected void MetodoProtected()
            {
                Console.WriteLine("Protected pode ser herdado");
            }

            public virtual void MetodoComOverride()
            {
                Console.WriteLine("Aqui vem qualquer coisa");
            }
        }

        class ContaPoupanca : Conta
        {
            public double JurosMensais { get; set; }

            public override void MetodoComOverride()
            {
                Console.WriteLine("Sobrescrevi o método!");
            }

            static void Main(string[] args)
            {
                var contaPoupanca = new ContaPoupanca();


                //contaPoupanca.MetodoPrivado(); // aqui dá erro porq o metodo é privado; 
                contaPoupanca.MetodoProtected();
                contaPoupanca.MetodoComOverride();
              
            }
        }
    }
}
