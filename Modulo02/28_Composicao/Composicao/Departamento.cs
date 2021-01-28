﻿using System;

namespace Composicao
{
    class Departamento : IDisposable
    {
        private Escola escola;
        private string nome;
        internal Departamento(Escola escola, string nome)
        {
            this.escola = escola;
            this.nome = nome;
        }
        public void Dispose()
        {
            // Destroi o departamento
        }
    }
}
