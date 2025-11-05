using System;
using System.ComponentModel.Design.Serialization;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*01. Escreva um programa que leia uma string e um caractere, e retorne o número de vezes que esse caractere aparece na string.*/
            string palavra;
            char letra;
            int cont = 0;

            Console.WriteLine("Digite uma palavra:");
            palavra = Console.ReadLine();
            Console.WriteLine("Informe uma letra presente na palavra:");
            letra = char.Parse(Console.ReadLine());

            foreach (char caracter in palavra)
            {
                if (letra == caracter)
                    cont++;
            }

            Console.WriteLine($"A letra '{letra}' aparece {cont} vez(es) em '{palavra}'.");
        }
    }
}
