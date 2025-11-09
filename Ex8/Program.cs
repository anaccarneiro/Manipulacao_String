using System;
using System.Runtime.Remoting.Channels;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*08. Em um verbo regular, o radical é a parte invariante, que dá origem a todas as conjugações. Faça um programa que
            leia um verbo regular terminado em “AR”, e imprima a conjugação do verbo nos seguintes tempos verbais:

            a) Presente do indicativo;
            b) Pretérito perfeito do indicativo;
            c) Futuro do presente do indicativo.

            Se o verbo não for terminado em “AR” imprima uma mensagem de erro.

            O programa deverá ler um verbo, processar e imprimir a sua conjunção (ou a mensagem de erro), depois deverá verificar
            se o usuário deseja informar um novo verbo. Esse processo deverá ser repetido até que o usuário informe “não”.*/

            string verbo, opcao;

            do
            {
                Console.WriteLine("Informe um verbo terminado em 'AR': ");
                verbo = Console.ReadLine().ToLower();

                bool encontrado = verbo.EndsWith("ar");

                while (!encontrado)
                {
                    Console.WriteLine("Informe um verbo terminado em 'AR': ");
                    verbo = Console.ReadLine().ToLower();
                    encontrado = verbo.EndsWith("ar");
                }

                string mudar = verbo.Remove(3);

                string[] presente = { "o", "as", "a", "amos", "ais", "am" };
                string[] preterito = { "ei", "aste", "ou", "amos", "astes", "am" };
                string[] futuro = { "arei", "arás", "ará", "aremos", "areis", "arão" };

                string[] tempo = new string[6];
                Console.WriteLine("\nPresente:");

                for (int i = 0; i < presente.Length; i++)
                {
                    tempo[i] = mudar.Insert(mudar.Length, presente[i]);
                    Console.Write(tempo[i] + ", ");
                }
                Console.WriteLine();

                Console.WriteLine("\nPretérito:");
                for (int i = 0; i < preterito.Length; i++)
                {
                    tempo[i] = mudar.Insert(mudar.Length, preterito[i]);
                    Console.Write(tempo[i] + ", ");
                }
                Console.WriteLine();

                Console.WriteLine("\nFuturo:");
                for (int i = 0; i < futuro.Length; i++)
                {
                    tempo[i] = mudar.Insert(mudar.Length, futuro[i]);
                    Console.Write(tempo[i] + ", ");
                }
                Console.WriteLine();

                Console.WriteLine("\nDeseja continuar?");
                opcao = Console.ReadLine().ToLower();
            } while (opcao == "sim");
        }
    }
}
