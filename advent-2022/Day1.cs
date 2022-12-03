using System;
using System.Collections.Generic;


class Day1
{
    public void Run()
    {
        // The files used in this example are created in the topic
        // How to: Write to a Text File. You can change the path and
        // file name to substitute text files of your own.

        // Example #1
        // Read the file as one string.
        string text = System.IO.File.ReadAllText(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day1\input.txt");

        // Display the file contents to the console. Variable text is a string.
        string[] subs = text.Split('\n');


        List<int> list = new List<int>();
        list.Add(0);

        int iter = 0;

        foreach (string item in subs)
        {
            try {
                list[iter] += Int32.Parse(item);
            }
            catch {
                list.Add(0);
                iter++;
            }
        }

        list.Sort();

        /*foreach (int item in list)
        {
            Console.WriteLine(item);
        }*/

       /* int final_num = list.Count;*/

        Console.WriteLine($"Final awnser: {list[list.Count-1] + list[list.Count - 2] + list[list.Count - 3]}");

    /*    Console.WriteLine(list.Max());*/

        //System.Console.WriteLine("Contents of WriteText.txt = {0}", text);


        // Keep the console window open in debug mode.
        //Console.WriteLine("Press any key to exit.");
        //System.Console.ReadKey();
    }
}