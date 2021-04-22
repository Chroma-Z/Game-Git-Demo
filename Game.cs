using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Game_Git_Demo
{
    class Game
    {
        public void Run()
        {
            WriteLine("Welcome to the Game");

            Write("\nWhat is you name?");
            string name = ReadLine();
            Player currentPlayer = new Player(name);
            WriteLine($"Let's get started {currentPlayer.Name}!");

            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }
        



    }
}
