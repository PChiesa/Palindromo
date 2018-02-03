using System;

namespace Palindromo
{
    class Program
    {
        private static ValidateWord validateWord = new ValidateWord();

        static void Main(string[] args)
        {
            Console.WriteLine("Um palíndromo é uma palavra que coincide com sua inversa. Por exemplo, OSSO. Escreve uma função que receba como parâmetro uma String e retorne true caso a palavra seja um palíndromo e falso em caso negativo.");
            Console.WriteLine("Insira a palavra que deseja testar:");
            string nWord = Console.ReadLine();

            Console.WriteLine(validateWord.IsPalindrome(nWord));
        }
    }
}
