﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TandA
{
    static class GameManager
    {
        public static void ShowTitleScreen()
        {
            Console.WriteLine("Welcome to Hyperion!");
            Console.ReadKey();
        }

        //StartGame()


        public static void EndGame()
        {
            Program.quite = true;
        }

        public static void ApplyRules()
        {

        }
    }
}
