﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Heranca
{
    class ContaCorrente : Conta
    {
        public double Limite { get; set; }
        public double DescontoJuros(double valorDesconto)
        {
            return Saldo - valorDesconto;
        }
    }
}
