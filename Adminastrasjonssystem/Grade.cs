using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adminastrasjonssystem
{
    internal class Grade
    {
        public Student Student { get; private set; }
        public Course Course { get; private set; }
        public int GradeVal { get; private set; }

        public Grade(Student student, Course course, int gradeVal)
        {
            Student = student;
            Course = course;
            GradeVal = gradeVal;
        }

        public void PrintInfo()
        {
           Console.WriteLine($"{Student._name} har karakter {GradeVal} i {Course._name}");
        }
    }
}
