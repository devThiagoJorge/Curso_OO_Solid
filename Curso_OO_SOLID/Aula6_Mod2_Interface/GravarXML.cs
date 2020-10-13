using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6_Mod2_Interface
{
    class GravarXML : ArquivoBase, IGravar
    {
        public void GerarArquivo()
        {
            throw new NotImplementedException();
        }
        public override void Nome()
        {
            Console.WriteLine("Definir nome");
        }
    }
}
