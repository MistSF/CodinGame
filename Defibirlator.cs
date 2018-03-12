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
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        string LON2 = "";
        string LAT2 = "";
        int N = int.Parse(Console.ReadLine());
        
        List<String> list = new List<String>();
        List<String> listName = new List<String>();
        List<Double> distance = new List<Double>();
        int saveID = 0;        
        
        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            list.Add(DEFIB);
        }

        for (int i = 0; i < list.Count; i++)
        {
            string id = "";
            string name = "";
            string address = "";
            string lon = "";
            string lat = "";
        
            int add = 0;
        
            for (int j = 0; j < list[i].Length; j++) {
                if (list[i][j] == ';')
                    add++;
                else
                    switch(add) {
                        case 0:
                            id += list[i][j];
                            break;
                        case 1:
                            name += list[i][j];
                            break;
                        case 2:
                            address += list[i][j];
                            break;
                        case 4:
                            if (list[i][j] == ',')
                                lon += '.';
                            else
                                lon += list[i][j];
                            break;
                        case 5:
                            if (list[i][j] == ',')
                                lat += '.';
                            else
                                lat += list[i][j];
                            break;
                    }
            }
            
            for (int x = 0; x < LON.Length; x++) {
                if (LON[x] == ',')
                    LON2 += '.';
                else
                    LON2 += LON[x];
            }
            
            for (int x = 0; x < LAT.Length; x++) {
                if (LAT[x] == ',')
                    LAT2 += '.';
                else
                    LAT2 += LAT[x];
            }
            /*  
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(lon);
            Console.WriteLine(lat);
            Console.WriteLine("");*/
            
            double lon2 = Convert.ToDouble(lon);
            double lat2 = Convert.ToDouble(lat);
            
            double X = (lon2 - Convert.ToDouble(LON2)) * Math.Cos((lat2 + Convert.ToDouble(LAT2)) / 2);
            double Y = (lat2 - Convert.ToDouble(LAT2));
            double D = Math.Sqrt((X * X) + (Y * Y)) * 6371;            
            /*
            Console.WriteLine("x : " + X);
            Console.WriteLine("y : " + Y);
            Console.WriteLine("d : " + D);*/
            
            distance.Add(D);
            listName.Add(name);
            
            LON2 = "";
            LAT2 = "";
        }

        int target = 0;
        double save = distance[0];

        for (int i = 0; i < distance.Count; i++) {
            if (save > distance[i]) {
                save = distance[i];
                target = i;
            }
        }

        Console.WriteLine(listName[target]);
        
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        //Console.WriteLine("answer");
    }
}