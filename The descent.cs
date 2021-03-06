using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class Player
{
    static void Main(string[] args)
    {

    int save = 0;
    int target = 0;

        // game loop
        while (true)
        {
            for (int i = 0; i < 8; i++)
            {
                save = 0;
                for (int j = 0; j < 8; j++)
                {
                    int mountainH = int.Parse(Console.ReadLine());
                    if (save < mountainH) {
                        save = mountainH;
                        target = j;
                    }
                }
                /*
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                Console.WriteLine(i);*/
                Console.WriteLine(target);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("4"); // The index of the mountain to fire on.
        }
    }
}