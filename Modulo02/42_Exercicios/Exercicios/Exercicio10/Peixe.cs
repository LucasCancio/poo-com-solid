using System;
namespace Exercicio10
{
    public class Peixe : Animal
    {
        public Peixe(string tipo) : base(tipo)
        {
        }

        public override void Mover()
        {
            Console.WriteLine($"O Peixe {Tipo} está nadando...");
        }
    }
}