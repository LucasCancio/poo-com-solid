using System;

namespace Projeto_Exercicio2_Resultado
{
    public class ConsoleLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
