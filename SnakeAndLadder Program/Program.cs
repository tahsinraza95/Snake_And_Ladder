﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder_Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~Welcome To The Snake And Ladder Program~~~~");
            SnakeAndLadder snakeLadder = new SnakeAndLadder();
            snakeLadder.Game();
            Console.ReadLine();
        }
    }
}
