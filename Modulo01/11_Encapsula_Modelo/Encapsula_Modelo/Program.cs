﻿using System;

namespace Encapsula_Modelo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteRico cliente = new ClienteRico(-1,"", null);
               
            Console.WriteLine($"{cliente.Id} {cliente.Nome} {cliente.Endereco}");
            Console.ReadLine();
        }

        private static ClienteAnemico ClienteAnemicoTeste()
        {
            ClienteAnemico cliente = new ClienteAnemico();
            cliente.Id = -1;
            cliente.Nome = "";
            cliente.Endereco = null;
            return cliente;
        }
    }
}
