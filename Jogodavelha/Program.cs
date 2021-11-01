using System;

namespace Jogodavelha
{
    class Program
    {
        public static Players player1 = new Player1();
        public static Players player2 = new Player2();        

        static void Main()
        {          
            Console.WriteLine("## Welcome to the Tic-Tac-Toe ##\n\n");
            Functionalities.FixedGameBoard();
            
            player1.ChooseTheName();

            player2.ChooseTheName();

            Console.Clear();
            Functionalities.GameLoop();
        }
    }
}
