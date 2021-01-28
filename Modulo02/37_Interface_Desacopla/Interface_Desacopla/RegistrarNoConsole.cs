using System;

namespace Interface_Desacopla
{
    class RegistrarNoConsole : IRegistro
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine($"info : {mensagem}");
        }
    }
}
