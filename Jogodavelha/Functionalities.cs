using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogodavelha
{
    class Functionalities
    {        
        public static bool EndMatch { get; set; }
        private static bool endGame = false;
        public static char[] position = new char[9];

        public static void GameLoop()
        {
            while (endGame == false)
            {
                ResetPositions();
                EndMatch = false;
                while (!EndMatch)
                {
                    Program.player1.VerifyWinner();
                    Program.player1.ChoosePosition();
                    Program.player1.VerifyWinner();
                    if (EndMatch == true)
                    {
                        break;
                    }
                    Program.player2.ChoosePosition();
                    Program.player2.VerifyWinner();
                }

                ResetPositions();
                EndMatch = false;
                while (!EndMatch)
                {
                    Program.player2.VerifyWinner();
                    Program.player2.ChoosePosition();
                    Program.player2.VerifyWinner();
                    if (EndMatch == true)
                    {
                        break;
                    }
                    Program.player1.ChoosePosition();
                    Program.player1.VerifyWinner();
                }
            }
        }

        public static void FixedGameBoard()
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

        public static void GameBoard()
        {
            FixedGameBoard();

            Console.Write($"  {position[6]}  |");
            Console.Write($"  {position[7]}  |");
            Console.WriteLine($"  {position[8]}  ");
            Console.WriteLine($"----- ----- -----");
            Console.Write($"  {position[3]}  |");
            Console.Write($"  {position[4]}  |");
            Console.WriteLine($"  {position[5]}  ");
            Console.WriteLine($"----- ----- -----");
            Console.Write($"  {position[0]}  |");
            Console.Write($"  {position[1]}  |");
            Console.WriteLine($"  {position[2]}  \n");
        }

        public static void Score()
        {
            Console.WriteLine($"{Program.player1.Name} : {Program.player1.Victories}");
            Console.WriteLine($"{Program.player2.Name} : {Program.player2.Victories}");
        }

        public static void ResetPositions()
        {
            for (byte verify = 0; verify < position.Length; verify++)
            {
                position[verify] = ' ';
            }
        }

        public static void VerifyDraw()
        {
            byte emptyPositions = 0;

            for (byte verify = 0; verify < position.Length; verify++)
            {
                if (position[verify] == ' ')
                {
                    emptyPositions++;
                }
            }
            if (emptyPositions == 0 && EndMatch == false)
            {
                Score();
                GameBoard();

                Console.WriteLine("!!!!! Draw game!!!!!! Press enter");
                EndMatch = true;
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
