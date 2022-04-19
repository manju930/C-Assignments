//C# Assignments
//Manjunath
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8CustomSoftwareAttribute
{

    public class AttirbuteTest
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to HDFC Bank, please enter Account Number");
            HDFCAccount hdfc = new HDFCAccount(2536211255,"Arjun Pandey");
            hdfc.DisplayHDFCAccountDetails();
            Console.WriteLine("Welcome to ICICI Bank, please enter Account Number");
            Console.ReadKey();
            ICICIAccount icici = new ICICIAccount(111122548454, "Sania Mirza");
            icici.DisplayICICIAccountDetails();

            SoftwareAttribute customAttribute = new SoftwareAttribute("HREXEC", "Leave and abasence Issue", "Wipro", "08/02/1992", "15/01/2000");

        }
    }

    [AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]

    public class SoftwareAttribute : System.Attribute
    {
        private String projectName;
        private String description;
        private String clientName;
        private String startedDate;
        private String endDate;

        
        public SoftwareAttribute(String Pn,String Dn,String Cn,String Sd,String Ed)
        {
            this.projectName = Pn;
            this.description = Dn;
            this.clientName = Cn;
            this.startedDate = Sd;
            this.endDate = Ed;
        }
        
        public String ProjectName
        {
            get { return this.projectName; }
        }
        public String Description
        {
            get { return this.description; }    
        }
        public String ClientName
        {
            get { return this.clientName; }
        }
        public String StartedDate
        {
            get { return this.startedDate; }
        }
        public String EndingDate
        {
            get { return this.endDate; }
        }

    }
    [SoftwareAttribute("Hotel Management", "Hotel @ Ananthapur", "v6 solana", "10/7/2013" ,"08/7/2016")]
    [SoftwareAttribute("Industry management", "about Industries", "v5 solns", "21/6/2018", "30/03/2022")]
    class HDFCAccount
    {
        //member variables
        protected int acNumber;
        protected String customerName;
        public HDFCAccount(int acNumber, String customerName)
        {
            this.acNumber = acNumber;
            this.customerName = customerName;
        }
        [SoftwareAttribute("Hotel Management", "Hotel @ Ananthapur", "v6 solana", "10/7/2013" ,"08/7/2016")]

        public int AcNumber
        {
            get
            {
                return this.acNumber;
            }
             
        }
        public String CustomerName
        {
            get { return this.customerName; }
        }

        public void DisplayHDFCAccountDetails()
        {
            Console.WriteLine("HDFC Account number : " + acNumber);
            Console.WriteLine("HDFC Customer Name : " + customerName);
            Console.ReadKey();
        }
        
    }
    [SoftwareAttribute("Hotel Management", "Hotel @ Ananthapur", "v6 solana", "10/7/2013" ,"08/7/2016")]
    [SoftwareAttribute("Industry management", "about Industries", "v5 solns", "21/6/2018", "30/03/2022")]
    public class ICICIAccount
    {
        public int iciciAcNumber;
        public String iciciCustomerName;

        public ICICIAccount(int iciciAcNumber,String iciciCustomerName)
        {
            this.iciciAcNumber = iciciAcNumber; 
            this.iciciCustomerName = iciciCustomerName; 
        }
        [SoftwareAttribute("Industry management", "about Industries", "v5 solns", "21/6/2018", "30/03/2022")]

        public int IciciAcNumber
        {
            get { return this.iciciAcNumber; }
        }
        public String  IciciCustomerName
        {
            get { return this.iciciCustomerName; }
        }
        public void DisplayICICIAccountDetails()
        {
            Console.WriteLine("ICICI Account Number :  " + iciciAcNumber);
            Console.WriteLine("ICICI Customer Name : " + iciciCustomerName);
        }

    }

  
}


    
