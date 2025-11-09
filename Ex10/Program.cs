using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10. Escreva um programa que leia uma frase A com pelo menos 50 caracteres e uma string B contendo exatamente 2
            caracteres. Imprima o número de vezes que a string B aparece na string A.*/

            string fraseA, fraseB;
            int cont = 0;

            Console.WriteLine("Digite uma frase (Mínimo 50 caracteres):");
            fraseA = Console.ReadLine().ToLower();

            while (fraseA.Length < 50)
            {
                Console.WriteLine("Digite uma frase novamente (Mínimo 50 caracteres):");
                fraseA = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Informe um trecho (2 caracteres):");
            fraseB = Console.ReadLine().ToLower();

            while (fraseB.Length != 2)
            {
                Console.WriteLine("Informe um trecho novamente (2 caracteres):");
                fraseB = Console.ReadLine().ToLower();
            }

            foreach (char carecteres in fraseB)
            {
                if (fraseA.Contains(fraseB) && fraseB.Length == 2)
                {
                    cont++;
                }
            }
            Console.WriteLine("Número de vezes que B aparece em A: " + cont);
        }
    }
}
