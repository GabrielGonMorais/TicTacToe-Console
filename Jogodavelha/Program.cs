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
            Funcionalidades.TabuleiroReferencia();

            Console.WriteLine("\nDigite o nome do primeiro jogador: ");
            player1.nome = Console.ReadLine();

            Console.WriteLine("\nDigite o nome do segundo jogador: ");
            player2.nome = Console.ReadLine();
            Console.Clear();

            while (fimdejogo == false)
            {
                Funcionalidades.Resetar();
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

                Funcionalidades.Resetar();
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


        
    }
}
