using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Heranca
{
    class ContaPoupanca : Conta
    {
        public DateTime DataAniversario { get; set; }
        public double CreditoJuros(double valorJuros)
        {
            return Saldo + valorJuros;
        }
    }
}
