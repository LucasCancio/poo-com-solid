﻿using System;

namespace Acoplamento_Composicao
{
    class Gato
    {
        Animal gato = new Animal();
        ComportamentoAndar andar = new ComportamentoAndar();
        public void Miau()
        {
            Console.WriteLine("miau...");
        }
    }
}
