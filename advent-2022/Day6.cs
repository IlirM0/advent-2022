using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_2022
{
    class Day6
    {

        public void Run()
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day2\input.txt");

            // Display the file contents to the console. Variable text is a string.
            string[] array_of_lines = File.ReadAllLines(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day6\input.txt");

            char c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14;

            bool once = true;

            for (int i = 13; i < array_of_lines[0].Length; i++)
            {
                c1 = array_of_lines[0][i];
                c2 = array_of_lines[0][i - 1];
                c3 = array_of_lines[0][i - 2];
                c4 = array_of_lines[0][i - 3];
                c5 = array_of_lines[0][i - 4];
                c6 = array_of_lines[0][i - 5];
                c7 = array_of_lines[0][i - 6];
                c8 = array_of_lines[0][i - 7];
                c9 = array_of_lines[0][i - 8];
                c10 = array_of_lines[0][i - 9];
                c11 = array_of_lines[0][i - 10];
                c12 = array_of_lines[0][i - 11];
                c13 = array_of_lines[0][i - 12];
                c14 = array_of_lines[0][i - 13];

                var allNotEq = new[] {c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14}.Distinct().Count() == 14;
                if (allNotEq && once) {
                    Console.WriteLine(i+1);
                    once = false;
                }
            }
            /*Console.WriteLine(array_of_lines[0]);
            Console.WriteLine(array_of_lines[0].Length);*/
        }
    }
}

