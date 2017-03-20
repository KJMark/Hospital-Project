using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medicines
    {
        private string medicines_list;
        public string Medicines_list
        {
            set
            { medicines_list = value; }
            get
            { return medicines_list; }
        }
        private double medicines_cost;
        public double Medicines_cost
        {
            set
            { medicines_cost = value; }
            get
            { return medicines_cost; }
        }
                            
        public Medicines() { }                          //defalt constructer
        public Medicines(string medicines_list, double medicines_cost)
        {
            this.medicines_list = medicines_list; 
            this.medicines_cost = medicines_cost;
        }
        public Medicines(string medicines_list)
        {
            this.medicines_list = medicines_list;
        }
        public Medicines(double medicines_cost)
        {
            this.medicines_cost = medicines_cost; 
        }
    }
}
