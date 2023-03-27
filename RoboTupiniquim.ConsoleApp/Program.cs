using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static char[] cordenadaSeparada;
        static int QuantasCords;
        static string PosicaoAtual;
        static int PosicaoX = 0;
        static int PosicaoY = 0;
        static string PosicaoAtual2;
        static int PosicaoX2 = 0;
        static int PosicaoY2 = 0;
        static char[] cordenadaSeparada2;
        static int QuantasCords2;
        static int X, Y;

        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";



            while (resposta.ToUpper() != sair)
            {
                PegaTamanhoDoMapa();
                PegaAsPosicoes();
                if (Erros(PosicaoX, PosicaoY) == true)
                {
                    Erros(PosicaoX, PosicaoY);
                    continue;
                }
                PegaCoordenadasDoUsuario();


                PegaAsPosicoes2();
                if (Erros(PosicaoX2, PosicaoY2) == true)
                {
                    Erros(PosicaoX2, PosicaoY2);
                    continue;
                }
                PegaCoordenadasDoUsuario2();


                MecheRobos();
                MostraAsPosicoesParaOUsuario();
                Console.WriteLine("Sair?  S/N ");
                resposta = (Console.ReadLine());

            }
        }

        private static void MecheRobos()
        {
            for (int i = 0; i < QuantasCords; i++)
            {
                MecheRoboNoGrid(i);
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < QuantasCords2; i++)
            {
                MecheRobo2NoGrid(i);
            }
        }

        private static void MostraAsPosicoesParaOUsuario()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Direção = " + PosicaoAtual + ", X = " + PosicaoX + " Y = " + PosicaoY);
            Console.WriteLine("Direção = " + PosicaoAtual2 + ", X = " + PosicaoX2 + " Y = " + PosicaoY2);
            Console.WriteLine("--------------------------------------------");
        }

        private static void MecheRobo2NoGrid(int i)
        {
            VerificaSeRobo2EstaNoGrid();

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
                    MensagemDeErro("Erro: Limite de alcance...");

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
                    MensagemDeErro("Erro: Limite de alcance...");
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
                    MensagemDeErro("Erro: Limite de alcance...");

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
                    MensagemDeErro("Erro: Limite de alcance...");
                }
                else
                {
                    PosicaoY2 -= 1;
                    Console.WriteLine("Mecheu a sul");
                }
            }
        }

        private static void VerificaSeRobo2EstaNoGrid()
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
        }

        private static void MecheRoboNoGrid(int i)
        {
            VerificaSeRoboEstaNoGrid();

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
            if (cordenadaSeparada[i] == 'M' && PosicaoAtual == "O")
            {

                if (PosicaoX <= 0)
                {
                    MensagemDeErro("Erro: Limite de alcance...");

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
                    MensagemDeErro("Erro: Limite de alcance...");
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
                    MensagemDeErro("Erro: Limite de alcance...");

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
                    MensagemDeErro("Erro: Limite de alcance...");
                }
                else
                {
                    PosicaoY -= 1;
                    Console.WriteLine("Mecheu a sul");
                }
            }
        }

        private static void VerificaSeRoboEstaNoGrid()
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

            
        }

        private static void PegaCoordenadasDoUsuario2()
        {
            Console.WriteLine("Como movimentar o ROBÔ 2: \n---------\n E : vira à esquerda || D : vira à direita || M : Faz o movimento na direção\n Exemplo: EMEMEMEMM");
            string cordenadas2 = Console.ReadLine().ToUpper();
            cordenadaSeparada2 = cordenadas2.ToCharArray();
            QuantasCords2 = Convert.ToInt32(cordenadaSeparada2.Length);
        }

        private static void PegaAsPosicoes2()
        {
            Console.WriteLine("Posição X DO ROBÔ 2: ");
            PosicaoX2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Posição Y DO ROBÔ 2: ");
            PosicaoY2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para Qual Ponto Cardeal O ROBÔ 2 está Olhando?: ");
            PosicaoAtual2 = Console.ReadLine().ToUpper();
        }

        private static void PegaCoordenadasDoUsuario()
        {
            Console.WriteLine("Como movimentar o ROBÔ 1: \n---------\n E : vira à esquerda || D : vira à direita || M : Faz o movimento na direção\n Exemplo: EMEMEMEMM");
            string cordenadas = Console.ReadLine().ToUpper();
            cordenadaSeparada = cordenadas.ToCharArray();
            QuantasCords = Convert.ToInt32(cordenadaSeparada.Length);
        }

        private static void MensagemDeErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void PegaTamanhoDoMapa()
        {
            Console.WriteLine("Tamanho do Lugar X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tamanho do Lugar Y: ");
            Y = Convert.ToInt32(Console.ReadLine());
            int[,] mapa = new int[X, Y];
        }

        private static void PegaAsPosicoes()
        {
            Console.WriteLine("Posição X DO ROBÔ 1: ");
            PosicaoX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Posição Y DO ROBÔ 1: ");
            PosicaoY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para Qual Ponto Cardeal O ROBÔ 1 está Olhando?: ");
            PosicaoAtual = Console.ReadLine().ToUpper();
        }

        static bool Erros(int PosicaoX, int PosicaoY)
        {

            if (PosicaoX < 0)
            {
                MensagemDeErro("Posição X tem q ser maior que 0:");
                return true;
            }
            if (PosicaoX > X)
            {
                MensagemDeErro("Posição X tem q ser menor doque o limite:");
                return true;
            }
            if (PosicaoY < 0)
            {
                MensagemDeErro("Posição Y tem q ser maior doque 0:");
                return true;
            }
            if (PosicaoY > Y)
            {
                MensagemDeErro("Posição Y tem q ser menor doque o limite:");
                return true;

            }
            else
            {
                return false;
            }
           
        }
    }
}

