using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*05. Escreva um método que receba uma string e indique se ela é um palíndromo. Seu método deve retornar um booleano.
            Um palíndromo é uma string que tem a propriedade de poder ser lida tanto da direita para a esquerda, como da esquerda
            para a direita. Ex: ovo, arara, osso.*/

            string palavra;
            Console.WriteLine("Escreva aqui:");
            palavra = Console.ReadLine().ToLower();

            bool palindromo = Palindromo(palavra);
            Console.WriteLine($"\n\nPalíndromo: {palindromo}");
        }

        static bool Palindromo(string palavra)
        {
            string invertida = "";

            Console.WriteLine("\nLeitura da direita para a esquerda:");
            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                invertida += (palavra[i]);
            }
            Console.Write(invertida);

            bool igualdade = (palavra.Equals(invertida));

            return igualdade;
        }
    }
}
