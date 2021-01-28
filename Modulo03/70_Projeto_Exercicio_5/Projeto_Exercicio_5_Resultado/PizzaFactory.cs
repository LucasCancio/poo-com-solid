using System;

namespace Projeto_Exercicio_5_Resultado
{
    public static class PizzaFactory
    {
        public static Pizza CriarPizza(TiposPizzas tipo, string nome)
        {
            Pizza pizza;
            switch (tipo)
            {
                case TiposPizzas.Calabresa:
                    pizza = new PizzaCalabresa(nome);
                    break;
                case TiposPizzas.Mussarela:
                    pizza = new PizzaMussarela(nome);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return pizza;
        }
    }
}