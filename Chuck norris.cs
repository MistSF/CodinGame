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
        
        string MESSAGE = Console.ReadLine();
        string binaire = "";
        int ascii = 0;
        
        for (int i = 0; i < MESSAGE.Length ; i++) {
            bool start = false;
            ascii = (int)MESSAGE[i];
            int x = 64;
            
            int test =  ascii;
        
            for (int j = 0; j < 7; j++) {
                if (test >= x){
                    binaire += "1";
                    test -= x;
                }
                else
                    binaire += "0";
                x /= 2;
            }
        }
                
        string res = "";
        bool start2 = false;
        char save = 'a';
        int nb = 0;
        
        for (int i = 0; i < binaire.Length; i++) {
                if (save == binaire[i])
                    nb++;
                else {
                    if (nb > 0) {
                        for (int j = 0; j < nb; j++)
                            res += "0";
                        res += " ";
                        nb = 0;
                    }
                    if (binaire[i] == '0')
                        res += "00 ";
                    else
                        res += "0 ";
                    nb++;
                    save = binaire[i];
                }
            }
        
        for (int j = 0; j < nb; j++)
            res += "0";
            
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        Console.WriteLine(res);
    }
}