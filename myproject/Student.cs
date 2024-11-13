using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    //WAP to create a class Student, accept the rollno, name & 3 subjects marks from constructor,
    //create a method to calculate total marks & percentage. Print the details of students.

    public class Student
    {
        private int rollno, s1, s2, s3, total;
        private double percentage;
        private string sname;


        public Student(int rollno, string sname, int s1, int s2, int s3)
        {
            this.rollno = rollno;
            this.sname = sname;
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;     
        }

        public void findpercentage()
        {
            total = s1 + s2 + s3;
            percentage = total / 3;
        }

        public string display()
        {
            return $"roll no= {rollno}/ Name={sname} /total marks={total} / percentage={percentage} %";
        }
    }
}
