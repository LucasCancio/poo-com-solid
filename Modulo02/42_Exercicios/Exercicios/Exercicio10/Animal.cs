namespace Exercicio10
{
    public abstract class Animal
    {
        public Animal(string tipo)
        {
            Tipo = tipo;
        }

        public string Tipo { get; private set; }

        public abstract void Mover();
    }
}