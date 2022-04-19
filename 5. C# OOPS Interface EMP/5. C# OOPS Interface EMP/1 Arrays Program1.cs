//Manju C# Assignment OOPS Arrays
using System;


namespace arraysProgram
{
    public class Program
    {
        public static void Main()
        {
            String[] StringArray1 = { ".NET", "MVC", "REACT", "NODEJS", "ANGULAR" };
            int[] IntArray2 = new int[6];
            String[] StringArray2 = new String[5];
            int[] IntArray1 = { 10, 2, 5, 40, 11, 67 };

            Console.WriteLine("Select operation you want to perform on arrays");
            Console.WriteLine("Press 1 for -> Copying");
            Console.WriteLine("Press 2 for -> Sorting");
            Console.WriteLine("Press 3 for -> Reverse");
            Console.WriteLine("Press 4 for -> Clear");
            int operation =Convert.ToInt32(Console.ReadLine());
            //Takes input value and perform switch operation
            switch(operation)
            {
                case 1:
                    {
                        IntArray1.CopyTo(IntArray2, 0);
                        Console.WriteLine("Copy of first Array :");
                        foreach (var item in IntArray2)
                         {
                             Console.WriteLine(item);
                         }

                        StringArray1.CopyTo(StringArray2, 0);
                        Console.WriteLine("Copy of second Array :");
                        foreach (var item in StringArray2)
                        {
                            Console.WriteLine(item);
                        }

                    }
                    break;
                case 2:
                    {
                        //Sorted arrays
                        Array.Sort(IntArray1);
                        Console.WriteLine("The 1st Sorted Array is :");
                        foreach (var item in IntArray1)
                        {
                            Console.WriteLine(item);
                        }

                        Array.Sort(StringArray1);
                        Console.WriteLine("The 2nd Sorted Array is :");
                        foreach (var item in StringArray1)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break ;
                case 3:
                    {
                        //Reverse the array values
                        Array.Reverse(IntArray1);
                        Array.Reverse(StringArray1);
                        Console.WriteLine("Reversed arrays are");
                        Console.WriteLine("First reversed array");
                        foreach(var item in IntArray1)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Second reversed array");
                        foreach (var item in StringArray1)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case 4:
                    {
                        Array.Clear(IntArray1);
                        Array.Clear(StringArray1); 
                        Console.WriteLine("Original arrays Cleared");
                    }
                    break;

                default:
                break ;
            }
        }
    }
}