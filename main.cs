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
            //Console.Error.WriteLine(line + " nbline " + i );
        }
        string rep = string.Empty;
        tab.ForEach(s => {Console.Error.WriteLine(s);});
        /*tab.ForEach(s => {
            var line = s.ToList().Select(c => c.ToString()).ToList();
            line.ForEach(node => {
                if(node.Equals('0'))
                {
                    rep += tab.Current + " " + line.Current + " ";
                    var rightnode = line.Find(l => l.Equals('0') && line.IndexOf(l) > line.IndexOf(node));
                    if(rightnode != null)
                    {
                        rep += tab.Current + " " + line.IndexOf(rightnode) + " ";
                    }
                    Console.WriteLine(rep);
                }
            });
        });*/

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if(tab[i][j] == '0')
                {
                    rep = j + " " + i + " ";
                    int k = j+1;
                    bool find = false;
                    // coté droite
                    while (k < width && !find)
                    {
                        if(tab[i][k] == '0')
                        {
                            find = true;
                        }
                        else
                        {
                            k++;
                        }
                    }
                    if(find)
                    {
                        rep += k + " " + i + " ";
                    }
                    else
                    {
                        rep += "-1 -1 ";
                    }
                    // en dessous
                    k = i+1;
                    find = false;
                    while (k < height && !find)
                    {
                        if(tab[k][j] == '0')
                        {
                            find = true;
                        }
                        else
                        {
                            k++;
                        }
                    }
                    if(find)
                    {
                        rep += j + " " + k + " ";
                    }
                    else
                    {
                        rep += "-1 -1 ";
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