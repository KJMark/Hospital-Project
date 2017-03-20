using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Nurse : Employees
    {
        private int ex_hr;
        public int Ex_hr
        {
            set
            { ex_hr = value; }
            get
            { return ex_hr; }
        }
        private int num_work_days;
        public int Num_work_days
        {
            set
            { num_work_days = value; }
            get
            { return num_work_days; }
        }
        private int num_work_hrs;
        public int Num_work_hrs
        {
            set
            { num_work_hrs = value; }
            get
            { return num_work_hrs; }
        }
        private string working_sheft;
        public string Working_sheft
        {
            set
            { working_sheft = value; }
            get
            { return working_sheft; }
        }
        private string nurse_department;
        public string Nurse_department
        {
            set
            { nurse_department = value; }
            get
            { return nurse_department; }
        }
        private int ex_hr_sal;
        public int Ex_hr_sal
        {
            set
            { ex_hr_sal = value; }
            get
            { return ex_hr_sal; }
        }                
        public Nurse () { }
        public Nurse(int ID, int age, string name, string address, string gender, double phone, double mobile, int employee_ID, double salary, string working_hours, string working_days, double tax_percentage, int ex_hr, string working_sheft, string nurse_department, int num_work_days, int num_work_hrs, int ex_hr_sal)
            : base(ID, age, name, address, gender, phone, mobile, employee_ID, salary, working_hours, working_days, tax_percentage)
        {
            this.ex_hr = ex_hr;
            this.working_sheft = working_sheft;
            this.nurse_department = nurse_department;
            this.num_work_days = num_work_days;
            this.num_work_hrs = num_work_hrs;
            this.ex_hr_sal = ex_hr_sal;
        }
        public Nurse (int ex_hr,int num_work_days, int num_work_hrs)
        {
            this.ex_hr = ex_hr;
            this.num_work_days = num_work_days;
            this.num_work_hrs = num_work_hrs;
        }
        public Nurse (string working_sheft, string nurse_department)
        {
            this.working_sheft = working_sheft;
            this.nurse_department = nurse_department;
        }
        public double cal_nurse_salary()       // If there is no extra hours the slary will stay as the base salary
        {                                      // else salary will be the base salary + (base salary / (number of working hours in day * number of working days in month)) * 2 * extra hours 
            if (ex_hr == 0)
            {
                return salary;
            }
            else
            {
                return ((ex_hr_sal * ex_hr) + salary);
            }            
        }
        public override double tax()
        {
            return base.tax();
        }
        public override string ToString()             //returning all nurse data
        {
            return base.ToString() + "\n\rWorking department: " + nurse_department + "\n\rWorkiinng sheft: " + working_sheft + "\n\rSalary: " + cal_nurse_salary() + "\n\rTax: " + tax();
        }        
    }
}