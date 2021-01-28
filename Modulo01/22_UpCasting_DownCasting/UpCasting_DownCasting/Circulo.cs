using System;

namespace UpCasting_DownCasting
{
    public class Circulo : Forma
    {
        public int MyProperty { get; set; }
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar Circulo");
        }
        public void PintarCirculo()
        {
            Console.WriteLine("Pintando o círculo");
        }
    }
}
