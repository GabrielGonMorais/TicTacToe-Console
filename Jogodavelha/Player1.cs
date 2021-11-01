using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogodavelha
{
    class Player1 : Players
    {
        public override void ChooseTheName()
        {
            Console.WriteLine("\nEnter the first player's name: ");
            Name = Console.ReadLine();            
        }

        public override void ChoosePosition()
        {
            bool repeatedPosition = false;

            do
            {
                Functionalities.Score();
                Functionalities.GameBoard();

                Console.WriteLine($"{Name}, Choose a position (look at the top of the console): ");
                try
                {
                    int chosenPosition = int.Parse(Console.ReadLine()) - 1;
                    if (Functionalities.position[chosenPosition] == " ")
                    {
                        Functionalities.position[chosenPosition] = "X";
                        repeatedPosition = false;
                    }
                    else
                    {
                        Console.WriteLine("Ooops..... this position has already been chosen..\nTry again:");
                        repeatedPosition = true;
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    repeatedPosition = true;
                    Console.WriteLine("Invalid key. Press enter..");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (repeatedPosition == true);

            Console.Clear();
        }

        public override void VerifyWinner()
        {

            if (Functionalities.position[0] == Functionalities.position[1] && Functionalities.position[1] == Functionalities.position[2] && Functionalities.position[1] == "X" || Functionalities.position[3] == Functionalities.position[4] && Functionalities.position[4] == Functionalities.position[5] && Functionalities.position[4] == "X" || Functionalities.position[6] == Functionalities.position[7] && Functionalities.position[7] == Functionalities.position[8] && Functionalities.position[7] == "X" || Functionalities.position[0] == Functionalities.position[3] && Functionalities.position[3] == Functionalities.position[6] && Functionalities.position[3] == "X" || Functionalities.position[1] == Functionalities.position[4] && Functionalities.position[4] == Functionalities.position[7] && Functionalities.position[4] == "X" || Functionalities.position[2] == Functionalities.position[5] && Functionalities.position[5] == Functionalities.position[8] && Functionalities.position[5] == "X" || Functionalities.position[0] == Functionalities.position[4] && Functionalities.position[4] == Functionalities.position[8] && Functionalities.position[4] == "X" || Functionalities.position[2] == Functionalities.position[4] && Functionalities.position[4] == Functionalities.position[6] && Functionalities.position[4] == "X")
            {
                Functionalities.Score();
                Functionalities.GameBoard();

                Console.WriteLine($"{Name} wins!!!!!!! Press Enter");
                Victories++;
                Functionalities.EndMatch = true;

                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Functionalities.EndMatch = false;
            }

            Functionalities.VerifyDraw();

        }
    }
}
