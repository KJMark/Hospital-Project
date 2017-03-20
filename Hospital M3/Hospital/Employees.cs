using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Employees : Person
    {
        private int employee_ID;
        public int Employee_ID
        {
            set
            { employee_ID = value; }
            get
            { return employee_ID; }
        }

        protected double salary;
        public double Salary
        {
            set
            { salary = value; }
            get
            { return salary; }   
        }

        private string working_hours;
        public string Working_hours
        {
            set
            { working_hours = value; }
            get
            { return working_hours; }
        }

        private string working_days;
        public string  Working_days
        {
            set
            { working_days = value; }
            get
            { return working_days ; }
        }
        private double tax_percentage;
        public double Tax_percentage
        {
            set
            { tax_percentage = value; }
            get
            { return tax_percentage; }
        }

        public Employees () {}                                   //defat structer
        public Employees(int ID, int age, string name, string address, string gender, double phone, double mobile, int employee_ID, double salary, string working_hours, string working_days, double tax_percentage)
            : base(ID ,age, name, address, gender, phone, mobile)
        {
            this.employee_ID = employee_ID;
            this.salary = salary;
            this.working_days = working_days;
            this.working_hours = working_hours;
            this.tax_percentage = tax_percentage;
        }
        public Employees (int employee_ID)
        {
            this.employee_ID = employee_ID ;
        }
        public Employees (double salary,string working_hours )
        {
            this.salary = salary;
            this.working_hours= working_hours;
        }
        public Employees (string working_days )
        {
            this.working_days=working_days;
        }
        public virtual double tax()
        {
            return salary * tax_percentage * 0.01;
        }
        public override string ToString()                        //return all employee input data
        {
            return base.ToString() + "\n\rEmployee ID: " + employee_ID + "\n\rEmployee base salary: " + salary + "\n\rWorking days: " + working_days + "\n\rWorking hours: " + working_hours;
        }        
    }
}
