using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_2022
{
    
    class Day7
    {
        
        public void Run()
        { 
            //string text = System.IO.File.ReadAllText(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day2\input.txt");

            // Display the file contents to the console. Variable text is a string.
            string[] array_of_lines = File.ReadAllLines(@"C:\Users\Ilir\source\repos\advent-2022\advent-2022\resourses\day7\input.txt");

            AllFileAoC root = new DirAoC("/", null);

            AllFileAoC curr = root;

            foreach (string line in array_of_lines) 
            { 
                string[] cmd = line.Split(' ');
                if(cmd[0] == "$") // cmd
                {
                    if (cmd[1] == "cd") 
                    {
                        switch (cmd[2])
                        {
                            case "/": // go back to first dir
                                curr = curr.getRoot();
                                break;
                            case "..": // 
                                curr = curr.getParent();
                                break;
                            default: // enter a dir
                                curr = curr.searchDir(cmd[2]);
                                break;
                        }
                    }
                }
                else // info line
                {
                    if (cmd[0] == "dir") // add a dir
                    {
                        AllFileAoC newChild = new DirAoC(cmd[1], curr);
                        curr.addChild(newChild);
                    }
                    else // add a file
                    {
                        AllFileAoC newChild = new FileAoc(Int32.Parse(cmd[0]), cmd[1], curr);
                        curr.addChild(newChild);
                    }
                }
            }

            /*Console.WriteLine(70000000 - root.getSize());*/
            root.allSize();
            root.printFinalSum(70000000 - root.getSize());
        }
    }

    public abstract class AllFileAoC 
    {
        protected string Name;
        protected AllFileAoC Parent;
        protected int Size;
        /*protected int totalSizeForAoc;*/

        public abstract int getSize();
        public virtual void setName(string _name) { 
            Name = _name;
        }
        public virtual string getName() 
        { 
            return Name;
        }

        public virtual AllFileAoC getParent() 
        { 
            return Parent;
        }

        public virtual AllFileAoC getRoot() 
        {
            if (this.Name == "/")
            {
                return this;
            }
            else 
            { 
                return Parent.getRoot();
            }
        }

        public virtual AllFileAoC searchDir(string _name) 
        {
            return null;
        }

        public virtual void addChild(string _child) { }

        public virtual void addChild(AllFileAoC _child) { }

        /*public virtual void printAllSizesDirs()
        {}*/
        public virtual int allSize()
        {
            return 0;
        }

        public virtual void printFinalSum(int init) { }
    }

    public class DirAoC : AllFileAoC {
        /*private AllFileAoC[] Children;*/
        private List<AllFileAoC> Children;
        static List<int> FinalSum;

        public override int getSize() 
        {
            if (Size == 0)
            {
                int size = 0;
                foreach (AllFileAoC child in Children)
                {
                    size += child.getSize();
                }
                Size = size;
            }
            return Size;
        }

        public override void addChild(string _child) 
        {
            if (searchDir(_child) == null)
            {
                AllFileAoC newChild = new DirAoC(_child, this);
                Children.Add(newChild);
            }
            else 
            {
                Console.WriteLine("Child is existinger");
            }
            
        }

        public override void addChild(AllFileAoC _child)
        {
            Children.Add(_child);
        }

        public override AllFileAoC searchDir(string _name) 
        {
            foreach (AllFileAoC child in Children)
            {
                if (child.getName() == _name) 
                { 
                    return child;
                }
            }
            return null;
        }

        public DirAoC(string _name, AllFileAoC _parent) 
        {
            Parent = _parent;
            Name = _name;
            Children = new List<AllFileAoC>();
            Size = 0;
            FinalSum = new List<int>();
            /*totalSizeForAoc = 0;*/
        }

        /*public override void printAllSizesDirs() 
        {
            int size = 0;
            foreach (AllFileAoC child in Children)
            {
                size += child.getSize();
            }
            *//*if (this is DirAoC)
            {*//*
                Console.WriteLine($"{Name}: {size}");
            *//*}*//*
            
        }*/

        public override int allSize() 
        {
            foreach (AllFileAoC child in Children) 
            {
                child.allSize();
            }
            /*if () 
            {*/
                FinalSum.Add(getSize());
             /*   Console.WriteLine($"Dir: {Name}, size: {getSize()}");
            }*/
            return 0;
        }

        public override void printFinalSum(int init) 
        {
            FinalSum.Sort();
            foreach (int num in FinalSum) 
            {
                if ((num + init) >= 30000000) 
                {
                    Console.WriteLine($"Final Sum: {num}");
                }
            }
            /*Console.WriteLine($"Final Sum: {FinalSum.Sum()}");*/
        }

    }

    public class FileAoc : AllFileAoC
    {
        /*private int Size;*/

        public FileAoc(int _size, string _name, AllFileAoC _parent)
        {
            Size = _size;
            Name = _name;
            Parent = _parent;
        }

        public override int getSize()
        {
            return Size;
        }

        /*public override void printAllDirSize()
        {
            *//*Console.WriteLine($"Dir: {Name}");*//*
        }*/
    }
}

