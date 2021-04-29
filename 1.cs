using System;

namespace Homeowkr2
{
    class Program
    {
        static void Main()
        {
            Pascal();
        }
        static void Pascal()
        {
            int rows;
            int value = 1;
            int blank;
            int i;
            int j;
            Console.Write("Input the Pascal row : ");
            rows = int.Parse(Console.ReadLine());
            if (rows < 0)
            {
                Invalid();
            }

            while (rows >= 0)
            {
                for (i = 0; i <= rows; i++)
                {
                    for (blank = 1; blank <= - i;blank ++)
                        Console.Write(" ");
                    for (j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                            value = 1;
                        else
                            value = value * (i - j + 1) / j;
                        Console.Write(value + " ");
                    }
                    Console.WriteLine();

                }
                
             
            
                break;
                
            }
        }
        static void Invalid()
        {
            Console.WriteLine("Invalid Pascal Triangle");
            Pascal();

        }
    }
}

