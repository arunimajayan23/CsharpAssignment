using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    public  class College
    {
        
        static int counter=1001;
        public int CollegeId { get; set; }
        public string CollegeName { get; set; }

        public College()
        {
            CollegeId = counter;
            counter++;
        
        }
        public College(string collegeName)
        {
            CollegeName = collegeName;
            CollegeId = counter;
            counter++;
        }   
    }
    
}
