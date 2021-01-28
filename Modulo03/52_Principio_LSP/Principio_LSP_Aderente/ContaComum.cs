using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_LSP_Aderente
{
    class ContaComum : Conta
    {
        public override double Saldo { get; set ; }
        public void Saque(double valor)
        {
            Saldo -= valor;
        }
    }
}
