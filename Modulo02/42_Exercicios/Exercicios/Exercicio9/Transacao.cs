using System;
namespace Exercicio9
{
    public class Transacao : ConectarBancoDados, ITransacao, IRelatorio
    {
        public void Executa()
        {
            Console.WriteLine("Processando Transação...");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo...");
        }
    }
}