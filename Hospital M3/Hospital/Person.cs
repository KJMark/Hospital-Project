using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Person
    {
        private int ID;
        public int id
        {
            set
            { ID = value; }
            get
            { return ID; }
        }
        private int age;
        public int Age
        {
        set
        {age = value; }
        get 
        {return age; }
        }

        private string name;
        public string Name
        {
            set
            { name = value; }
            get
            { return name; }
        }

        private string address;
        public string Address
        {
            set
            { address = value; }
            get
            { return address; }
        }

        private string gender;
        public string Gender
        {
            set
            { gender = value; }
            get
            { return gender; }
        }
        private double phone;
        public double Phone
        {
            set
            { phone = value; }
            get
            { return phone; }
        }

        private double mobile;
        public double Mobile
        {
            set
            { mobile = value; }
            get
            { return mobile; }
        }
                          
        public Person() { }          //defalt constructor
        public Person(int ID, int age, string name, string address, string gender, double phone, double mobile)  
        {
            this.ID = ID;
            this.age = age;
            this.name = name;
            this.address = address;
            this.gender = gender;
            this.phone = phone;
            this.mobile = mobile;
        }
        public Person (int ID)
        {
            this.ID = ID;
        }
        public Person (int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public Person ( string address, string gender )
        {
            this.address = address;
            this.gender = gender;
        }
        public Person (double phone, double mobile)
        {
            this.phone = phone;
            this.mobile = mobile;
        }
        public override string ToString()                           //return person input data
        {
            return "\n\rID: " + ID + "\n\rName: " + name + "\n\rGender: " + gender + "\n\rAge: " + age + "\n\rAddress: " + address + "\n\rPhone: " + phone + "\n\rMobile: " + mobile;
        }
    }
}
