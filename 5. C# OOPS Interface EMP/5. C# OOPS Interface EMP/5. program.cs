using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Search
    {
        static void Main()
        {

            //Adding list and values
            List<string> list = new List<string>();
            list.Add("Krishna Mohan");
            list.Add("Ramprasad");
            list.Add("Seenu");
            list.Add("Bharath");



            //Looping through list values and printing employees Name

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees" + ':' + list[i]);
            }


            Console.WriteLine("total number of employess" + ':' + list.Count);
            Console.WriteLine("enter person name:");
            string X = Console.ReadLine();
            if (list.Contains(X))
            {
                Console.WriteLine("yes " + X + " is an employee");
            }
            else
            {
                Console.WriteLine("no");
            }



            Console.ReadLine();
        }
    }
}