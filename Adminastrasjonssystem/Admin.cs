using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adminastrasjonssystem
{
    internal class Admin
    {
        List<Student> _students = new List<Student>
        {
            new Student("Thomas", 32, "Religionshistorie", 777),
            new Student("Linn", 32, "Sosialantropologi", 111),
            new Student("Mitas", 11, "Katteramp", 1337),
        };

        List<Course> _courses = new List<Course>
        {
            new Course(69, "Anvendt Teiptygging", 15),
            new Course(352, "Amnesty Internship", 30),
            new Course(246, "Fønikisk Mytologi", 10),
            new Course(412, "Abrahamittisk Verdenshistorie", 15),
            new Course(420, "Avansert Hårballproduksjon", 20),
        };

        List<Grade> _grades;

        public Admin()
        {
            _grades = new List<Grade>
            {
                new Grade(_students[0], _courses[2], 4 ),
                new Grade(_students[0], _courses[3], 5 ),
                new Grade(_students[1], _courses[1], 6 ),
                new Grade(_students[1], _courses[3], 3 ),
                new Grade(_students[2], _courses[0], 6 ),
                new Grade(_students[2], _courses[4], 6 ),
            };
        }

        public void RunSysAdmin()
        {
            printHeader();
            Console.WriteLine("Velkommen til studentadministrasjonssystemet");
            Console.WriteLine("Meny:");
            Console.WriteLine("1. Studenter");
            Console.WriteLine("2. Fag");
            Console.WriteLine("3. Karakterer");
            int input = Convert.ToInt32(Console.ReadLine());
            RunMenu(input);
        }

        public void RunMenu(int input)
        {
            Console.Clear();
            printHeader();
            switch (input)
            {
                case 1:
                    PrintStudents();
                    break;
                case 2:
                    PrintCourses();
                    break;
                case 3:
                    PrintGrades();
                    break;
                default:
                    Console.WriteLine("Velg et gyldig tall");
                    Console.ReadKey(true);
                    Console.Clear();
                    RunSysAdmin();
                    break;

            }
        }

        public void PrintStudents()
        {

            foreach (var student in _students)
            {
                student.PrintInfo(_grades);
            }
           
        } public void PrintCourses()
        {
            foreach (var course in _courses)
            {
                course.PrintInfo();
            }
          

        } public void PrintGrades()
        {
            foreach (var grade in _grades)
            {
                grade.PrintInfo();
            }

        }

        public void printHeader()
        {
            Console.WriteLine(@"    ___       __          _      _____               _____ ____  ____  ____ 
   /   | ____/ /___ ___  (_)___ / ___/__  _______   |__  // __ \/ __ \/ __ \
  / /| |/ __  / __ `__ \/ / __ \\__ \/ / / / ___/    /_ </ / / / / / / / / /
 / ___ / /_/ / / / / / / / / / /__/ / /_/ (__  )   ___/ / /_/ / /_/ / /_/ / 
/_/  |_\__,_/_/ /_/ /_/_/_/ /_/____/\__, /____/   /____/\____/\____/\____/  
                                   /____/");
        }

    }
}
