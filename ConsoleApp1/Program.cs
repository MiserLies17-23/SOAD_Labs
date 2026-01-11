using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = 
            { 
                { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
            };

            Console.Write("{");
            for (int i = 0; i <= mas.GetUpperBound(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j <= mas.GetUpperBound(1); j++)
                {
                    Console.Write("{");
                    for (int k = 0; k <= mas.GetUpperBound(2); k++)
                    {
                        Console.Write(mas[i, j, k]);
                        if (k <  mas.GetUpperBound(2))
                            Console.Write(" , ");
                    }
                    Console.Write("}");
                    if (j <  mas.GetUpperBound(1))
                        Console.Write(" , ");
                }
                Console.Write("}");
                if (i <  mas.GetUpperBound(0)) 
                    Console.Write(" , ");
            }
            Console.Write("}");
        }
    }
}
