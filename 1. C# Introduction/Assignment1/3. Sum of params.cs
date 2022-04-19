
namespace SumUsingParam
{
    public class MyClass
    {

        public static void UseParams(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {

                sum += list[i];
            }
            Console.WriteLine("Sum off all numbers is {0}", sum);
        }
        static void Main()
        {
            UseParams(5, 8, 4, 2, 655, 5);
        }
    }
}