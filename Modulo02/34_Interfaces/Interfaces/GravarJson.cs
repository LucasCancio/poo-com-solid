﻿using System;

namespace Interfaces
{
    class GravarJson : ArquivoBase, IGravar
    {
        public void GravarArquivo()
        {
            Console.WriteLine("Gravar arquivo em GravarJson");
        }
        public override void Nome()
        {
            Console.WriteLine("Definir nome em GravarJson");
        }
    }
}
