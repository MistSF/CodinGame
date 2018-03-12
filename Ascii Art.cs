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
class Solution
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        string text;
        string R = "";
        int t;  // lettre cible
        
//        Console.WriteLine(T);
        
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            text = ROW;
            for (int x = 0; x < T.Length; x++) {
                t = (int)T[x];
                if (t >= 65 && t <= 90)
                    t -= 65;
                else if (t >= 97 && t <= 122) {
                    t -= 97;
                }
                else
                    t = 26;
                t *= L;
                for (int j = 0; j < L; j++)
                    R += text[j + t];
            }
            Console.WriteLine(R);
            R = "";
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        //Console.WriteLine();
    }
}