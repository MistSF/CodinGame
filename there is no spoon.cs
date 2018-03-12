using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Don't let the machines win. You are humanity's last hope...
 **/
class Player
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
        
        List<String> map = new List<String>();
        string test = "";
        
        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine(); // width characters, each either 0 or .
            map.Add(line);
        }

        for (int i = 0; i < map.Count; i++) {            
            for (int j = 0; j < map[i].Length; j++) {
                
                int x1 = -1;
                int y1 = -1;
                int x2 = -1;
                int y2 = -1;
                int x3 = -1;
                int y3 = -1;
                
                if (map[i][j] == '0') {
                    x1 = j;
                    y1 = i;
                    for (int c = j + 1; c < map[i].Length; c++) {
                        if (map[i][c] == '0') {
                            x2 = c;
                            y2 = i;
                            c = map[i].Length;
                        }
                    }
                    for (int c = i + 1; c < map.Count; c++) {
                        if (map[c][j] == '0'){
                            x3 = j;
                            y3 = c;
                            c = map.Count;
                        }
                    }
                    Console.WriteLine(x1 + " " + y1 + " " + x2 + " " + y2 + " "+ x3 + " " + y3);
                }
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        // Three coordinates: a node, its right neighbor, its bottom neighbor
        Console.WriteLine(test);
    }
}