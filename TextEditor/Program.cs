using System;
using System.IO;
using System.Threading;

namespace TextEditor
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

            Console.WriteLine("****** Editor de Textos ******");
            Console.WriteLine("(1) Abrir Arquivo");
            Console.WriteLine("(2) Criar novo Arquivo");
            Console.WriteLine("(0) Sair");
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Qual o caminho do arquivo?");
                string path = Console.ReadLine();

                using(var file = new StreamReader(path)) // Sempre que vamos abrir ou salvar o arquivo, temos que usar o using. Todo o objeto que for aberto dentro de um using, ele irá abrir, usar e fechar o objeto automaticamente.
                {
                    string text = file.ReadToEnd();
                    Console.WriteLine(text);
                }

                Console.WriteLine("");
                Console.ReadLine();
                Menu();
            }
            catch
            {
                Console.WriteLine("\n Caminho inválido. Tente novamente.");
                Thread.Sleep(1000);
                Abrir();
            }


        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo  (ESC para sair)");
            Console.WriteLine("----------------------------------------\n");

            string text = "";  // iremos armazenar tudo que o usuário digitar nessa variável

            do
            {
                text += Console.ReadLine(); // Pega tudo o que o usuário já tinha digitado e acrescenta o que ele digitou agora. Irá ser concatenado os textos.
                text += Environment.NewLine; // Adiciona uma quebra de linha no final de cada leitura.
            }
            
            while(Console.ReadKey().Key != ConsoleKey.Escape); // Repete as duas linhas acima enquanto o usuário não digitar ESC.

            //Console.Write(text); // Exibe o text na tela para verificar se está tudo certo.

            Salvar(text);
        }

        static void Salvar(string text)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("-Qual o caminho para salvar o arquivo?");
                var path = Console.ReadLine();

                // Todo o objeto que for aberto dentro de um using, ele irá abrir, usar e fechar o objeto automaticamente.
                using (var file = new StreamWriter(path)) // StreamWriter = Fluxo de escrita que serve para qualquer tipo de arquivo.
                {
                    file.Write(text); // Escreva no nosso arquivo o text
                }

                Console.WriteLine($"Arquivo {path} Salvo com sucesso!"); 

                Console.ReadLine();

                Menu();
            }
            catch
            {
                Console.WriteLine("\n Caminho inválido. Tente novamente.");
                Thread.Sleep(1000);
                Salvar(text);
            }
          
        }

    }
}
