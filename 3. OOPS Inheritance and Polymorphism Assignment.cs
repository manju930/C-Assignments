using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeManagementSystem
{
    interface IPrintable
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Enter number of employees");
            num = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
            MarketingExecutive marketingExecutive = new MarketingExecutive();
            for (i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Name of Employee");
                emp.setName(Convert.ToString(Console.ReadLine()));
                Console.WriteLine("Enter Salary of Employee");
                emp.setSalary(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Enter PF");
                emp.setPF(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Kilometers travelled");
                marketingExecutive.setKilometersTravel(Convert.ToDouble(Console.ReadLine()));
            }
            double GrossSalary = 0.8 * emp.getSalary() + 0.13 * emp.getSalary() + 0.3 * emp.getSalary();
            double CalculateSalary = GrossSalary + emp.getPF();
            Manager mngr = new Manager();
            mngr.GrossSalary(GrossSalary);
            mngr.CalculateSalary(CalculateSalary);
            marketingExecutive.setTelephoneAllowances(1000);
            marketingExecutive.setTourAllowances(5);
            double GrossSalary1 = marketingExecutive.getTelephoneAllowances() + (marketingExecutive.getKilometersTravel() * marketingExecutive.getTourAllowances());
            double CalculateSalary1 = GrossSalary1 + emp.getPF();

            marketingExecutive.GrossSalary(GrossSalary1);
            marketingExecutive.CalculateSalary(CalculateSalary1);
        }
    }
    public class Employee
    {
        private string? Name;
        private double Salary;
        private double PF;

        public void setName(string? Name)
        {
            this.Name = Name;
        }

        public void setSalary(double Salary)
        {
            this.Salary = Salary;
        }
        public string? getName()
        {
            return Name;
        }
        public double getSalary()
        {
            return Salary;
        }
        public void setPF(double NewPF)
        {
            PF = NewPF;
        }
        public double getPF()
        {
            return PF;
        }
    }
    class Manager
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double Other;
        public void setPetrolAllowance(double PetrolAllowance)
        {
            this.PetrolAllowance = PetrolAllowance;
        }

        public void setFoodAllowance(double FoodAllowance)
        {
            this.FoodAllowance = FoodAllowance;
        }
        public double getPetrolAllowance()
        {
            return PetrolAllowance;
        }
        public double getFoodAllowance()
        {
            return FoodAllowance;
        }
        public void setOther(double Other)
        {
            this.Other = Other;
        }
        public double getOther()
        {
            return Other;
        }
        public void GrossSalary(double GrossSalary)
        {
            Console.WriteLine("GROSS SALARY :");
            Console.WriteLine(GrossSalary);
        }
        public void CalculateSalary(double CalculateSalary)
        {
            Console.WriteLine("NET SALARY :");
            Console.WriteLine(CalculateSalary);
        }
    }
    public class MarketingExecutive
    {
        private double KilometersTravel;
        private double TourAllowances;
        private double TelephoneAllowances;
        public void setKilometersTravel(double KilometersTravel)
        {
            this.KilometersTravel = KilometersTravel;
        }
        public void setTourAllowances(double TourAllowances)
        {
            this.TourAllowances = TourAllowances;
        }
        public double getKilometersTravel()
        {
            return KilometersTravel;
        }
        public double getTourAllowances()
        {
            return TourAllowances;
        }
        public void setTelephoneAllowances(double TelephoneAllowances)
        {
            this.TelephoneAllowances = TelephoneAllowances;
        }
        public double getTelephoneAllowances()
        {
            return TelephoneAllowances;
        }
        public void GrossSalary(double GrossSalary1)
        {
            Console.WriteLine("Gross Salary :");
            Console.WriteLine(GrossSalary1);
        }
        public void CalculateSalary(double CalculateSalary1)
        {
            Console.WriteLine("Net Salary");
            Console.WriteLine(CalculateSalary1);
        }
    }
}