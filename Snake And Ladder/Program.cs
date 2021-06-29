using System;

namespace Snake_And_Ladder
{
    class Program
    {
        // Starting position in the game is 0
        //The Player starts from 0 and palys the game till the winning spot 100 is achieved.
        public const int STAST = 0;
        public const int FINISH = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome To Snake and Ladder game.");
            
            int player_position = 0;
            Console.WriteLine("player current position is " + player_position);
        }
    }
}
