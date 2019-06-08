using System;
using System.Collections.Generic;

namespace ex56_poo
{
    public class Problem
    {
        public static void Main()
        {
            // Um array de objetos de diferentes tipos
            object[] stuff = { "ola", 1, 2.3, 5f, 12L, 4UL, 5U, "bye", 4, 9 };
            // Imprimir apenas objetos do tipo inteiro
            foreach (int i in Filter<object, int>(stuff))
            {
                Console.WriteLine("int = " + i);
            }
            // Imprimir apenas objetos do tipo float
            foreach (float f in Filter<object, float>(stuff))
            {
                Console.WriteLine("float = " + f);
            }
        }

        static IEnumerable<Y> Filter<X, Y>(IEnumerable<object> stuff)
        {
            List<Y> returnList = new List<Y>();

            foreach (object o in stuff)
            {
                if (o is Y) returnList.Add((Y)o);
            }
            return returnList;
        }


    }
}
