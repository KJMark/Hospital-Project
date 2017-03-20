using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Operations
    {
        private string operation_type;
        public string Operation_type
        {
            set
            { operation_type = value; }
            get
            { return operation_type; }
        }
        
        private string operation_doc;
        public string Operation_doc
        {
            set
            { operation_doc = value; }
            get
            { return operation_doc; }
        }
        private double operation_cost;
        public double Operation_cost
        {
            set
            { operation_cost = value; }
            get
            { return operation_cost; }
        }                             
        public Operations() { }                                     
        public Operations(string operation_type, string operation_doc, double operation_cost)
        {
            this.operation_type = operation_type;
            this.operation_doc = operation_doc;
            this.operation_cost = operation_cost;
        }
        public Operations (string operation_type, string operation_doc)
        {
            this.operation_type = operation_type;
            this.operation_doc = operation_doc;
        }
         public Operations (double operation_cost)
        {
            this.operation_cost = operation_cost;
        }
    }
}
