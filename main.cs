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
        var tab = new List<string>();
        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine(); // width characters, each either 0 or .
            tab.Add(line);
            Console.Error.WriteLine(line + " nbline " + i );
        }
        string rep = string.Empty;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Error.WriteLine(tab[i][j] + " " + i + " " + j);
                if(tab[i][j] == '0')
                {
                    rep = i + " " + j + " ";
                    if(i+1 == height || tab[i+1][j] != '0')
                    {
                        rep += "-1 -1 ";
                    }
                    else
                    {
                        rep += i+1 + " " + j + " ";
                    }
                    if(j+1 == width || tab[i][j+1] != '0')
                    {
                        rep += "-1 -1 ";
                    }
                    else
                    {
                        rep += i + " " + j+1 + " ";
                    }
                    
                    Console.WriteLine(rep);
                }
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        // Three coordinates: a node, its right neighbor, its bottom neighbor
        
    }
}