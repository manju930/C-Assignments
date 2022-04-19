using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            calc();
        }
		public static void calc(){
			Console.WriteLine("Please Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation you want to performed");
            Console.WriteLine("Press A for Addition");
            Console.WriteLine("Press S for Subtraction");
            Console.WriteLine("Press M for Multiplication");
            Console.WriteLine("Press D for Division \n");
            int operation = Convert.ToChar(Console.ReadLine());

            int res = 0;
            switch (operation)
            {
                case 'A':
                    {
                        res = Addition(num1, num2);
                        break;
                    }
                case 'S':
                    {
                        res = Subtraction(num1, num2);
                        break;
                    }
                case 'M':
                    {
                        res = Multiplication(num1, num2);
                        break;
                    }
                case 'D':
                    {
                        res = Division(num1, num2);
                        break;
                    }
                default:
                    Console.WriteLine("Incorrect input, try again");
                    break;
            }
            Console.WriteLine("The Result {0}", res);
            Console.ReadKey();
		}
        public static int Addition(int num1, int num2)
        {
            int re = num1 + num2;
            return res;
        }
        public static int Subtraction(int num1, int num2)
        {
            int res = num1 - num2;
            return res;
        }
        public static int Multiplication(int num1, int num2)
        {
            int res = num1 * num2;
            return res;
        }
        public static int Division(int num1, int num2)
        {
            int res = num1 / num2;
            return res;
        }
    }
}