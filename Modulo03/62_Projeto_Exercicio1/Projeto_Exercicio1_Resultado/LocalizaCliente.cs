namespace Projeto_Exercicio1_Resultado
{
    public class LocalizaCliente
    {
        public static Cliente ProcuraPorPais(string pais)
        {
            var resultado = ClienteRepositorio.GetClientes().Find(n => n.Pais == pais);
            return resultado;
        }
        public static Cliente ProcuraPorNome(string nome)
        {
            var resultado = ClienteRepositorio.GetClientes().Find(n => n.Nome == nome);
            return resultado;
        }
    }
}
