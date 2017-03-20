using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Check_out
    {
        Medical_examination medical_examination;
        public Medical_examination medical_Examination
        { set { medical_examination = value; } get { return medical_examination; } }

        Medicines medicines;
        public Medicines MEDICINES
        { set { medicines = value; } get { return medicines; } }

        Test test;
        public Test TEST
        { set { test = value; } get { return test; } }

        Operations operations;
        public Operations OPERATIONS
        { set { operations = value; } get { return operations; } }

        Medical_follow_up medical_follow_up;
        public Medical_follow_up Medical_Follow_Up
        { set { medical_follow_up = value; } get { return medical_follow_up; } }

        public Check_out() {  }               //defult construter
        
        public Check_out(Medical_examination medical_examination, Medicines medicines, Test test, Operations operations, Medical_follow_up medical_follow_up)
        {
            this.medical_examination = medical_examination;
            this.medicines = medicines;
            this.test = test;
            this.operations = operations;
            this.medical_follow_up = medical_follow_up;
        }

        public double calBell()             //calculating bell by multipling all costs 
        {
            return medical_examination.Examination_cost + test.Ray_cost + test.Analyses_cost + medicines.Medicines_cost + medical_follow_up.Followup_cost + operations.Operation_cost;             
        }
        public override string ToString()               //returning all bell data
        {
            return "\n\r\n\rExamination type: " + medical_examination.Examination_type + "\n\rExamination Doctor: " + medical_examination.Examination_doc + "\n\rExamination result: " + medical_examination.Examination_result + "\n\rExamination cost: " + medical_examination.Examination_cost + "\n\r\n\rRay type: " + test.Ray_type + "\n\rRay cost: " + test.Ray_cost + "\n\r\n\rAnalyzes type: " + test.Analyses_type + "\n\rAnalyzes cost: " + test.Analyses_cost + "\n\r\n\rMedicines list: " + medicines.Medicines_list + "\n\rMedicines cost: " + medicines.Medicines_cost + "\n\r\n\rFollowing up doctor: " + medical_follow_up.Followup_doc + "\n\rFollowinnng up result: " + medical_follow_up.Followup_result + "\n\rFollowing up cost: " + medical_follow_up.Followup_cost + "\n\r\n\rOperation type: " + operations.Operation_type + "\n\rOperation doctor: " + operations.Operation_doc + "\n\rOperation cost: " + operations.Operation_cost + "\n\r\n\rCheck out:\n\rTotal cost: " + calBell();
        }
    }
}