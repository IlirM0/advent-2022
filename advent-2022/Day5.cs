using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_2022
{
    class Day5
    {

        public void Run()
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day2\input.txt");

            // Display the file contents to the console. Variable text is a string.
            string[] array_of_lines = File.ReadAllLines(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day5\input.txt");


            List<char>[] data = new List<char>[9];
            /*for (int i = 0; i < a.Length; i++)
            {
                
            }*/
            data[0] = new List<char>() { 'D', 'M', 'S', 'Z', 'R', 'F', 'W', 'N' };
            data[1] = new List<char>() { 'W', 'P', 'Q', 'G', 'S' };
            data[2] = new List<char>() { 'W', 'R', 'V', 'Q', 'F', 'N', 'J', 'C' };
            data[3] = new List<char>() { 'F', 'Z', 'P', 'C', 'G', 'D', 'L' };
            data[4] = new List<char>() { 'T', 'P', 'S' };
            data[5] = new List<char>() { 'H', 'D', 'F', 'W', 'R', 'L' };
            data[6] = new List<char>() { 'Z', 'N', 'D', 'C' };
            data[7] = new List<char>() { 'W', 'N', 'R', 'F', 'V', 'S', 'J', 'Q' };
            data[8] = new List<char>() { 'R', 'M', 'S', 'G', 'Z', 'W', 'V' };
            // 8 high, 9 wide

            List<int[]> movin = new List<int[]>();

            foreach (string line in array_of_lines)
            {
                string[] seperator = { "move ", " from ", " to " };
                string[] list = line.Split(seperator,StringSplitOptions.RemoveEmptyEntries);
                int[] int_list = Array.ConvertAll(list, int.Parse);
                /*foreach (int item in int_list)
                {
                    Console.WriteLine(item);
                }*/
                movin.Add(int_list);
            }

            foreach (int[] item in movin)
            {
                /*for (int i = 0; i < item[0]; i++)
                {
                    char char_to_move = data[item[1] - 1][data[item[1] - 1].Count - 1];
                    data[item[1] - 1].RemoveAt(data[item[1] - 1].Count - 1);
                    data[item[2] - 1].Add(char_to_move);
                    
                }*/
                for (int i = item[0]; 0 < i; i--)
                {
                    /*char char_to_move = data[item[1] - 1][data[item[1] - 1].Count - 1 - i];
                    data[item[1] - 1].RemoveAt(data[item[1] - 1].Count - 1);*/
                    data[item[2] - 1].Add(data[item[1] - 1][data[item[1] - 1].Count - i]);

                }
                for (int i = 0; i < item[0]; i++)
                {
                    data[item[1] - 1].RemoveAt(data[item[1] - 1].Count - 1);
                }

            }

            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{data[i][data[i].Count - 1]}");
            }
            Console.Write("\n");
        }
    }
}

