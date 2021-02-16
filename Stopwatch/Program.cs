using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("********** Cronômetro **********");
                Console.WriteLine("(S) Segundos => 10s = 10 segundos");
                Console.WriteLine("(M) Minutos =>   1m = 1  minuto");
                Console.WriteLine("(00) Sair\n");
                Console.WriteLine("Quanto tempo deseja contar?");

                string data = Console.ReadLine().ToLower(); // o ToLower converte tudo que foi digitado para minusculo
                char type = char.Parse(data.Substring(data.Length-1, 1)); // data.Substring(1, 1): Pega a partir da posição 1 de data 1 caracter. data.Length-1 pega o último caractere.
                int time = int.Parse(data.Substring(0, data.Length-1));
                // Console.WriteLine(data);
                // Console.WriteLine(type);
                // Console.WriteLine(time);
                int multiplier = 1;

                if(type == 's' || type == 'm')
                {
                    if (type == 'm')
                        multiplier = 60;

                    PreStart(time * multiplier);
                }
                else
                {
                    if (time == 00)
                        System.Environment.Exit(0);

                    Console.WriteLine("*** Opção Inválida ***");
                    Thread.Sleep(2000);
                    Menu();
                }   
            }
            catch
            {
                Console.WriteLine("*** Opção Inválida ***");
                Thread.Sleep(2000);
                Menu();
            }
            

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Read...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
