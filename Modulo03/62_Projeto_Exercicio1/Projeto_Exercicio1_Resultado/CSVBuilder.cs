using System.Collections.Generic;
using System.Text;

namespace Projeto_Exercicio1_Resultado
{
    public class CSVBuilder
    {
        public static string ExportarCSV(List<object> dados)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var dado in dados)
            {
                sb.AppendFormat(dado.ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}