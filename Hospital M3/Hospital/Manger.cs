using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Manger : Employees 
    {
        private string manager_of;              // set & get input as string 
        public string Manager_of
        {
            set { manager_of = value; }
            get { return manager_of; }
        }
        public Manger () { }                  //defat construter
        public Manger(int ID, int age, string name, string address, string gender, double phone, double mobile, int employee_ID, double salary, string working_hours, string working_days, double tax_percentage, string manager_of)
            : base(ID, age, name, address, gender, phone, mobile, employee_ID, salary, working_hours, working_days, tax_percentage)
        {
            this.manager_of = manager_of;
        }
        public override double tax()
        {
            return base.tax();
        }
        public override string ToString()             //return manager data
        {
            return base.ToString() + "\n\rManager of " + manager_of + "\n\rSalary: " + salary + "\n\rTax: " + tax()   ;
        }
    }
}
