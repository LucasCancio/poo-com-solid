using System;

namespace Interface_Desacopla
{
    class RegistraOcorrencias
    {
        private readonly IRegistro _registro;

        public RegistraOcorrencias(IRegistro registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistraInfo($"{mensagem} : {DateTime.Now}");
        }
    }
}
