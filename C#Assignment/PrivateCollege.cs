using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{

    
    public class PrivateCollege : College

    {
        public int donation;
        public Address privateCollegeAddress;

        public int Donation
        {
            get { return donation; }
            set { donation = value; }
        }

        public Address PrivateCollegeAddress
        {
            get { return privateCollegeAddress; }
            set { privateCollegeAddress = value; }

        }

        public PrivateCollege()
        {
            Donation = 0;
            PrivateCollegeAddress = null;
        
        }

        public PrivateCollege(string collegeName,int donation,Address privateCollegeAddress): base(collegeName) 
        {
            Donation = donation;
            PrivateCollegeAddress= privateCollegeAddress;
        }

        public void CalculateFees(Student studentObj)
        {
            if (studentObj.Marks > 75 && Donation > 100000)
            {
                studentObj.CollegeFees = 75000 - (Donation * 0.5);
            }
            else
            {
                studentObj.CollegeFees = 75000;
            }
        }

    }
}
