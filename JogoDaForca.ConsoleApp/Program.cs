using System;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        // Versão 2: Exibir palavra oculta com traços
        static void Main(string[] args)
        {
            while (true)
            {

                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                {
                    // Acessar o Array no Índice 0
                    letrasEncontradas[caractere] = '_';
                }

                string dicaDaPalavra = String.Join(" ", letrasEncontradas);

                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Palavra Secreta: " + dicaDaPalavra);
                Console.WriteLine("---------------------------------------------");

                Console.Write("Digite Uma Letra: ");
                char chute = Console.ReadLine()[0]; // Obtém Apenas Um Caractere Que o Usuário Digita

                Console.WriteLine(chute);

                Console.ReadLine();
            }
        }

    }
}
