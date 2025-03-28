using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        // Desafio: Armazenar e Exibir letras já digitadas
        static void Main(string[] args)
        {
          
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                                     Jogo da Forca                                                      ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("1 - Frutas");
                Console.WriteLine("2 - Países");
                Console.WriteLine("3 - Cores");
                Console.WriteLine("S - Sair");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


                Console.WriteLine("                                                    Escolha Uma Opção                                                   ");
                string opcao = Console.ReadLine();

                if (opcao == "S")
                    break;
                else if (opcao == "s")
                    break;

                else if (opcao == "1")
                {
                    string[] frutas =
                    {
                        "ABACAXI",
                        "ACEROLA",
                        "ACAI",
                        "ARACA",
                        "ABACATE",
                        "LIMAO",
                        "LARANJA",
                        "BANANA",
                        "CAJA",
                        "CAJU",
                        "CARAMBOLA",
                        "CUPUACU",
                        "GRAVIOLA",
                        "GOIABA",
                        "JABUTICABA",
                        "JENIPAPO",
                        "MACA",
                        "MANGABA",
                        "MANGA",
                        "MARACUJA",
                        "BERGAMOTA",
                        "PEQUI",
                        "PITANGA",
                        "PITAYA",
                        "SAPOTI",
                        "TANGERINA",
                        "MELANCIA",
                        "UVA",
                        "MELAO"
                    };
                    while (true)
                    {
                        Random geradorDeNumeros = new Random();

                        int indicePalavraEscolhida = geradorDeNumeros.Next(frutas.Length);

                        string palavraSecreta = frutas[indicePalavraEscolhida];

                        char[] letrasEncontradas = new char[palavraSecreta.Length];

                        char[] letrasErradas = new char[6];

                        int contadorLetrasErradas = 0;

                        for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                        {
                            // Acessar o Array no Índice 0
                            letrasEncontradas[caractere] = '_';
                        }

                        for (int caractere = 0; caractere < letrasErradas.Length; caractere++)
                        {
                            //acessar o array no indice 0 ou encontrado // quando se quer passar valor para a caractere// [caractere] = '_';//
                            letrasErradas[caractere] = '_';
                        }

                        int quantidadeDeErros = 0;
                        bool jogadorEnforcou = false;
                        bool jogadorAcertou = false;

                        do
                        {
                            string dicaDaPalavra = String.Join(" ", letrasEncontradas);
                            string dicaLetrasErradas = String.Join(" ", letrasErradas);

                            Console.Clear();
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                                     Jogo da Forca                                                      ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                            if (quantidadeDeErros == 0)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }
                            else if (quantidadeDeErros == 1)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }
                            else if (quantidadeDeErros == 2)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }
                            else if (quantidadeDeErros == 3)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }
                            else if (quantidadeDeErros == 4)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                   /|\\");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }
                            else if (quantidadeDeErros == 5)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                   /|\\");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   / \\");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

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
                            {
                                quantidadeDeErros++;
                                letrasErradas[contadorLetrasErradas] = chute;
                                contadorLetrasErradas++;
                            }
                        
                     Console.ReadLine();

                        dicaDaPalavra = String.Join("", letrasEncontradas);
                        dicaLetrasErradas = String.Join("", letrasErradas);

                            jogadorAcertou = dicaDaPalavra == palavraSecreta;
                            // Jogador Poderá Cometer 5 Erros antes de Perder
                            jogadorEnforcou = quantidadeDeErros > 5;

                            if (jogadorAcertou)
                            {
                                Console.Clear();
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                                     Jogo da Forca                                                      ");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    J");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                      -Obrigado-");
                                Console.WriteLine("                                      |                     /");
                                Console.WriteLine("                                      |                   \\O/");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   / \\");
                                Console.WriteLine("                              ___________________________________________");

                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                             PARABÉNS, Você Acertou a Palavra Secreta! Era: " + palavraSecreta);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                            }
                            else if (jogadorEnforcou)
                            {
                                Console.Clear();
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                                     Jogo da Forca                                                      ");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   _|_");
                                Console.WriteLine("                                      |                  (x_x)");
                                Console.WriteLine("                                      |                   /|\\");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   / \\");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                              ___________________________________________");

                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                              QUE AZAR, Tente Novamente! A Palavra Era: " + palavraSecreta);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                        } while (jogadorAcertou == false && jogadorEnforcou == false); // || = OU

                        Console.Write("Deseja continuar? (S/N): ");

                        string opcaoContinuar = Console.ReadLine().ToUpper();

                        if (opcaoContinuar != "S")
                            break;
                    }

                }

                else if (opcao == "2")
                {

                    string[] paises =
                    {
                        "BRASIL",
                        "ARGENTINA",
                        "CHILE",
                        "URUGUAI",
                        "PARAGUAI",
                        "COLOMBIA",
                        "PERU",
                        "EQUADOR",
                        "VENEZUELA",
                        "BOLIVIA",
                        "ESTADOS UNIDOS",
                        "CANADA",
                        "MEXICO",
                        "CUBA",
                        "COSTA RICA",
                        "PANAMA",
                        "GUATEMALA",
                        "HONDURAS",
                        "NICARAGUA",
                        "EL SALVADOR",
                        "ESPANHA",
                        "PORTUGAL",
                        "FRANCA",
                        "ITALIA",
                        "ALEMANHA",
                        "REINO UNIDO",
                        "HOLANDA",
                        "BELGICA",
                        "SUECIA",
                    };
                    while (true)
                    {
                        Random geradorDeNumeros = new Random();

                        int indicePalavraEscolhida = geradorDeNumeros.Next(paises.Length);

                        string palavraSecreta = paises[indicePalavraEscolhida];

                        char[] letrasEncontradas = new char[palavraSecreta.Length];

                        char[] letrasErradas = new char[6];

                        int contadorLetrasErradas = 0;

                        for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                        {
                            // Acessar o Array no Índice 0
                            letrasEncontradas[caractere] = '_';
                        }

                        for (int caractere = 0; caractere < letrasErradas.Length; caractere++)
                        {
                            //acessar o array no indice 0 ou encontrado // quando se quer passar valor para a caractere// [caractere] = '_';//
                            letrasErradas[caractere] = '_';
                        }

                        int quantidadeDeErros = 0;
                        bool jogadorEnforcou = false;
                        bool jogadorAcertou = false;

                        do
                        {
                            string dicaDaPalavra = String.Join(" ", letrasEncontradas);
                            string dicaLetrasErradas = String.Join(" ", letrasErradas);

                            Console.Clear();
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                                     Jogo da Forca                                                      ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                            if (quantidadeDeErros == 0)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                            else if (quantidadeDeErros == 1)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                            else if (quantidadeDeErros == 2)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                            else if (quantidadeDeErros == 3)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                            else if (quantidadeDeErros == 4)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                   /|\\");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                            else if (quantidadeDeErros == 5)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                   /|\\");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   / \\");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

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
                            {
                                quantidadeDeErros++;
                                letrasErradas[contadorLetrasErradas] = chute;
                                contadorLetrasErradas++;
                            }

                            Console.ReadLine();

                            dicaDaPalavra = String.Join("", letrasEncontradas);
                            dicaLetrasErradas = String.Join("", letrasErradas);

                            jogadorAcertou = dicaDaPalavra == palavraSecreta;
                            // Jogador Poderá Cometer 5 Erros antes de Perder
                            jogadorEnforcou = quantidadeDeErros > 5;

                            if (jogadorAcertou)
                            {
                                Console.Clear();
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                                     Jogo da Forca                                                      ");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    J");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                      -Obrigado-");
                                Console.WriteLine("                                      |                     /");
                                Console.WriteLine("                                      |                   \\O/");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   / \\");
                                Console.WriteLine("                              ___________________________________________");

                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                             PARABÉNS, Você Acertou a Palavra Secreta! Era: " + palavraSecreta);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                            }
                            else if (jogadorEnforcou)
                            {
                                Console.Clear();
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                                     Jogo da Forca                                                      ");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   _|_");
                                Console.WriteLine("                                      |                  (x_x)");
                                Console.WriteLine("                                      |                   /|\\");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   / \\");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                              ___________________________________________");

                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                              QUE AZAR, Tente Novamente! A Palavra Era: " + palavraSecreta);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                            }

                        } while (jogadorAcertou == false && jogadorEnforcou == false); // || = OU

                        Console.Write("Deseja continuar? (S/N): ");

                        string opcaoContinuar = Console.ReadLine().ToUpper();

                        if (opcaoContinuar != "S")
                            break;
                    }

                }

                else if (opcao == "3")
                {

                    string[] cores =
                    {
                        "VERMELHO",
                        "AZUL",
                        "VERDE",
                        "AMARELO",
                        "LARANJA",
                        "ROXO",
                        "ROSA",
                        "MARROM",
                        "CINZA",
                        "PRETO",
                        "BRANCO",
                        "BEGE",
                        "BORDO",
                        "TURQUESA",
                        "VIOLETA",
                        "DOURADO",
                        "PRATEADO",
                        "CARAMELO",
                        "CREME",
                        "FUCHSIA",
                        "ANIL",
                        "OLIVA",
                        "SAFIRA",
                        "MAGENTA",
                        "ESMERALDA",
                        "CORAL",
                        "LILAS",
                        "CHOCOLATE",
                        "MOSTARDA",
                    };
                    while (true)
                    {
                        Random geradorDeNumeros = new Random();

                        int indicePalavraEscolhida = geradorDeNumeros.Next(cores.Length);

                        string palavraSecreta = cores[indicePalavraEscolhida];

                        char[] letrasEncontradas = new char[palavraSecreta.Length];

                        char[] letrasErradas = new char[6];

                        int contadorLetrasErradas = 0;

                        for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                        {
                            // Acessar o Array no Índice 0
                            letrasEncontradas[caractere] = '_';
                        }

                        for (int caractere = 0; caractere < letrasErradas.Length; caractere++)
                        {
                            //acessar o array no indice 0 ou encontrado // quando se quer passar valor para a caractere// [caractere] = '_';//
                            letrasErradas[caractere] = '_';
                        }

                        int quantidadeDeErros = 0;
                        bool jogadorEnforcou = false;
                        bool jogadorAcertou = false;

                        do
                        {
                            string dicaDaPalavra = String.Join(" ", letrasEncontradas);
                            string dicaLetrasErradas = String.Join(" ", letrasErradas);

                            Console.Clear();
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                                     Jogo da Forca                                                      ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                            if (quantidadeDeErros == 0)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                            else if (quantidadeDeErros == 1)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                            else if (quantidadeDeErros == 2)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                            else if (quantidadeDeErros == 3)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                            else if (quantidadeDeErros == 4)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                   /|\\");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

                            else if (quantidadeDeErros == 5)
                            {
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    U");
                                Console.WriteLine("                                      |                    O");
                                Console.WriteLine("                                      |                   /|\\");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   / \\");
                                Console.WriteLine("                                      |                  ------");
                                Console.WriteLine("                              ___________________________|____|");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Palavra Secreta: " + dicaDaPalavra);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                              Letras Erradas: " + dicaLetrasErradas);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                               Quantidade de Erros: " + quantidadeDeErros);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }

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
                            {
                                quantidadeDeErros++;
                                letrasErradas[contadorLetrasErradas] = chute;
                                contadorLetrasErradas++;
                            }

                            Console.ReadLine();

                            dicaDaPalavra = String.Join("", letrasEncontradas);
                            dicaLetrasErradas = String.Join("", letrasErradas);

                            jogadorAcertou = dicaDaPalavra == palavraSecreta;
                            // Jogador Poderá Cometer 5 Erros antes de Perder
                            jogadorEnforcou = quantidadeDeErros > 5;

                            if (jogadorAcertou)
                            {
                                Console.Clear();
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                                     Jogo da Forca                                                      ");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    J");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                                      |                      -Obrigado-");
                                Console.WriteLine("                                      |                     /");
                                Console.WriteLine("                                      |                   \\O/");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   / \\");
                                Console.WriteLine("                              ___________________________________________");

                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                             PARABÉNS, Você Acertou a Palavra Secreta! Era: " + palavraSecreta);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                            }
                            else if (jogadorEnforcou)
                            {
                                Console.Clear();
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                                     Jogo da Forca                                                      ");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                                      ----------------------");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   _|_");
                                Console.WriteLine("                                      |                  (x_x)");
                                Console.WriteLine("                                      |                   /|\\");
                                Console.WriteLine("                                      |                    |");
                                Console.WriteLine("                                      |                   / \\");
                                Console.WriteLine("                                      |");
                                Console.WriteLine("                              ___________________________________________");

                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                              QUE AZAR, Tente Novamente! A Palavra Era: " + palavraSecreta);
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                            }

                        } while (jogadorAcertou == false && jogadorEnforcou == false); // || = OU

                        Console.Write("Deseja continuar? (S/N): ");

                        string opcaoContinuar = Console.ReadLine().ToUpper();

                        if (opcaoContinuar != "S")
                            break;
                    }

                }

                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("                                      !Pressione - R Para Reiniciar / S Para Sair!                                      ");

                string opcaofinal = Console.ReadLine();

                if (opcaofinal == "R")
                    continue;
                else if (opcaofinal == "r")
                    continue;
                else if (opcaofinal == "S")
                    break;
                else if (opcaofinal == "s")
                    break;
            }

        }

    }


    

    
}
