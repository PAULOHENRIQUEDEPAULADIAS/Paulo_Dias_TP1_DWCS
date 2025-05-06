using System;

namespace Paulo_Dias_TP1
{
    internal class Pipeline
    {

        public string Concatenar(string nome, string sobrenome)
        {
            string resultado = $"{nome} {sobrenome}";
            Console.WriteLine("Concatenar: " + resultado);
            return resultado;
        }

        public string ParaMaiusculas(string nomeCompleto, string sobrenome)
        {
            string resultado = nomeCompleto.ToUpper();
            Console.WriteLine("Maiúsculas: " + resultado);
            return resultado;
        }

        public string RemoverEspacos(string nomeCompleto, string sobrenome)
        {
            string resultado = nomeCompleto.Replace(" ", "");
            Console.WriteLine("Sem espaços: " + resultado);
            return resultado;
        }

    }
}
