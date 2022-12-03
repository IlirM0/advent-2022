using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_2022
{
    class Day2
    {
        
        public void Run() {
            //string text = System.IO.File.ReadAllText(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day2\input.txt");

            // Display the file contents to the console. Variable text is a string.
            string[] subs = File.ReadAllLines(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day2\input.txt");

            int tempint = 0;

            foreach (string s in subs) {
                string[] temp = s.Split(' ');

                /*switch (temp[1])
                {
                    case "X": //ROCK
                        tempint += 1;
                        break;
                    case "Y": //PAPER
                        tempint += 2;
                        break;
                    case "Z": // SCISSORS
                        tempint += 3;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                //Console.WriteLine($"first one: {tempint}");

                switch (temp[0])
                {
                    case "A": // ROCK
                        switch (temp[1])
                        {
                            case "X": //ROCK
                                tempint += 3;
                                break;
                            case "Y": //PAPER
                                tempint += 6;
                                break;
                            case "Z": // SCISSORS
                                tempint += 0;
                                break;
                        }
                        break;
                    case "B": // PAPER
                        switch (temp[1])
                        {
                            case "X":
                                tempint += 0;
                                break;
                            case "Y":
                                tempint += 3;
                                break;
                            case "Z":
                                tempint += 6;
                                break;
                        }

                        break;
                    case "C": // SCISSORS
                        switch (temp[1])
                        {
                            case "X":
                                tempint += 6;
                                break;
                            case "Y":
                                tempint += 0;
                                break;
                            case "Z":
                                tempint += 3;
                                break;
                        }

                        break;
                }*/
                //Console.WriteLine($"second one: {tempint}");

                switch (temp[1])
                {
                    case "X": //ROCK
                        tempint += 0;
                        break;
                    case "Y": //PAPER
                        tempint += 3;
                        break;
                    case "Z": // SCISSORS
                        tempint += 6;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                //Console.WriteLine($"first one: {tempint}");

                switch (temp[0])
                {
                    case "A": // ROCK
                        switch (temp[1])
                        {
                            case "X": //SCISSORS
                                tempint += 3;
                                break;
                            case "Y": //ROCK
                                tempint += 1;
                                break;
                            case "Z": // PAPER
                                tempint += 2;
                                break;
                        }
                        break;
                    case "B": // PAPER
                        switch (temp[1])
                        {
                            case "X": // ROCK
                                tempint += 1;
                                break;
                            case "Y": // PAPER
                                tempint += 2;
                                break;
                            case "Z": // SCISSORS
                                tempint += 3;
                                break;
                        }

                        break;
                    case "C": // SCISSORS
                        switch (temp[1])
                        {
                            case "X": // PAPER
                                tempint += 2;
                                break;
                            case "Y":
                                tempint += 3;
                                break;
                            case "Z":
                                tempint += 1;
                                break;
                        }

                        break;
                }

            }


            Console.WriteLine(tempint);
        }
    }
}
