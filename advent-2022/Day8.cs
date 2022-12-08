using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_2022
{
    
    class Day8
    {

        public void Run()
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day2\input.txt");

            // Display the file contents to the console. Variable text is a string.
            string[] array_of_lines = File.ReadAllLines(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day8\input.txt");

            int x_axis_max = array_of_lines[0].Length;
            int y_axis_max = array_of_lines.Length;

            /*Console.WriteLine($"X: {x_axis_max}, Y: {y_axis_max}");*/

            int[] trees = new int[x_axis_max * y_axis_max];

            int index = 0;
            foreach (string line in array_of_lines)
            {
                foreach (char tree in line)
                {
                    trees[index++] = tree - '0';
                }
            }

            /*foreach (int tree in trees)
            {
                Console.WriteLine(tree);

            }*/
            /*int total = 0;
            for (int x = 0; x < x_axis_max; x++)
            {
                for (int y = 0; y < y_axis_max; y++)
                {
                   *//* Console.WriteLine($"X: {x}, Y: {y}, value: {trees[x + (y * y_axis_max)]}");*//*
                    if (y == 0 || y == (y_axis_max - 1) || x == 0 || x == (x_axis_max - 1))
                    {
                        total++;
                        
                    }
                    else // x + y*y_axis_max
                    {
                        bool visible_north = true;
                        bool visible_east = true;
                        bool visible_south = true;
                        bool visible_west = true;

                        for (int x_min = 0; (x_min < x) && visible_west; x_min++) 
                        {
                            if (trees[x_min + (y * y_axis_max)] >= trees[x + (y * y_axis_max)]) 
                            {
                                visible_west = false;
                            }
                        }

                        for (int x_min = (x+1); (x_min < x_axis_max) && visible_east; x_min++)
                        {
                            if (trees[x_min + (y * y_axis_max)] >= trees[x + (y * y_axis_max)])
                            {
                                visible_east = false;
                            }
                        }

                        for (int y_min = 0; (y_min < y) && visible_north; y_min++)
                        {
                            if (trees[x + (y_min * y_axis_max)] >= trees[x + (y * y_axis_max)])
                            {
                                visible_north = false;
                            }
                        }

                        for (int y_min = (y+1); (y_min < y_axis_max) && visible_south; y_min++)
                        {
                            if (trees[x + (y_min * y_axis_max)] >= trees[x + (y * y_axis_max)])
                            {
                                visible_south = false;
                            }
                        }

                        if (visible_east || visible_north || visible_south || visible_west)
                        {
                            total++;
                        }
                    }
                }
            }

            Console.WriteLine(total);*/
            int max_sight = 0;
            for (int x = 0; x < x_axis_max; x++)
            {
                for (int y = 0; y < y_axis_max; y++)
                {
                    int north = 0;
                    int east = 0;
                    int south = 0;
                    int west = 0;

                    bool north_continue = true;
                    bool east_continue = true;
                    bool south_continue = true;
                    bool west_continue = true;


                    if (x != 0) 
                    {
                        for (int x_min = x - 1; x_min >= 0 && west_continue; x_min--)
                        {
                            if (trees[x_min + (y * y_axis_max)] >= trees[x + (y * y_axis_max)]) 
                            {
                                west_continue = false;
                            }
                            west++;
                        }
                    }

                    if (x != x_axis_max-1)
                    {
                        for (int x_min = x + 1; x_min <= x_axis_max-1 && east_continue; x_min++)
                        {
                            if (trees[x_min + (y * y_axis_max)] >= trees[x + (y * y_axis_max)])
                            {
                                east_continue = false;
                            }
                            east++;
                        }
                    }

                    if (y != 0)
                    {
                        for (int y_min = y - 1; y_min >= 0 && south_continue; y_min--)
                        {
                            if (trees[x + (y_min * y_axis_max)] >= trees[x + (y * y_axis_max)])
                            {
                                south_continue = false;
                            }
                            south++;
                        }
                    }

                    if (y != y_axis_max-1)
                    {
                        for (int y_min = y + 1; y_min <= y_axis_max-1 && north_continue; y_min++)
                        {
                            if (trees[x + (y_min * y_axis_max)] >= trees[x + (y * y_axis_max)])
                            {
                                north_continue = false;
                            }
                            north++;

                        }
                    }

                    if (north * east * south * west > max_sight) 
                    { 
                        max_sight = north * east * south * west;
                    }


                }
            }

            Console.WriteLine(max_sight);
        }
    }

   
}

