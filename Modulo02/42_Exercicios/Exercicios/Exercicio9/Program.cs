namespace Exercicio9
{
    public static class Program
    {
        public static void Executar()
        {
            var transacao = new Transacao();
            transacao.Conectar();
            transacao.Executa();
            transacao.Imprimir();
        }
    }
}