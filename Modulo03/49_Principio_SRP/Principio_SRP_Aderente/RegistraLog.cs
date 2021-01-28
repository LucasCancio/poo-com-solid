using System;

namespace Principio_SRP_Aderente
{
    class RegistraLog : Ilogger
    {
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}
