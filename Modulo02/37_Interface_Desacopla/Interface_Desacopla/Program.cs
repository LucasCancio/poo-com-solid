﻿using System;
namespace Interface_Desacopla
{
    class Program
    {
        static void Main(string[] args)
        {
            var registraOcorrenciasConsole =
                 new RegistraOcorrencias(new RegistrarNoConsole());
            registraOcorrenciasConsole.Registrar("registro console");

            var registraOcorrenciasArquivo =
             new RegistraOcorrencias(new RegistrarNoArquivo(@"c:\dados\teste.txt"));
            registraOcorrenciasArquivo.Registrar("registro arquivo");

            Console.ReadLine();
        }
    }
}
