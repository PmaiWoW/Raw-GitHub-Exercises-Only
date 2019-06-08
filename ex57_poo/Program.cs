using System;
using System.Collections.Generic;

namespace ex57_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();

            Console.WriteLine("How many times to copy the value?");
            num = int.Parse(Console.ReadLine());

            intList = CopyValToList<int>(10, num);
            foreach(int val in intList) { Console.WriteLine(val); }

            Console.WriteLine("How many times to copy the value?");
            num = int.Parse(Console.ReadLine());

            stringList = CopyValToList<string>("bruh.jpeg", num);
            for(int i = 0; i < num; i++) { Console.WriteLine(stringList[i]); }
        }

        static List<T> CopyValToList<T>(T val, int num)
        {
            List<T> genericList = new List<T>();
            for(int i = 0; i < num; i++)
            {
                genericList.Add(val);
            }
            return genericList;
        }
    }
}
