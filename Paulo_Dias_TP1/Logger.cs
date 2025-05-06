using System;
using System.IO;

namespace Paulo_Dias_TP1
{
    public class Logger
    {
        public void LogToConsole(string mensagem)
        {
            Console.WriteLine("[Console] " + mensagem);
        }

        public void LogToFile(string mensagem)
        {
            Console.WriteLine("[Arquivo - Simulado] " + mensagem);
        }

        public void LogToDatabase(string mensagem)
        {
            Console.WriteLine("[Banco - Simulado] Inserido log: " + mensagem);
        }
    }
}
