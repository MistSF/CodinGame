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
        int N = int.Parse(inputs[0]); // the total number of nodes in the level, including the gateways
        int L = int.Parse(inputs[1]); // the number of links
        int E = int.Parse(inputs[2]); // the number of exit gateways
        
        List<String> cut = new List<String>();
        List<int> GA = new List<int>();
        
        for (int i = 0; i < L; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int N1 = int.Parse(inputs[0]); // N1 and N2 defines a link between these nodes
            int N2 = int.Parse(inputs[1]);
            if (N1 < N2)
                cut.Add(N1 + " " + N2);
            else
                cut.Add(N2 + " " + N1);
        }
        
        cut.Sort();
        //string[] test = cut[0].Split(' ');
        
        for (int i = 0; i < E; i++)
        {
            int EI = int.Parse(Console.ReadLine()); // the index of a gateway node
            GA.Add(EI);
        }


        // game loop
        while (true)
        {
            int SI = int.Parse(Console.ReadLine()); // The index of the node on which the Skynet agent is positioned this turn
            string res = "";
            
            for (int i = 0; i < cut.Count; i++) {
                
                string[] test = cut[i].Split(' ');

                    if (SI == Int32.Parse(test[0])) {
                        res = SI + " " + test[1];
                        for (int j = 0; j < GA.Count; j++)
                            if (GA[j].ToString() == test[1])
                                i = cut.Count;
                    }
                    else if (SI == Int32.Parse(test[1])) {
                        res = SI + " " + test[0];
                        for (int j = 0; j < GA.Count; j++)
                            if (GA[j].ToString() == test[0])
                                i = cut.Count;
                    }
            }
            
            Console.WriteLine(res);
            cut.Remove(res);

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            // Example: 0 1 are the indices of the nodes you wish to sever the link between
        }
    }
}