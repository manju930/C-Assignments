using System;
internal class Employee
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Employee number");
        int ENum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name of the Employee");
        string EName = Console.ReadLine();
        Console.WriteLine("Enter Salary of {0} ", EName);
        int ESal = Convert.ToInt32(Console.ReadLine());
        Employee employee = new Employee();
        employee.SetEmpNo(ENum);
        employee.SetEmpName(EName);
        employee.SetSalary(ESal);
        Console.WriteLine("Employee Number : " + employee.GetEmpNo());
        Console.WriteLine("Employee Name : " + employee.GetEmpName());
        Console.WriteLine("Employee Salary : " + employee.GetSalary());
        Console.WriteLine("Salary (Gross) : " + employee.calculateGrossSalary(ESal));
        Console.ReadKey();

    }

    private int EmpNo;
    private string EmpName;
    private double Salary;
    private double HRA;
    private double TA;
    private double DA;
    private double PF;
    private double TDS;
    private double NetSalary;
    private double GrossSalary;



    public void SetEmpNo(int value)
    {
        this.EmpNo = value;
    }

    public string GetEmpName()
    {
        return EmpName;
    }
    public int GetEmpNo()
    {
        return EmpNo;
    }
    public void SetEmpName(string value)
    {
        this.EmpName = value;
    }
    public double GetSalary()
    {
        return Salary;
    }
    public void SetSalary(double value)
    {
        this.Salary = value;
    }
    public double GetHra()
    {
        return HRA;
    }
    void SetHra(double value)
    {
        this.HRA = calculateHra(Salary);
    }
    public double GetTa()
    {
        return TA;
    }
    void SetTa(double value)
    {
        this.TA = calculateTa(Salary);
    }
    public double GetDa()
    {
        return DA;
    }
    void SetDa(double value)
    {
        this.DA = calculateDa(Salary);
    }
    public double GetGrossSalary()
    {
        return GrossSalary;
    }
    void SetGrossSalary(double value)
    {
        this.GrossSalary =calculateGrossSalary(Salary); 
    }
    public double GetPf()
    {
        return PF;
    }
    void SetPf(double value)
    {
        this.PF = value;
    }
    public double GetTds()
    {
        return TDS;
    }
    void SetTds(double value)
    {
        this.TDS = value;
    }
    public double GetNetSalary()
    {
        return NetSalary;
    }
    void SetNetSalary(double value)
    {
        this.NetSalary = value;
    }

    void calculateSalary(Employee employeedetails)
    {
        double hra = calculateHra(employeedetails.GetSalary());
        double ta = calculateTa(employeedetails.GetSalary());
        double da = calculateDa(employeedetails.GetSalary());

        double grossSalary = employeedetails.GetSalary() + hra + ta + da;
        double pf = .1 * grossSalary;
        double tds = 0.18 * grossSalary;
        double netSalary = grossSalary - (pf + tds);

        employeedetails.SetHra(hra);
        employeedetails.SetTa(ta);
        employeedetails.SetDa(da);
        employeedetails.SetGrossSalary(grossSalary);
        employeedetails.SetPf(pf);
        employeedetails.SetTds(tds);
        employeedetails.SetNetSalary(netSalary);


    }

    double calculateHra(double Salary)
    {
        if (Salary < 5000)
        {
            return .1 * Salary;
        }
        else if (Salary < 10000)
        {
            return .15 * Salary;
        }
        else if (Salary < 15000)
        {
            return .20 * Salary;
        }
        else if (Salary < 15000)
        {
            return .25 * Salary;
        }
        else
        {
            return .30 * Salary;
        }
    }
    double calculateTa(double Salary)
    {
        if (Salary < 5000)
        {
            return .05 * Salary;
        }
        else if (Salary < 10000)
        {
            return .1 * Salary;
        }
        else if (Salary < 15000)
        {
            return .15 * Salary;
        }
        else if (Salary < 15000)
        {
            return .20 * Salary;
        }
        else
        {
            return .25 * Salary;
        }
    }
    double calculateDa(double Salary)
    {
        if (Salary < 5000)
        {
            return .15 * Salary;
        }
        else if (Salary < 10000)
        {
            return .20 * Salary;
        }
        else if (Salary < 15000)
        {
            return .25 * Salary;
        }
        else if (Salary < 15000)
        {
            return .30 * Salary;
        }
        else
        {
            return .35 * Salary;
        }
    }
    double calculateGrossSalary(double Salary)
    {
        double DA = calculateDa(Salary);
        double TA = calculateTa(Salary);
        double HRA = calculateHra(Salary);
        double grossSal = Salary + DA + TA + HRA;   
        return grossSal;

    }
   
}
