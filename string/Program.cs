using System;

namespace texto
{
    class Program
    {
        static void Main(string[] args)
        {

            string palavra = "****# Não vai conheçer nada até amanhã #*****";
            Console.WriteLine("palavra: " + palavra);

            string novapalavra = RemoverCaracteresEspeciais.RemoveSpecialCharacters(palavra); // Chamando a função RemoveSpecialCharacters que está na classe RemoverCaracteresEspeciais
            Console.WriteLine("novapalavra: " + novapalavra);

            string novapalavra1 = RetiraCaracteresEspeciais.RemoveSpecialCharacters(palavra); // Chamando a função RemoveSpecialCharacters que está na classe RetiraCaracteresEspeciais
            Console.WriteLine("novapalavra1: " + novapalavra1);
            novapalavra1 = RetiraCaracteresEspeciais.RemoveDiacritics(novapalavra1); // Chamando a função RemoveDiacritics que está na classe RetiraCaracteresEspeciais
            Console.WriteLine("novapalavra1: " + novapalavra1);

            string novapalavra2 = RetiraCaracteresEspeciais.RemoveDiacritics(palavra); // Chamando a função RemoveDiacritics que está na classe RetiraCaracteresEspeciais
            Console.WriteLine("novapalavra2: " + novapalavra2);


            // Outras maneiras de tirar Espaços de Texto:

            var texto = " Hello World ";
            Console.WriteLine($"Corta o fim: |{texto.TrimEnd()}|");
            Console.WriteLine($"Corta o início: |{texto.TrimStart()}|");
            Console.WriteLine($"Corta ambos: |{texto.Trim()}|");
            Console.WriteLine($"Corta tudo: |{texto.Replace(" ", "")}|");


        }
    }
}
