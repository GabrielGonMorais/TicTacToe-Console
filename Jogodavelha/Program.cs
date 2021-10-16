using System;

namespace Jogodavelha
{
    class Program
    {
        public static Jogadores player1 = new Jogador1();
        public static Jogadores player2 = new Jogador2();

        public static bool fimPartida;

        static void Main()
        {
            bool fimdejogo = false;

            Console.WriteLine("## Seja bem vindo ao Jogo da velha ##\n\n");
            TabuleiroReferencia();

            Console.WriteLine("\nDigite o nome do primeiro jogador: ");
            player1.nome = Console.ReadLine();

            Console.WriteLine("\nDigite o nome do segundo jogador: ");
            player2.nome = Console.ReadLine();
            Console.Clear();

            while (fimdejogo == false)
            {
                Resetar();
                fimPartida = false;
                while (!fimPartida)
                {
                    player1.Verificar();
                    player1.Escolha();
                    player1.Verificar();
                    if (fimPartida == true)
                    {
                        break;
                    }
                    player2.Escolha();
                    player2.Verificar();
                }

                Resetar();
                fimPartida = false;
                while (!fimPartida)
                {
                    player2.Verificar();
                    player2.Escolha();
                    player2.Verificar();
                    if (fimPartida == true)
                    {
                        break;
                    }
                    player1.Escolha();
                    player1.Verificar();
                }

            }

        }


        public static void TabuleiroReferencia()
        {
            Console.WriteLine("#######################");
            Console.WriteLine("###  7  |  8  |  9  ###");
            Console.WriteLine("###----- ----- -----###");
            Console.WriteLine("###  4  |  5  |  6  ###");
            Console.WriteLine("###----- ----- -----###");
            Console.WriteLine("###  1  |  2  |  3  ###");
            Console.WriteLine("#######################\n");
            Console.WriteLine("===========================");

        }

        public static void Tabuleiro()
        {
            TabuleiroReferencia();

            Console.Write($"  {Jogadores.position[6]}  |");
            Console.Write($"  {Jogadores.position[7]}  |");
            Console.WriteLine($"  {Jogadores.position[8]}  ");
            Console.WriteLine($"----- ----- -----");
            Console.Write($"  {Jogadores.position[3]}  |");
            Console.Write($"  {Jogadores.position[4]}  |");
            Console.WriteLine($"  {Jogadores.position[5]}  ");
            Console.WriteLine($"----- ----- -----");
            Console.Write($"  {Jogadores.position[0]}  |");
            Console.Write($"  {Jogadores.position[1]}  |");
            Console.WriteLine($"  {Jogadores.position[2]}  \n");
        }

        public static void Placar()
        {
            Console.WriteLine($"{player1.nome} : {player1.vitorias}");
            Console.WriteLine($"{player2.nome} : {player2.vitorias}");
        }

        public static void Resetar()
        {
            for (int x = 0; x < Jogadores.position.Length; x++)
            {
                Jogadores.position[x] = " ";
            }
        }

        public static void VerificarEmpate()
        {
            int i = 0;
            for (int x = 0; x < Jogadores.position.Length; x++)
            {
                if (Jogadores.position[x] == " ")
                {
                    i++;
                }
            }
            if (i == 0 && fimPartida == false)
            {
                Program.Placar();
                Program.Tabuleiro();

                Console.WriteLine("!!!!! A partida empatou!!!!!! Pressione enter");
                fimPartida = true;
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
