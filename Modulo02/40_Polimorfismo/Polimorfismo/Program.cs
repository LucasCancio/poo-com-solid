using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            var figuras = new List<Figura>
            {
                new Triangulo(),
                new Circulo()
            };

            foreach(var figura in figuras)
            {
                figura.Desenhar();
            }

            Console.ReadLine();
        }
    }
}
