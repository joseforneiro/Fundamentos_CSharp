using System;
using System.Text;

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

            // Indices

            Console.WriteLine("\ne) Indices:\n");

            var texto1 = "Este texto é um teste";

            Console.WriteLine(texto1.IndexOf("é")); // O IndexOF sempre vai pedir um objeto do mesmo tipo. Eu passo o caractere que eu quero buscar e irá retornar a posição que está esse caractere. Só retorna o primeiro caractere que encontrar.
            Console.WriteLine(texto1.LastIndexOf("um")); // O LastIndexOF sempre vai pedir um objeto do mesmo tipo. Eu passo o caractere que eu quero buscar e irá retornar o último indice que encontrar de uma letra ou de uma palavra.

            // *******************************************************************************************************

            // Métodos adicionais

            Console.WriteLine("\nf) Métodos adicionais:\n");

            texto1 = "Este texto é um teste";

            Console.WriteLine(texto1.ToUpper()); // Converte todo o texto para maiusculo

            Console.WriteLine(texto1.ToLower()); // Converte todo o texto para minusculo

            Console.WriteLine(texto1.Insert(5, "AQUI ")); // Insere na posição 5 o texto AQUI

            Console.WriteLine(texto1.Remove(5, 6)); // Remove a partir da posição 5 6 caracteres

            Console.WriteLine(texto1.Length); // O Length trás a quantidade de caracteres que tem uma string.

            // *******************************************************************************************************

            // Manipulando Strings

            Console.WriteLine("\ng) Manipulando Strings:\n");

            texto1 = "Este texto é um teste";

            Console.WriteLine(texto1.Replace("Este", "Isto")); // Replace("Este", "Isto") => Irá trocar a palavra Este pela palavra Isto

            Console.WriteLine(texto1.Replace("e", "X")); // Replace("e", "X") => Irá trocar todos as letras e minusculas pela letra X maiuscula

            var divisao = texto1.Split(" "); // Split(" ") => Irá quebrar o texto1 onde tem espaço. Como resultado teremos uma lista de strings.

            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);

            var resultado = texto1.Substring(5, 7); // Substring(5, 7) => Irá pegar a partir da posição 5 7 caracteres
            Console.WriteLine(resultado);

            resultado = texto1.Substring(5, texto1.LastIndexOf("o")); // Substring(5, texto1.LastIndexOf("o")) => Irá pegar a partir da posição 5 até o indice da última letra o. Ou seja o índice da última letra o é 9 então ele irá pegar 9 caracteres a partir do caractere 5. Não esquecer que começa a contar de 0 e não 1.
            Console.WriteLine(resultado);

            var texto2 = " Testando o Trim ";
            Console.WriteLine(texto2.Trim()); // O Trim remove os espaços do início e do fim de uma string. Não remove os espaços do meio da string

            Console.WriteLine(texto2.Replace(" ", "")); // Podemos tirar os espaços de todo o texto desse jeito.

            // *******************************************************************************************************

            // String Builder

            Console.WriteLine("\nh) String Builder:\n");

            texto1 += " aqui"; // Concatenação de string. texto1 += " aqui" => texto1 = texto1 + " aqui"

            var texto3 = new StringBuilder(); // Esse é um método construtor. Build em inglês é contruir então sepre que ver a palavra Builder é um construtor. Esse método está dentro do using System.Text;
            texto3.Append("Este texto é um teste");
            texto3.Append(" é um teste");
            texto3.Append(" Este texto");
            texto3.Append(" Este é um teste");

            Console.WriteLine(texto3); // O Console.WriteLine já converte para string pois caso contrario teramos que fazer um texto3.ToString(); pois texto3 é um StringBuilder e não String
        }
    }
}
