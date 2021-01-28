using System;

namespace Exercicio10
{
    public class Ave : Animal
    {
        public Ave(string tipo) : base(tipo)
        {
        }

        public override void Mover()
        {
            Console.WriteLine($"A Ave {Tipo} está voando...");
        }
    }
}