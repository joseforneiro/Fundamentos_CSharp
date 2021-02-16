using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("********** Calculadora **********");
            Console.WriteLine("(1) Soma");
            Console.WriteLine("(2) Subtração");
            Console.WriteLine("(3) Multiplicação");
            Console.WriteLine("(4) Divisão");
            Console.WriteLine("(5) Sair");
            Console.WriteLine("*********************************");
            Console.WriteLine("Opção:");
            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Exit(); break;
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}");
            // Console.WriteLine($"O resultado da soma é {v1 + v2}");
            // Console.WriteLine("O resultado da soma é " + (v1 + v2));

            Console.ReadKey(); // Usado para náo sair da tela no final da execução

            Menu();
        }

        static void Subtracao()
        {
             Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            
            Console.WriteLine($"O resultado da subtração é {resultado}");

            Console.ReadKey(); // Usado para náo sair da tela no final da execução

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.ReadKey(); // Usado para náo sair da tela no final da execução
            
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.ReadKey(); // Usado para náo sair da tela no final da execução

            Menu();
        }

        static void Exit()
        {
            Console.Clear();

            Console.WriteLine("***************************");
            Console.WriteLine("*** Programa Finalizado ***");
            Console.WriteLine("***************************");

            Console.ReadKey();
            
            System.Environment.Exit(0);
        } 

    }
}
