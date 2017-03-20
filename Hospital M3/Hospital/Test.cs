using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Test
    {
        private string ray_type;
        public string Ray_type
        {
            set
            { ray_type = value; }
            get
            { return ray_type; }
        }
        private string analyses_type;
        public string Analyses_type
        {
            set
            { analyses_type = value; }
            get
            { return analyses_type; }
        }
        private double ray_cost;
        public double Ray_cost
        {
            set
            { ray_cost = value; }
            get
            { return ray_cost; }
        }   
        private double analyses_cost;
        public double Analyses_cost
        {
            set
            { analyses_cost = value; }
            get
            { return analyses_cost; }
        }   
        public Test() { }                                          //defalt constrcter
        public Test(string ray_type, string analyses_type, double ray_cost, double analyses_cost)
        {
            this.ray_type = ray_type;
            this.analyses_type = analyses_type;
            this.ray_cost = ray_cost;
            this.analyses_cost = analyses_cost;
        }
    }
}
