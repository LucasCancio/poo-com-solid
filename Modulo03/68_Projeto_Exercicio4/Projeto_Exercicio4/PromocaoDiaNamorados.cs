namespace Projeto_Exercicio4
{
    public class PromocaoDiaNamorados : IPromocao
    {
        public double PorcentagemDesconto(Produto produto)
        {
            if (produto is Celular)
            {
                return 0.7;
            }

            return 0.2;
        }
    }
}