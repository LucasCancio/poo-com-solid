using System;
namespace Exercicios
{
    public class Exercicio9
    {
        public static void ExecutarExercicio()
        {
            Console.WriteLine("\n --Exercicio 9-- \n");
            Console.WriteLine(Soma.Somar(1, 2));
            Console.WriteLine(Soma.Somar(1, 2, 3));
            Console.WriteLine(Soma.Somar(1, 2, 3, 4));
        }
    }

    class Soma
    {
        public static int Somar(int numero1, int numero2, int numero3 = 0, int numero4 = 0)
        {
            return numero1 + numero2 + numero3 + numero4;
        }
    }
}