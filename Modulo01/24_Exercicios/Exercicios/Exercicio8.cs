using System;

namespace Exercicios
{
    public class Exercicio8
    {
        public static void ExecutarExercicio()
        {
            Console.WriteLine("\n --Exercicio 8-- \n");
            var calculadora = new Calculadora();
            calculadora.Somar();
            Console.WriteLine(calculadora.Somar(1, 2));
            Console.WriteLine(calculadora.Somar(0, 2));
            Console.WriteLine(calculadora.Somar(0, 0));
            Console.WriteLine(calculadora.Somar(1.2, 2));
        }
    }

    class Calculadora
    {
        public string Somar()
        {
            return "Nenhum valor informado";
        }

        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public double Somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }
    }
}