using System;

namespace Paulo_Dias_TP1
{
    class Greetings
    {
        public void Greeting(string idioma, string nome)
        {

            Action<string> action;

            switch (idioma.ToLower())
            {
                case "pt":
                    action = MensagemPortugues;
                    break;
                case "en":
                    action = MensagemIngles;
                    break;
                case "es":
                    action = MensagemEspanhol;
                    break;
                default:
                    action = MensagemPortugues;
                    break;
            }

            action(nome);

        }

        static void MensagemPortugues(String nome)
        {
            Console.WriteLine($"\nBem vindo, {nome}!");
        }

        static void MensagemIngles(String nome)
        {
            Console.WriteLine($"\nWelcome {nome}!");
        }

        static void MensagemEspanhol(String nome)
        {
            Console.WriteLine($"\n¡Bienvenido {nome}!");
        }

    }
}
