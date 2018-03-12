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
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        
        int value = 0;
        string newText = ""; 
        
        string current = "";
        bool add = false;
        bool find = false;
        
        List<String> ext = new List<String>();
        List<String> mt = new List<String>();
        
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
            
            for (int j = 0; j < EXT.Length; j++) {
                value = EXT[j];
                if (value >= 65 && value <= 90)
                    value += 32;
                newText += (char)value;
            }
            
            ext.Add(newText);
            mt.Add(MT);
            newText = "";
        }
        
        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.
            //Console.WriteLine("FNAME : " + FNAME);
            for (int j = 0; j < FNAME.Length; j++) {
                if (add && FNAME[j] != '.')
                    current += FNAME[j];
                else
                    if (FNAME[j] == '.' && add == false)
                        add = true;
                    else if (FNAME[j] == '.' && add == true)
                        current = "";
                        
            }
            
            for (int j = 0; j < current.Length; j++) {
                value = current[j];
                if (value >= 65 && value <= 90)
                    value += 32;
                newText += (char)value;
            }
            
            current = newText;
            
            newText = "";
            
            
            for (int x = 0; x < ext.Count && find == false; x++) {
                if (current == ext[x]) {
                    Console.WriteLine(mt[x]);
                    find = true;
                }
            }
            
            if (find == false)
                Console.WriteLine("UNKNOWN");
                
            current = "";
            find = false;
            add = false;
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        // For each of the Q filenames, display on a line the corresponding MIME type. If there is no corresponding type, then display UNKNOWN.
        //Console.WriteLine("UNKNOWN");
    }
}