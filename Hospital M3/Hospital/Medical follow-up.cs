using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medical_follow_up
    {
        private string followup_doc;
        public string Followup_doc
        {
            set
            { followup_doc = value; }
            get
            { return followup_doc; }
        }
        private string followup_result;
        public string Followup_result
        {
            set
            { followup_result = value; }
            get
            { return followup_result; }
        }
        private double followup_cost;
        public double Followup_cost
        {
            set
            { followup_cost = value; }
            get
            { return followup_cost; }
        }                      
                                                  
        public Medical_follow_up() {  }                                     
        public Medical_follow_up(string followup_doc, string followup_result, double followup_cost)
        {
            this.followup_doc = followup_doc;
            this.followup_result = followup_result;
            this.followup_cost = followup_cost;
        }
        public Medical_follow_up(string followup_doc, string followup_result)
        {
            this.followup_doc = followup_doc;
            this.followup_result = followup_result;
        }
        public Medical_follow_up (double followup_cost)
        {
            this.followup_cost = followup_cost;
        }
    }
}
