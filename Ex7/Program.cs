using System;
using System.Collections.Specialized;
using System.Diagnostics;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*07. Faça um método que receba uma frase como parâmetro, calcule e retorne a quantidade de palavras da frase (considere
            que a string lida não terá sinais de pontuação).
            Exemplos:
            Frase 1: Nas quintas há aula teórica de Algoritmos e Técnicas de Programação
            Número de palavras: 11
            Frase 2: A lista de exercícios é sobre strings
            Número de palavras: 7*/

            
            Console.WriteLine("Escreva a frase desejada:");
            string frase = Console.ReadLine().ToLower();

            string [] partes = quantPalavras(frase);

            Console.WriteLine("Há "+ partes.Length + " palavra(s)");
        }

        static string [] quantPalavras(string frase)
        {
            string[] partes = frase.Split(' ');

            return partes;
        }
    }
}
