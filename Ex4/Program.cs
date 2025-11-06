using System;
using System.Globalization;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*04. Escreva um programa que leia uma palavra e a imprima de trás-para-frente.*/

            string word, invertida = "a";
            Console.WriteLine("Digite uma palavra");
            word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }
    }
}
