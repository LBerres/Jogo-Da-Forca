﻿using System;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        // Versão 3: Verificação do input
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

                int quantidadeDeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    string dicaDaPalavra = String.Join(" ", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Palavra Secreta: " + dicaDaPalavra);
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Quantidade de Erros: " + quantidadeDeErros);
                    Console.WriteLine("---------------------------------------------");

                    Console.Write("Digite Uma Letra: ");
                    char chute = Console.ReadLine()[0]; // char = Obtém Apenas Um Caractere Que o Usuário Digita

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavraSecreta.Length; contador++)
                    {
                        char letraAtual = palavraSecreta[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                        
                    }

                    if (letraFoiEncontrada == false)
                        quantidadeDeErros++;

                    dicaDaPalavra = String.Join("", letrasEncontradas);

                    jogadorAcertou = dicaDaPalavra == palavraSecreta;
                    // Jogador Poderá Cometer 5 Erros antes de Perder
                    jogadorEnforcou = quantidadeDeErros > 5;

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Você Acertou a Palavra Secreta! Era: " + palavraSecreta);
                        Console.WriteLine("---------------------------------------------");

                    }  
                    else if (jogadorEnforcou)
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Que Azar, Tente Novamente! A Palavra Era: " + palavraSecreta);
                        Console.WriteLine("---------------------------------------------");

                    }

                } while (jogadorAcertou == false && jogadorEnforcou == false); // || = OU

                Console.ReadLine();

                
            }
        }

    }
}
