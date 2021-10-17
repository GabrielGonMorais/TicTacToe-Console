using System;

namespace Jogodavelha
{
    class Program
    {
        public static Jogadores player1 = new Jogador1();
        public static Jogadores player2 = new Jogador2();

        public static bool fimPartida;
        public static bool fimdejogo = false;

        static void Main()
        {          
            Console.WriteLine("## Seja bem vindo ao Jogo da velha ##\n\n");
            Funcionalidades.TabuleiroReferencia();

            Console.WriteLine("\nDigite o nome do primeiro jogador: ");
            player1.nome = Console.ReadLine();

            Console.WriteLine("\nDigite o nome do segundo jogador: ");
            player2.nome = Console.ReadLine();
            Console.Clear();

            Funcionalidades.LoopJogar();
        }
    }
}
