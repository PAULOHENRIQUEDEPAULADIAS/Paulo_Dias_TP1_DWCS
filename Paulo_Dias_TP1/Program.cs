using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Paulo_Dias_TP1.ECommerce;



namespace Paulo_Dias_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***** Menu inicial *****\n\n");
                Console.WriteLine("01 - Calcular desconto de 10%");
                Console.WriteLine("02 - Mensagem de boas vindas");
                Console.WriteLine("03 - Cálculo de Área Utilizando Func");
                Console.WriteLine("04 - Monitoramento de Temperatura com Evento Personalizado");
                Console.WriteLine("05 - Notificação de Conclusão de Download com Eventos");
                Console.WriteLine("06 - Sistema de Registro com Multicast Delegate");
                Console.WriteLine("07 - Garantia de Robustez em Invocação de Delegates");
                Console.WriteLine("08 - Manipulação de Strings com Delegates Encadeados (EX 11)");


                Console.WriteLine("00 - Sair");

                Console.WriteLine("\n\nDigite a numeracao desejada\n");

                if (!int.TryParse(Console.ReadLine(), out int valor))
                {
                    Console.WriteLine("Opcao invalida!");
                    continue;
                }

                if (valor == 0)
                {
                    Console.WriteLine("\nSaindo do sistema ... ");
                    break;
                }
                else if (valor == 1)
                {
                    Console.WriteLine("\nDigite o valor original do produto");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal precoOriginal))
                    {
                        Console.WriteLine("\nValor invalido!");
                        continue;
                    }

                    CalculateDiscount discount = aplicarDescontoDezPorCento;

                    decimal precoComDesconto = discount(precoOriginal);

                    Console.WriteLine($"\nPreco com desconto: R$ {precoComDesconto}\n\n");

                }
                else if (valor == 2)
                {
                    Console.WriteLine("\nDigite seu nome");
                    string nome = Console.ReadLine();

                    Console.WriteLine("\nSelecione o idioma: 'pt', 'en', 'es'");
                    String idioma = Console.ReadLine();

                    Greetings greetings = new Greetings();

                    greetings.Greeting(idioma, nome);

                }
                else if (valor == 3)
                {
                    Console.Write("Digite a base do retângulo: ");
                    if (!double.TryParse(Console.ReadLine(), out double baseRetangulo))
                    {
                        Console.WriteLine("Valor inválido!");
                        return;
                    }

                    Console.Write("Digite a altura do retângulo: ");
                    if (!double.TryParse(Console.ReadLine(), out double alturaRetangulo))
                    {
                        Console.WriteLine("Valor inválido!");
                        return;
                    }

                    Func<double, double, double> calcularArea = AreaRetangulo.CalcularAreaRetangulo;

                    double area = calcularArea(baseRetangulo, alturaRetangulo);
                    Console.WriteLine($"A área do retângulo é: {area:F2}\n\n");

                }
                else if (valor == 4)
                {
                    Temperature sensor = new Temperature();

                    sensor.TemperatureExceeded += sensor.Sensor_TemperatureExceeded;

                    Console.WriteLine("Simulador de Sensor de Temperatura (digite 'sair' para encerrar)");

                    while (true)
                    {
                        Console.Write("Informe a temperatura lida: ");
                        string input = Console.ReadLine();

                        if (input.ToLower() == "sair")
                            break;

                        if (double.TryParse(input, out double temp))
                        {
                            sensor.CheckTemperature(temp);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                    }
                }
                else if (valor == 5)
                {
                    DownloadManager downloader = new DownloadManager();

                    downloader.DownloadCompleted += downloader.AoFinalizarDownload;

                    downloader.IniciarDownload();

                    Console.WriteLine("Clique para finalização...");
                    Console.ReadLine();
                }

                else if(valor == 6)
                {
                    Logger logger = new Logger();

                    Action<string> log = null;
                    log += logger.LogToConsole;
                    log += logger.LogToFile;
                    log += logger.LogToDatabase;

                    log("Usuário efetuou o login no sistema");
                }
                else if (valor == 7)
                {
                    Logger logger = new Logger();

                    Action<string> log = null;

                    /*Comente ou retire comentário mode para verificar a funcionalidade */
                    // log += logger.LogToConsole;
                    log += logger.LogToFile;
                    // log += logger.LogToDatabase;

                    Console.WriteLine("Simulando log...");
                    log?.Invoke("Usuário acessou o sistema.");

                    Console.WriteLine("Encerrado.");
                }
                else if (valor == 8)
                {
                    Pipeline pipeline = new Pipeline();

                    Func<string, string, string> processador = pipeline.Concatenar;

                    processador += pipeline.ParaMaiusculas;
                    processador += pipeline.RemoverEspacos;

                    string resultado = processador("  Paulo ", " Dias  ");

                    Console.WriteLine("Resultado final: " + resultado);
                }

            }
        }
    }
}
