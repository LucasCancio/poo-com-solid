using System;

namespace Projeto_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto celular = new Celular(100);
            Produto perfume = new Perfume(200);

            Console.WriteLine($"Perfume: {perfume.Preco}");
            Console.WriteLine($"Perfume no dia das mães: {perfume.PrecoNaPromocao(new PromocaoDiaMaes())}");
            Console.WriteLine($"Perfume no dia dos namorados: {perfume.PrecoNaPromocao(new PromocaoDiaNamorados())}");

            Console.WriteLine("\n");

            Console.WriteLine($"Celular: {celular.Preco}");
            Console.WriteLine($"Celular no dia das mães: {celular.PrecoNaPromocao(new PromocaoDiaMaes())}");
            Console.WriteLine($"Celular no dia dos namorados: {celular.PrecoNaPromocao(new PromocaoDiaNamorados())}");
        }
    }
}
