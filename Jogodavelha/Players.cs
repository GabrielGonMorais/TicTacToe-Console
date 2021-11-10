using System;


namespace Jogodavelha
{
    class Players
    {
        public string Name { get; private set; }
        public int Victories { get; private set; }              
        public char Symbol { get; init; }

        public void ChooseTheName(string cardinalNumber)
        {
            Console.WriteLine($"\nEnter the {cardinalNumber} player's name: ");
            Name = Console.ReadLine();
        }
        public void ChoosePosition()
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
                    if (Functionalities.position[chosenPosition] == ' ')
                    {
                        Functionalities.position[chosenPosition] = Symbol;
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
        public void VerifyWinner()
        {
            if (Functionalities.position[0] == Functionalities.position[1] && Functionalities.position[1] == Functionalities.position[2] && Functionalities.position[1] == Symbol || Functionalities.position[3] == Functionalities.position[4] && Functionalities.position[4] == Functionalities.position[5] && Functionalities.position[4] == Symbol || Functionalities.position[6] == Functionalities.position[7] && Functionalities.position[7] == Functionalities.position[8] && Functionalities.position[7] == Symbol || Functionalities.position[0] == Functionalities.position[3] && Functionalities.position[3] == Functionalities.position[6] && Functionalities.position[3] == Symbol || Functionalities.position[1] == Functionalities.position[4] && Functionalities.position[4] == Functionalities.position[7] && Functionalities.position[4] == Symbol || Functionalities.position[2] == Functionalities.position[5] && Functionalities.position[5] == Functionalities.position[8] && Functionalities.position[5] == Symbol || Functionalities.position[0] == Functionalities.position[4] && Functionalities.position[4] == Functionalities.position[8] && Functionalities.position[4] == Symbol || Functionalities.position[2] == Functionalities.position[4] && Functionalities.position[4] == Functionalities.position[6] && Functionalities.position[4] == Symbol)
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
