using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";



            while (resposta.ToUpper() != sair)
            {
                string PosicaoAtual;
                int PosicaoX = 0;
                int PosicaoY = 0;


                string PosicaoAtual2;
                int PosicaoX2 = 0;
                int PosicaoY2 = 0;
                

                Console.WriteLine("Tamanho do Lugar X: ");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Tamanho do Lugar Y: ");
                int Y = Convert.ToInt32(Console.ReadLine());
                int[,] mapa = new int[X, Y];
                









                Console.WriteLine("Posição X DO ROBÔ 1: ");
                PosicaoX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Posição Y DO ROBÔ 1: ");
                PosicaoY = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Para Qual Ponto Cardeal O ROBÔ 1 está Olhando?: ");
                PosicaoAtual = Console.ReadLine().ToUpper();

                if(PosicaoX < 0)
                {
                    Console.WriteLine("Posição X tem q ser maior doque 0:");
                    continue;
                }
                if (PosicaoX > X)
                {
                    Console.WriteLine("Posição X tem q ser menor doque o limite:");
                    continue;
                }


                if (PosicaoY < 0)
                {
                    Console.WriteLine("Posição Y tem q ser maior doque 0:");
                    continue;
                }
                if (PosicaoY > Y)
                {
                    Console.WriteLine("Posição Y tem q ser menor doque o limite:");
                    continue;
                }

                Console.WriteLine("Como movimentar o ROBÔ 1: \n---------\n E : vira à esquerda || D : vira à direita || M : Faz o movimento na direção\n Exemplo: EMEMEMEMM");
                string cordenadas = Console.ReadLine().ToUpper();
                char[] cordenadaSeparada = cordenadas.ToCharArray();
                int QuantasCords = Convert.ToInt32(cordenadaSeparada.Length);

                if (PosicaoX2 < 0)
                {
                    Console.WriteLine("Posição X tem q ser maior doque 0:");
                    continue;
                }
                if (PosicaoX2 > X)
                {
                    Console.WriteLine("Posição X tem q ser menor doque o limite:");
                    continue;
                }


                if (PosicaoY2 < 0)
                {
                    Console.WriteLine("Posição Y tem q ser maior doque 0:");
                    continue;
                }
                if (PosicaoY2 > Y)
                {
                    Console.WriteLine("Posição Y tem q ser menor doque o limite:");
                    continue;
                }


                Console.WriteLine("Posição X DO ROBÔ 2: ");
                PosicaoX2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Posição Y DO ROBÔ 2: ");
                PosicaoY2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Para Qual Ponto Cardeal O ROBÔ 2 está Olhando?: ");
                PosicaoAtual2 = Console.ReadLine().ToUpper();



                Console.WriteLine("Como movimentar o ROBÔ 2: \n---------\n E : vira à esquerda || D : vira à direita || M : Faz o movimento na direção\n Exemplo: EMEMEMEMM");
                string cordenadas2 = Console.ReadLine().ToUpper();
                char[] cordenadaSeparada2 = cordenadas2.ToCharArray();
                int QuantasCords2 = Convert.ToInt32(cordenadaSeparada2.Length);

                #region ROBO 1
                for (int i = 0; i < QuantasCords; i++)
                {
                    if (PosicaoX < 0)
                    {
                        Console.WriteLine("Erro: Limite de alcance...");
                    }
                    else
                    if (PosicaoY < 0)
                    {
                        Console.WriteLine("Erro: Limite de alcance...");
                    }
                    else
                    if (PosicaoX > X)
                    {
                        Console.WriteLine("Erro: Limite de alcance...");
                    }
                    else
                    if (PosicaoY > Y)
                    {
                        Console.WriteLine("Erro: Limite de alcance...");
                    }
                    else
                    if (cordenadaSeparada[i] == 'E' && PosicaoAtual == "O")
                    {
                        PosicaoAtual = "S";
                        Console.WriteLine("Virou a Sul!");

                    }
                    else
                    if (cordenadaSeparada[i] == 'E' && PosicaoAtual == "N")
                    {
                        PosicaoAtual = "O";
                        Console.WriteLine("Virou a Oeste!");


                    }
                    else
                    if (cordenadaSeparada[i] == 'E' && PosicaoAtual == "L")
                    {
                        PosicaoAtual = "N";
                        Console.WriteLine("Virou a Norte!");

                    }
                    else
                    if (cordenadaSeparada[i] == 'E' && PosicaoAtual == "S")
                    {
                        PosicaoAtual = "L";
                        Console.WriteLine("Virou a Leste!");

                    }
                    else

                    if (cordenadaSeparada[i] == 'D' && PosicaoAtual == "O")
                    {
                        PosicaoAtual = "N";
                        Console.WriteLine("Virou a Norte!");

                    }
                    else
                    if (cordenadaSeparada[i] == 'D' && PosicaoAtual == "N")
                    {
                        PosicaoAtual = "L";
                        Console.WriteLine("Virou a Leste!");

                    }
                    else
                    if (cordenadaSeparada[i] == 'D' && PosicaoAtual == "L")
                    {
                        PosicaoAtual = "S";
                        Console.WriteLine("Virou a Sul!");

                    }
                    else
                    if (cordenadaSeparada[i] == 'D' && PosicaoAtual == "S")
                    {
                        PosicaoAtual = "O";
                        Console.WriteLine("Virou a Oeste!");

                    }
                    else

                   if (cordenadaSeparada[i] == 'M' && PosicaoAtual == "O")
                    {

                        if (PosicaoX <= 0)
                        {
                            Console.WriteLine("Erro: Limite de alcance...");

                        }
                        else
                        {
                            PosicaoX -= 1;
                            Console.WriteLine("Mecheu a Oeste");
                        }

                    }
                    else
                    if (cordenadaSeparada[i] == 'M' && PosicaoAtual == "N")
                    {
                        if (PosicaoY >= Y)
                        {
                            Console.WriteLine("Erro: Limite de alcance...");
                        }
                        else
                        {
                            PosicaoY += 1;
                            Console.WriteLine("Mecheu a Norte");
                        }
                    }
                    else
                    if (cordenadaSeparada[i] == 'M' && PosicaoAtual == "L")
                    {
                        if (PosicaoX > X)
                        {
                            Console.WriteLine("Erro: Limite de alcance...");

                        }
                        else
                        {
                            PosicaoX += 1;
                            Console.WriteLine("Mecheu a Leste");
                        }


                    }
                    else
                    if (cordenadaSeparada[i] == 'M' && PosicaoAtual == "S")
                    {
                        if (PosicaoY <= 0)
                        {
                            Console.WriteLine("Erro: Limite de alcance...");
                        }
                        else
                        {
                            PosicaoY -= 1;
                            Console.WriteLine("Mecheu a sul");
                        }
                    }
                }

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("--------------------------------------------");
                #endregion


                #region ROBO 2

                for (int i = 0; i < QuantasCords2; i++)
                {
                    if (PosicaoX2 < 0)
                    {
                        Console.WriteLine("Erro: Limite de alcance...");
                    }
                    else
                    if (PosicaoY2 < 0)
                    {
                        Console.WriteLine("Erro: Limite de alcance...");
                    }
                    else
                    if (PosicaoX2 > X)
                    {
                        Console.WriteLine("Erro: Limite de alcance...");
                    }
                    else
                    if (PosicaoY2 > Y)
                    {
                        Console.WriteLine("Erro: Limite de alcance...");
                    }
                    else
                    if (cordenadaSeparada2[i] == 'E' && PosicaoAtual2 == "O")
                    {
                        PosicaoAtual2 = "S";
                        Console.WriteLine("Virou a Sul!");

                    }
                    else
                    if (cordenadaSeparada2[i] == 'E' && PosicaoAtual2 == "N")
                    {
                        PosicaoAtual2 = "O";
                        Console.WriteLine("Virou a Oeste!");


                    }
                    else
                    if (cordenadaSeparada2[i] == 'E' && PosicaoAtual2 == "L")
                    {
                        PosicaoAtual2 = "N";
                        Console.WriteLine("Virou a Norte!");

                    }
                    else
                    if (cordenadaSeparada2[i] == 'E' && PosicaoAtual2 == "S")
                    {
                        PosicaoAtual2 = "L";
                        Console.WriteLine("Virou a Leste!");

                    }
                    else

                    if (cordenadaSeparada2[i] == 'D' && PosicaoAtual2 == "O")
                    {
                        PosicaoAtual2 = "N";
                        Console.WriteLine("Virou a Norte!");

                    }
                    else
                    if (cordenadaSeparada2[i] == 'D' && PosicaoAtual2 == "N")
                    {
                        PosicaoAtual2 = "L";
                        Console.WriteLine("Virou a Leste!");

                    }
                    else
                    if (cordenadaSeparada2[i] == 'D' && PosicaoAtual2 == "L")
                    {
                        PosicaoAtual2 = "S";
                        Console.WriteLine("Virou a Sul!");

                    }
                    else
                    if (cordenadaSeparada2[i] == 'D' && PosicaoAtual2 == "S")
                    {
                        PosicaoAtual2 = "O";
                        Console.WriteLine("Virou a Oeste!");

                    }
                    else

                    if (cordenadaSeparada2[i] == 'M' && PosicaoAtual2 == "O")
                    {

                        if (PosicaoX2 <= 0)
                        {
                            Console.WriteLine("Erro: Limite de alcance...");

                        }
                        else
                        {
                            PosicaoX2 -= 1;
                            Console.WriteLine("Mecheu a Oeste");
                        }

                    }
                    else
                    if (cordenadaSeparada2[i] == 'M' && PosicaoAtual2 == "N")
                    {
                        if (PosicaoY2 >= Y)
                        {
                            Console.WriteLine("Erro: Limite de alcance...");
                        }
                        else
                        {
                            PosicaoY2 += 1;
                            Console.WriteLine("Mecheu a Norte");
                        }
                    }
                    else
                    if (cordenadaSeparada2[i] == 'M' && PosicaoAtual2 == "L")
                    {
                        if (PosicaoX2 > X)
                        {
                            Console.WriteLine("Erro: Limite de alcance...");

                        }
                        else
                        {
                            PosicaoX2 += 1;
                            Console.WriteLine("Mecheu a Leste");
                        }


                    }
                    else
                    if (cordenadaSeparada2[i] == 'M' && PosicaoAtual2 == "S")
                    {
                        if (PosicaoY2 <= 0)
                        {
                            Console.WriteLine("Erro: Limite de alcance...");
                        }
                        else
                        {
                            PosicaoY2 -= 1;
                            Console.WriteLine("Mecheu a sul");
                        }
                    }
                }

                #endregion


                Console.WriteLine("Direção = " + PosicaoAtual + ", X = " + PosicaoX + " Y = " + PosicaoY);
                Console.WriteLine("Direção = " + PosicaoAtual2 + ", X = " + PosicaoX2 + " Y = " + PosicaoY2);

                Console.WriteLine("Sair?  S/N ");
                resposta = (Console.ReadLine());


            }
        }


    }
}

