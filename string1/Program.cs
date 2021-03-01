using System;

namespace string1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interpolação de Strings:

            Console.WriteLine("a) Interpolação de Strings:\n");

            var price = 10.2;
            var texto = "1) O preço do produto é " + price;
            Console.WriteLine(texto);

            texto = string.Format("2) O preço do produto é {0}", price);
            Console.WriteLine(texto);

            texto = string.Format("3) O preço do produto é {0} apenas para a promoção {1}", price, true);
            Console.WriteLine(texto);

            texto = string.Format($"4) O preço do produto é {price}");
            Console.WriteLine(texto);

            // *******************************************************************************************************

            // Comparação de Strings:

            // ** o CompareTo é usado para comparar palavras ou textos inteiros.

            Console.WriteLine("\nb) Comparação de Strings:\n");

            texto = "Testando";

            Console.WriteLine(texto.CompareTo("testando")); // Zero quer dizer igual

            Console.WriteLine(texto.CompareTo("Testando")); // 1 ou -1 quer dizer diferente


            // ** o Contais é usado para verificar se no texto contaim uma determinada palavra

            texto = "Esse texto é apenas um teste";

            Console.WriteLine(texto.Contains("teste")); // Esse método diferencia letras maiúsculas e minúsculas

            Console.WriteLine(texto.Contains("Teste")); // Esse método diferencia letras maiúsculas e minúsculas

            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // StringComparison.OrdinalIgnoreCase => Faz não diferenciar letras maiúsculas e minúsculas

            // *******************************************************************************************************

            // StartsWith e EndsWith (Começa com e Termina com)

            Console.WriteLine("\nc) StartsWith e EndsWith:\n");

            texto = "Este texto é um texte";

            Console.WriteLine(texto.StartsWith("Este")); // Esse método diferencia letras maiúsculas e minúsculas

            Console.WriteLine(texto.StartsWith("este")); // Esse método diferencia letras maiúsculas e minúsculas

            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // StringComparison.OrdinalIgnoreCase => Faz não diferenciar letras maiúsculas e minúsculas

            Console.WriteLine("---------");

            Console.WriteLine(texto.EndsWith("texte")); // Esse método diferencia letras maiúsculas e minúsculas

            Console.WriteLine(texto.EndsWith("Texte")); // Esse método diferencia letras maiúsculas e minúsculas

            Console.WriteLine(texto.EndsWith("Texte", StringComparison.OrdinalIgnoreCase)); // StringComparison.OrdinalIgnoreCase => Faz não diferenciar letras maiúsculas e minúsculas

            // *******************************************************************************************************

            // Equals

            // ** Para saber se um objeto é identico a outro. Esse método não é usado só para comparar strings, mas também int com int, float com float, etc...

            Console.WriteLine("\nd) Equals:\n");

            texto = "Este texto é um texte";

            Console.WriteLine(texto.Equals("Este texto é um texte")); // Esse método diferencia letras maiúsculas e minúsculas

            Console.WriteLine(texto.Equals("este texto é um texte")); // Esse método diferencia letras maiúsculas e minúsculas

            Console.WriteLine(texto.Equals("este texto é um texte", StringComparison.OrdinalIgnoreCase)); // StringComparison.OrdinalIgnoreCase => Faz não diferenciar letras maiúsculas e minúsculas

            // ** Comparação de valores int

            int valor = 33;

            Console.WriteLine(valor.Equals(34));

            // *******************************************************************************************************



        }
    }
}
