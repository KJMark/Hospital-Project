using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class patient : Person
    {
        private double patient_code;
        public double Patient_code
        {
            set
            { patient_code = value; }
            get
            { return patient_code; }
        }
        private string patient_entry_date;
        public string Patient_entry_date
        {
            set
            { patient_entry_date = value; }
            get
            { return patient_entry_date; }
        }
        private string blood_type;
        public string Blood_type
        {
            set
            { blood_type = value; }
            get
            { return blood_type; }
        }
        private string suffering_from;
        public string Suffering_from
        {
            set
            { suffering_from = value; }
            get
            { return suffering_from; }
        }
        private string patient_email;
        public string Patient_email
        {
            set
            { patient_email = value; }
            get
            { return patient_email; }
        }
                                   
        public patient() { }                       
        public patient(int ID, int age, string name, string address, string gender, double phone, double mobile, double patient_code, string patient_entry_date, string blood_type, string suffering_from)
            : base(ID, age, name, address, gender, phone, mobile)
        {
            this.patient_code = patient_code;
            this.patient_entry_date = patient_entry_date;
            this.suffering_from = suffering_from;
            this.blood_type = blood_type;
        }
        public patient (double patient_code)
        {
            this.patient_code = patient_code;
        }
        public patient (string patient_entry_date, string blood_type, string suffering_from)
        {
            this.patient_entry_date = patient_entry_date;
            this.suffering_from = suffering_from;
            this.blood_type = blood_type;
        }
        public patient(string patient_email)            
        {
            this.patient_email = patient_email;
        }
        public override string ToString()                     //return patent data
        {
            return base.ToString() + "\n\rEntry code: " + patient_code + "\n\rEntry date: " + patient_entry_date + "\n\rBlood type: " + blood_type + "\n\rSuffering from: " + suffering_from;
        }
    }
}
