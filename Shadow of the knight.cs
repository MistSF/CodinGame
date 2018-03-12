using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);
        
        int X = X0;
        int Y = Y0;
        
        int minX = 0;
        int maxX = W - 1;
        int minY = 0;
        int maxY = H - 1;
        // game loop
        
        while (true)
        {        
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)    
            
            if (bombDir.Contains("U"))
                maxY = Y - 1;
            else if (bombDir.Contains("D"))
                minY = Y + 1;
            if (bombDir.Contains("L"))
                maxX = X - 1;
            else if (bombDir.Contains("R"))
                minX = X + 1;
            
            X = minX + (maxX - minX) / 2;
            Y = minY + (maxY - minY) / 2;
                            
            Console.WriteLine(X + " " + Y);
        }
    }
}