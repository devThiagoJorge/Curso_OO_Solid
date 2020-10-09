using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1_Mod2_Composicao
{
    class Department : IDisposable
    {
        private School School { get; set; }
        private string Name { get; set; }

        internal Department(School school, string name)
        {
            School = school;
            Name = name;
        }

        public void Dispose()
        {
            // Destroy Department
        }
    }
}
