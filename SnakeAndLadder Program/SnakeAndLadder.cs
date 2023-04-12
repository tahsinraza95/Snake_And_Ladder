using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder_Program
{
    public class SnakeAndLadder
    {
        internal int PlayerPosition = 0;
        public void Game()
        {
            Random random= new Random();
            int DieRoll = random.Next(1, 7);
            PlayerPosition = DieRoll;
            int Option = random.Next(0, 3);
            switch (Option)
            {
                case 1:
                    Console.WriteLine("No Play : " + PlayerPosition);
                    break;
                case 2:
                    PlayerPosition += DieRoll;
                    Console.WriteLine("lader : " + PlayerPosition);
                    break;
                case 3:
                    PlayerPosition -= DieRoll;
                    Console.WriteLine("Snake : " + PlayerPosition);
                    break;
            }    
        }
    }
}
