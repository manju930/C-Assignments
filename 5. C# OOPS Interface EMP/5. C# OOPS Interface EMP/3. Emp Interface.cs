using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class addemployee
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("dinesh");
            list.Add("sam");
            list.Add("gokul");
            list.Add("shankar");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Employees" + ':' + list[i]);
            }
            Console.WriteLine("All Employees" + ':' + list.Count);
            Console.ReadLine();
        }
    }
}