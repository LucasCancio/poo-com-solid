using System.Collections.Generic;

namespace Projeto_Exercicio1_Resultado
{
    public class ClienteRepositorio
    {
        public static List<Cliente> GetClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>()
            {
                new Cliente(nome: "Pedro", pais: "Brasil", email: "pedro@email.com"),
                new Cliente(nome: "Maria", pais: "Chile", email: "maria@email.com")
            };
            return listaClientes;
        }
    }
}