using System;

namespace HighestMarks
{
    class Topper
    {
        static void Main()
        {
            Double highestmarks = 0;
            int k = 0;
            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine("Please Student {0}  please enter your average marks", i);
                Double j = Convert.ToDouble(Console.ReadLine());
                if (j > highestmarks)
                {
                    highestmarks = j;
                    k = i;
                }
            }
            Console.WriteLine("The highest marks obtained are {0} of student number {1}", highestmarks, k);
        }
    }
}