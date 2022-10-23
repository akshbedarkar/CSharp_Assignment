using System.Runtime.CompilerServices;

namespace EmployeeManager
{
    abstract class Employee
    {
        public abstract void CalculateGrossSalary();
        public abstract void CalculateSalary();
    }

    class Manager : Employee
    {
        private double petrolAllowance;
        private double FoodAllowance;
        private double OtherAllowance;
        private double NetSalary;
        private double salary;
        private double GrossSalary;

        
        public Manager(int salary)
        {
            this.salary = salary;

        }

        public void AllowancesCalculation()
        {
            this.petrolAllowance = (double)this.salary * 0.8;
            this.FoodAllowance = (double)this.salary * 0.13;
            this.OtherAllowance = (double)this.salary * 0.03;
        }

        public override void CalculateGrossSalary()
        {
            AllowancesCalculation();
            this.GrossSalary = (double)this.petrolAllowance + (double)this.FoodAllowance + (double)this.OtherAllowance;
        }

        public override void CalculateSalary()
        {
            this.NetSalary = (double)this.petrolAllowance + (double)this.FoodAllowance + (double)this.OtherAllowance;
        }

        public void printdetails()
        {
            Console.WriteLine($"Details from Manager : \n petrol Allowance: {petrolAllowance} \n Food Allowance {FoodAllowance} \n Other Allowance {OtherAllowance} \n net salary {NetSalary}\n Gross Salary {GrossSalary}\n ");
        }
    }

        class MarketingExecative : Employee
    {
        private int KilometerTravel;
        private int TourAllowance;
        private int TelephoneAllowance;
        private double GrossSalary;
        private double NetSalary;
        private int salary;


        public MarketingExecative(int salary, int KilometerTravel)
        {
            this.salary = salary;
            this.KilometerTravel = KilometerTravel;
        }
        public void AllowancesCalculation()
        {
            this.TourAllowance = 5 * this.KilometerTravel;
            this.TelephoneAllowance = 1000;
        }

        public override void CalculateGrossSalary()
        {
            AllowancesCalculation();
            this.GrossSalary = (double)this.TourAllowance + (double)this.KilometerTravel + (double)this.TelephoneAllowance;
        }

        public override void CalculateSalary()
        {
            this.NetSalary = (double)this.TourAllowance + (double)this.KilometerTravel + (double)this.TelephoneAllowance;
        }

        public void printdetails()
        {
            Console.WriteLine($"Details from MarketingExecative : \n Tour Allowance: {TourAllowance} \n Kilometer Travel {KilometerTravel} \n Telephone Allowance {TelephoneAllowance} \n Net Salary {NetSalary}\n Gross Salary {GrossSalary}\n ");
        }
    }
    class program 
    {


        static void Main(string[] args)
        {
            Console.WriteLine("enter salary");
            int salary = int.Parse(Console.ReadLine());
            Manager m1 = new Manager(salary);
            m1.CalculateGrossSalary();
            m1.CalculateSalary();
            m1.printdetails();





            Console.WriteLine("Enter the distance you have travelled in Km");
            int KilometerTravel = int.Parse(Console.ReadLine());
            MarketingExecative m2 = new MarketingExecative(salary,KilometerTravel); 
            m2.CalculateGrossSalary();
            m2.CalculateSalary();
            m2.printdetails();

            Console.ReadKey();












        }
    }

       
}