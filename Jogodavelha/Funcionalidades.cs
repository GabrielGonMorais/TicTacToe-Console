using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogodavelha
{
    class Funcionalidades
    {
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
            Console.WriteLine($"{Program.player1.nome} : {Program.player1.vitorias}");
            Console.WriteLine($"{Program.player2.nome} : {Program.player2.vitorias}");
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
            if (i == 0 && Program.fimPartida == false)
            {
                Placar();
                Tabuleiro();

                Console.WriteLine("!!!!! A partida empatou!!!!!! Pressione enter");
                Program.fimPartida = true;
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
