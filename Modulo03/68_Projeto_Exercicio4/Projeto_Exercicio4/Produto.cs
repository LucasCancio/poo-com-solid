namespace Projeto_Exercicio4
{
    public abstract class Produto
    {
        protected Produto(double preco)
        {
            Preco = preco;
        }

        public double Preco { get; private set; }
        public virtual double PrecoNaPromocao(IPromocao promocao)
        {
            return this.Preco - (this.Preco * promocao.PorcentagemDesconto(this));
        }
    }
}