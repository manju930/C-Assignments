namespace Circle
{
    public static class Program
    {
		Double pi = 3.14;
        static void Main()
        {
            Console.WriteLine("Enter the radius of circle :");
            Double r = Convert.ToDouble(Console.ReadLine());
            
            CalculateArea(r);
        }
        public static void CalculateArea(double r)
        {
            double Area = pi * r * r;
            Console.WriteLine("The area is {0} : " , Area);
            double Circumference = 2 * pi * r;
            Console.WriteLine("The Circumference is {0} : ", Circumference);
        }
    }
}