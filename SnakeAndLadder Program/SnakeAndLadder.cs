using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder_Program
{
    internal class SnakeAndLadder
    {
        internal int PlayerPosition = 0;
        public void Game()
        {
            Random random= new Random();
            int DieRoll = random.Next(1, 7);
            PlayerPosition = DieRoll;
            Console.WriteLine("Plaer Position is :" + PlayerPosition);
        }
    }
}
