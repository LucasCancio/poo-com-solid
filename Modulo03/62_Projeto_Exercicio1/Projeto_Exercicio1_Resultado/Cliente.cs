namespace Projeto_Exercicio1_Resultado
{
    public class Cliente
    {

        public Cliente(string nome, string pais, string email)
        {
            this.Nome = nome;
            this.Pais = pais;
            this.Email = email;

        }
        public string Nome { get; private set; }
        public string Pais { get; private set; }
        public string Email { get; private set; }

        public override string ToString()
        {
            return $"{this.Nome},{this.Pais},{this.Email}";
        }
    }
}
