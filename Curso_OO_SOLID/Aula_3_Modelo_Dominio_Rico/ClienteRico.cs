using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3_Modelo_Dominio_Rico
{
    class ClienteRico
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public ClienteRico(int id, string name)
        {
            DomainException.When(id < 0, "Id inválido");
            DomainException.When(string.IsNullOrEmpty(name), "Nome vazio");

            Id = id;
            Name = name;
        }
    }
}
