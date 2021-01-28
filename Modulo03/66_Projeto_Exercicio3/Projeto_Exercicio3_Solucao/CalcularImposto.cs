using System;
namespace Projeto_Exercicio3_Solucao
{
    public class CalcularImposto
    {
        public static decimal Calcular(decimal valor, decimal deducao, Paises pais)
        {
            decimal valorImposto = 0;
            decimal valorBase = valor - deducao;
            IPaisImposto impostoDoPais;

            switch (pais)
            {
                case Paises.Brazil:
                    impostoDoPais = new ImpostoBrazil();
                    break;
                case Paises.USA:
                    impostoDoPais = new ImpostoUSA();
                    break;
                case Paises.UK:
                    impostoDoPais = new ImpostoUK();
                    break;
                default:
                    throw new NotImplementedException();
            }
            valorImposto = valorBase + impostoDoPais.CalcularImposto();
            return valorImposto;
        }
    }
}
