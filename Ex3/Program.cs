using System;
using System.Linq;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*03. Escreva um método que receba como parâmetro uma string e retorne o número de vogais e de consoantes dessa
            string. Considere que a string lida terá apenas letras (Dica: consoantes não são vogais).*/

            string palavra;
            int consoantes, vogais;
            Console.WriteLine("Digite uma palavra:");
            palavra = Console.ReadLine();

            Letras(palavra, out consoantes, out vogais);
            Console.WriteLine($"Há {vogais} vogal(is) e {consoantes} consoante(s)");
        }
        static void Letras(string palavra, out int totalC, out int totalV)
        {
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
            int contV = 0, contC = 0;

            totalC = 0;
            totalV = 0;

            foreach (char vogal in palavra)
            {
                if (vogais.Contains(vogal))
                {
                    contV++;
                    totalV = contV;
                }
                else
                {
                    contC++;
                    totalC = contC;
                }
            }
            if (contV == 0)
            {
                Console.WriteLine("Não há vogais!");
            }
            if (contC == 0)
            {
                Console.WriteLine("Não há consoantes!");
            }
        }
    }
}
