using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_Modulo1.Classes.Exercicios10
{
    class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
    }
    class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
    }
}
