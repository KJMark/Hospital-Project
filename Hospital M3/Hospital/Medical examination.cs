using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medical_examination
    {
        private string examination_doc;
        public string Examination_doc
        {
            set { examination_doc = value; }
            get { return examination_doc; }
        }

        private string examination_type;
        public string Examination_type
        {
            set
            { examination_type = value; }
            get
            { return examination_type; }
        }
        private string examination_result;
        public string Examination_result
        {
            set
            { examination_result = value; }
            get
            { return examination_result; }
        }
        private double examination_cost;
        public double Examination_cost
        {
            set
            { examination_cost = value; }
            get
            { return examination_cost; }
        }
                                                 
        public Medical_examination() { }                                   
        public Medical_examination(string examination_doc, string examination_type, string examination_result, double examination_cost)
        {
            this.examination_doc = examination_doc; 
            this.examination_type = examination_type;
            this.examination_result = examination_result;
            this.examination_cost = examination_cost;
        }
    }
}
