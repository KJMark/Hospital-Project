using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Doctors : Employees
    {
        private string doc_specialization;
        public string Doc_specialization
        {
            set
            { doc_specialization = value; }
            get
            { return doc_specialization; }
        }

        private double operation_num;
        public double Operation_num
        {
            set
            { operation_num = value; }
            get
            { return operation_num; }
        }

        private double operation_fees;
        public double Operation_fees
        {
            set
            { operation_fees = value; }
            get
            { return operation_fees; }
        }

        private double new_patieent_fees;
        public double New_patieent_fees
        {
            set
            { new_patieent_fees = value; }
            get
            { return new_patieent_fees; }
        }

        private double followup_patient_fees;
        public double Followup_patient_fees
        {
            set
            { followup_patient_fees = value; }
            get
            { return followup_patient_fees; }
        }
        private double op_fees_doc_percentage;
        public double Op_fees_doc_percentage
        {
            set
            { op_fees_doc_percentage = value; }
            get
            { return op_fees_doc_percentage; }
        }

        public Doctors () { }            //defalt constructer
        public Doctors (int ID, int age, string name, string address, string gender, double phone, double mobile, int employee_ID, double salary, string working_hours, string working_days, double tax_percentage, string doc_specialization,
        double operation_num, double operation_fees, double new_patieent_fees, double followup_patient_fees, double op_fees_doc_percentage)
            : base(ID, age, name, address, gender, phone, mobile, employee_ID, salary, working_hours, working_days, tax_percentage)
        {
            this.doc_specialization = doc_specialization;
            this.operation_num = operation_num;
            this.operation_fees = operation_fees;
            this.new_patieent_fees = new_patieent_fees;
            this.followup_patient_fees = followup_patient_fees;
            this.op_fees_doc_percentage = op_fees_doc_percentage;
        }
        public Doctors (string doc_specialization)
        {
            this.doc_specialization = doc_specialization;
        }
        public Doctors (double operation_num, double operation_fees, double new_patieent_fees, double followup_patient_fees)
        {
            this.operation_num = operation_num;
            this.operation_fees = operation_fees;
            this.new_patieent_fees = new_patieent_fees;
            this.followup_patient_fees = followup_patient_fees;
        }

        public override double tax()
        {
            return base.tax();
        }
        public double sal()
        {
            return (operation_fees * op_fees_doc_percentage * 0.01 * operation_num) + salary;                       //calculate & return salary (operation fees * 0.75 for the doctor & the .25 for the hospital) + the base salary
        }
        public override string ToString()                   //returning doctors data
        {
            return base.ToString() + "\n\rSpecialization: " + doc_specialization + "\n\rNew pattinet fees: " + new_patieent_fees + "\n\rFollowing up patient fees: " + followup_patient_fees + "\n\rSalary: " + sal() + "\n\rTax: " + tax();
        }        
    }
}
