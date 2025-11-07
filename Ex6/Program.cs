using System;
using System.Globalization;
using System.Linq;
using System.Security.Principal;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*06. Faça um programa para criptografar uma frase informada pelo usuário. A criptografia deverá trocar as vogais da
            frase por *. Exemplo:
            Frase: EU ESTOU NA ESCOLA
            Saída: ** *ST** N* *SC*L**/

            string frase = "", criptografar = "";
            char [] vogais = {'a','e','i','o','u'};
            Console.WriteLine("Escreva a frase desejada:");
            frase = Console.ReadLine().ToLower();

            criptografar = frase;

            foreach (char letra in frase)
            {
                bool igualdade = (vogais.Contains(letra));
                if (igualdade)
                {
                    criptografar = criptografar.Replace(letra, '*');
                }
            }

            Console.Write(criptografar);
        }
    }
}
