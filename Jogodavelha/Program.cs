using System;

namespace Jogodavelha
{
    class Program
    {
        public static Players player1 = new Players() { Symbol = 'X' };
        public static Players player2 = new Players() { Symbol = 'O' };
                  
        static void Main()
        {          
            Console.WriteLine("## Welcome to the Tic-Tac-Toe ##\n\n");
            Functionalities.FixedGameBoard();
            
            player1.ChooseTheName("first");            

            player2.ChooseTheName("second");

            Console.Clear();
            Functionalities.GameLoop();
        }
    }
}
