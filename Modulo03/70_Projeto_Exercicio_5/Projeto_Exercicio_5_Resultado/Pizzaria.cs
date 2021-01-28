using System;
namespace Projeto_Exercicio_5_Resultado
{
    class Pizzaria
    {
        private Pizza pizza;
        private int NumeroPedido;
        public void CriarPizza(TiposPizzas tipo)
        {
            pizza = PizzaFactory.CriarPizza(tipo, $"Pizza {NumeroPedido}");
            NumeroPedido++;
        }
    }
}
