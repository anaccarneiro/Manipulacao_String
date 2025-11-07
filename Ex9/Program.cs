using System;
using System.Globalization;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*09. Escreva um método que receba o nome completo de um estudante e retorne o seu e-mail institucional. Na
            Universidade um e-mail contém apenas letras minúsculas e a regra para geração do e-mail é: nome.sobrenome@acme.br
            Exemplos:
            Nome: Maria Sousa Silva
            E-mail: maria.silva@acme.br*/

            string nome;
            Console.WriteLine("Digite seu nome completo");
            nome = Console.ReadLine().ToLower();

            string email = Email(nome);
            Console.WriteLine(email);
        }

        static string Email (string nome)
        {
            string[] partes = nome.Split(' ');
            string email = partes[0] + "." + partes[partes.Length - 1] + "@acme.br";

            return email;
        }
    }
}
