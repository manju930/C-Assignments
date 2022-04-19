using System;
using System.Collections;


namespace UsingCollections
{
    public static void Main()
    {
        Employee emp1 = new Employee();
        Employee emp2 = new Employee();
        Employee emp3 = new Employee();
        Employee emp4 = new Employee();

        ArrayList al = new ArrayList();          
        al.Add(emp1);
        al.Add(emp2);
        al.Add(emp3);
        al.Add(emp4);
        
        emp1.EmployeeDetails(101, "Manju", 50000);
        emp2.EmployeeDetails(102, "Anju", 650000);
        emp3.EmployeeDetails(103, "Krishna", 80500);
        emp4.EmployeeDetails(104, "Anand", 90000);
        Console.WriteLine("there are {0} objects in arraylist",al.Count);
        

        foreach (var item in al)
        {
            Console.WriteLine();
        }

    }
    public class Collections
    {
        public class Employee
        {
            private int EmpNo;
            private string EmpName;
            private double Salary;

            public void EmployeeDetails(int empNo, string empName, double salary)
            {
                this.EmpNo = empNo;
                this.EmpName = empName;
                this.Salary = salary;
                Console.WriteLine("Employee Number : {0} ", empNo);
                Console.WriteLine("Employee Name : {0} ", empName);
                Console.WriteLine("Employee Salary : {0} ", salary);

            }
        }

    }
}