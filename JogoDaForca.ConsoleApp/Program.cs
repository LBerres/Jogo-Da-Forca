using System;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        // Versão 1: Estrutura básica e entrada do usuário
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("---------------------------------------------");

                Console.Write("Digite Uma Letra");
                char chute = Console.ReadLine()[0]; // Obtém Apenas Um Caractere Que o Usuário Digita

                Console.WriteLine(chute);

                Console.ReadLine();
            }
        }

    }
}
