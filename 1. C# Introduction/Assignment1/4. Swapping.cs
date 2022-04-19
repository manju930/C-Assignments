namespace Swaping
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("First number after swaping is : {0}", num1);
            Console.WriteLine("Second number after swaping is : {0}", num2);
        }
    }
}