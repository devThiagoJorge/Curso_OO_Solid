using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2_Mod2_Agregacao
{
    class Department : IDisposable
    {
        public string Nome { get; set; }
        public List<Professor> Professores { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
