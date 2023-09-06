using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    public class Student
    {
        public double CollegeFees { get; set; }
        public char Gender { get; set; }
        public int Marks { get; set; }
        public bool SportsQuota { get; set; }
        public string StudentName { get; set; }

        public Student()
        {
            StudentName =null;
            SportsQuota = false;
            Marks = 0;
            Gender = 'M';
            CollegeFees = 0;

        }

        public Student(string studentName, int marks, char gender, bool sportsQuota)
        {
            StudentName = studentName;
            Marks = marks;
            Gender = gender;
            SportsQuota = sportsQuota;
            CollegeFees = 0; 
        }
    }
    public delegate void StudentDelegate(Student sObj);
}
