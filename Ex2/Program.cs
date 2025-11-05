using System;
using System.Collections.Specialized;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*02. Escreva um programa que leia duas strings. Se as strings forem iguais, escreva “strings iguais”. Caso contrário,
              imprima a string que possui o maior tamanho e, em seguida, a string resultante da concatenação das duas strings.*/

            string word1, word2;
            
            Console.WriteLine("Digite a primeira palavra:");
            word1 = Console.ReadLine().ToLower();
            Console.WriteLine("Digite a segunda palavra:");
            word2 = Console.ReadLine().ToLower();

            bool igualdade = (word1.Equals(word2));
            if (igualdade)
            {
                Console.WriteLine("\nStrings Iguais");
            }
            if (!igualdade)
            {
                if (word1.Length > word2.Length)
                {
                    Console.WriteLine($"\nA palavra {word1} é maior");
                }
                else
                {
                    Console.WriteLine($"\nA palavra {word2} é maior");
                }
                Console.WriteLine(word1 + word2);
            }
        }
    }
}
