using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_2022
{
    class Day3
    {
        
        public void Run() {
            //string text = System.IO.File.ReadAllText(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day2\input.txt");

            // Display the file contents to the console. Variable text is a string.
string[] subs = File.ReadAllLines(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day3\input.txt");

            int total_points = 0;

            /*foreach (string s in subs) {
                bool[] half1 = new bool[52];
                bool[] half2 = new bool[52];
                for (int i = 0; i < 52; i++)
                {
                    half1[i] = false;
                    half2[i] = false;
                }
                for (int counter = 0; counter < s.Length; counter++)
                {
                    if (counter < (s.Length / 2))
                    {
                        if (Char.IsUpper(s[counter]))
                        {
                            half1[s[counter] - 'A' + 26] = true;
                        }
                        else {
                            half1[s[counter] - 'a'] = true;
                        }
                    }
                    else {
                        if (Char.IsUpper(s[counter]))
                        {
                            half2[s[counter] - 'A' + 26] = true;
                        }
                        else
                        {
                            half2[s[counter] - 'a'] = true;
                        }
                    }
                }
                for (int i = 0; i < 52; i++)
                {
                    if (half1[i] && half2[i])
                    {
                        total_points += (i + 1);
                    }
                }

            }*/
            int cnt = 0;
            string[] uno = new string[3];
            foreach (string s in subs) {
                if (cnt != 2)
                {
                    uno[cnt] = s;
                    cnt++;
                }
                else
                {
                    uno[2] = s;

                    bool[] half1 = new bool[52*3];
                    for (int i = 0; i < (52 * 3); i++)
                    {
                        half1[i] = false;
                    }
                    for (int p = 0; p<3; p++)
                    {
                        for (int counter = 0; counter < uno[p].Length; counter++)
                        {
                            if (Char.IsUpper(uno[p][counter]))
                            {
                                half1[uno[p][counter] - 'A' + 26 + (52*p)] = true;
                            }
                            else
                            {
                                half1[uno[p][counter] - 'a' + (52 * p)] = true;
                            }
                        }
                        for (int i = 0; i < 52; i++)
                        {
                            if (half1[i] && half1[i+52] && half1[i+(52*2)])
                            {
                                total_points += (i + 1);
                            }
                        }

                    }
                    cnt = 0;
                }
            }
            Console.WriteLine(total_points);


        }
    }
}
