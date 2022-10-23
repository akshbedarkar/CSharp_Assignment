using System;
using System.Collections;
using System.Xml.Linq;


namespace ArrayListEmployee
{
    public class Employee
    {
        private double Eno;
        private string EmpName;
        private double salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        //constant  value
        const long firstsalaryslap = 5000;
        const long secondsalaryslap = 10000;
        const double thirdsalaryslap = 15000;
        const double fourthsalaryslap = 20000;

        //method to calculate gross salary
        public void grosssalary()
        {
            this.GrossSalary = this.salary + this.HRA + this.TA + this.DA;
            calculatesalary();
        }

        //method to calculate salary
        public void calculatesalary()
        {
            this.PF = (this.GrossSalary * 0.1);
            this.TDS = (this.GrossSalary * 0.18); ;
            this.NetSalary = (this.GrossSalary - (this.PF + this.TDS));
        }


        public override string ToString()
        {
            return "Employee Name " + EmpName + "\n" + "Employee id " + Eno + "\n " + "Employee Sakary " + salary + "\n " + "HRA " + HRA + "\n " + "TA" + TA + "\n " + "DA" + DA + "\n " + "PF" + PF + "\n " + "TDS" + TDS + "\n " + "Net Salary" + NetSalary + "\n " + "Gross Salary" + GrossSalary + "\n ";
        }


        public void calculation()
        {
            if (salary <= 0)
            {
                throw new Exception("ZeroOrNegativeSalaryExceptioin");
            }
            else
            {
                if (salary < firstsalaryslap)
                {
                    this.HRA = (salary * 0.1);
                    this.TA = (salary * 0.05);
                    this.DA = (salary * 0.15);
                    grosssalary();
                }
                else if (salary < secondsalaryslap)
                {
                    this.HRA = (salary * 0.15);
                    this.TA = (salary * 0.1);
                    this.DA = (salary * 0.20);
                    grosssalary();
                }
                else if (salary < thirdsalaryslap)
                {
                    this.HRA = (salary * 0.20);
                    this.TA = (salary * 0.15);
                    this.DA = (salary * 0.25);
                    grosssalary();
                }
                else if (salary < fourthsalaryslap)
                {
                    this.HRA = (salary * 0.25);
                    this.TA = (salary * 0.20);
                    this.DA = (salary * 0.30);
                    grosssalary();
                }
                else
                {
                    this.HRA = (salary * 0.30);
                    this.TA = (salary * 0.25);
                    this.DA = (salary * 0.35);
                    grosssalary();
                }
            }
        }


        public Employee(double eno, String ename, double salary)
        {


            this.Eno = eno;
            this.EmpName = ename;
            this.salary = salary;

            calculation();

        }


        static void Main(string[] args)
        {
            Employee[] empArray = new Employee[200];

            empArray[0] = new Employee(101,"akshata",20000);
            empArray[1] = new Employee(201,"AKSHATA",10000);

            for(int i=0;i<empArray.Length;i++)
            {
                Console.WriteLine(empArray[i]);
                Console.ReadKey();
            }
           

            


        }

    }
}