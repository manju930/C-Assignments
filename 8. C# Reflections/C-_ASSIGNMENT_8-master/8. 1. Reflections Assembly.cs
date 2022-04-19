using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CustomSoftwareAttribute
{

    class Program
    {
        static void Main(string[] args)
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine("Types : " + item.Name);
                MethodInfo[] mi = item.GetMethods();
                foreach (var method in mi)
                {
                    Console.WriteLine("Methods : " + method.Name);                    
                    //Invoking Methods
                    Types typeMethod = Type.GetTypes(item);
                    ConstructorInfo conMethod =  typeMethod.GetConstructor(Type.EmptyTypes);
                    object objMethod  = conMethod.Invoke(new object[]{});
                }   

                
            }
            Console.ReadLine();
        }
    }
}
