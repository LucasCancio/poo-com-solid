namespace Exercicio10
{
    public class Program
    {
        public static void Executar()
        {
            var peixe = new Peixe("Sardinha");
            peixe.Mover();

            var ave = new Ave("Gaivota");
            ave.Mover();
        }
    }
}