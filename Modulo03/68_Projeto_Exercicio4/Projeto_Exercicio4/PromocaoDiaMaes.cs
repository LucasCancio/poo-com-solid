namespace Projeto_Exercicio4
{
    public class PromocaoDiaMaes : IPromocao
    {

        public double PorcentagemDesconto(Produto produto)
        {
            if (produto is Perfume)
            {
                return 0.5;
            }

            return 0.1;
        }
    }
}