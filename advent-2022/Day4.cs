using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_2022
{
    class Day4
    {
        
        public void Run() {
            //string text = System.IO.File.ReadAllText(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day2\input.txt");

            // Display the file contents to the console. Variable text is a string.
            string[] array_of_lines = File.ReadAllLines(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day4\input.txt");

            int total_num = 0;

            foreach (string line in array_of_lines)
            {
                string[] elf_assignment = line.Split(',');
                int low_1, high_1, low_2, high_2;
                string[] elf_1 = elf_assignment[0].Split('-');
                string[] elf_2 = elf_assignment[1].Split('-');
                if (Int32.TryParse(elf_1[0], out low_1) && Int32.TryParse(elf_1[1], out high_1) && Int32.TryParse(elf_2[0], out low_2) && Int32.TryParse(elf_2[1], out high_2))
                {
                    /*if ((low_1 >= low_2 && high_1 <= high_2) || (low_1 <= low_2 && high_1 >= high_2)) { 
                        total_num++;
                    }*/
                    if (high_1 < low_2 || low_1 > high_2 || high_2 < low_1 || low_2 > high_1)
                    {
                        //total_num++;
                    }
                    else {
                        total_num++;
                        Console.WriteLine($"didnt make the cut: \n{low_1} - {high_1}\n{low_2} - {high_2}\n");
                    }
                }
                else {
                    Console.WriteLine("ERROR!");
                }
            }

            Console.WriteLine($"total: {total_num}");

        }
    }
}
