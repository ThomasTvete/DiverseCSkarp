namespace Adminastrasjonssystem
{
    internal class Student
    {
        internal string _name;
        private int _age;
        private string _studies;
        private int _id;

        public Student(string name, int age, string studies, int id)
        {
            _name = name;
            _age = age;
            _studies = studies;
            _id = id;
        }



        public void PrintInfo(List<Grade> grades)
        {
            double sumGrade = 0;
            int gradeCount = 0;
            int sumCredits = 0;
            Console.WriteLine($"Student {_name} (studentID {_id}) er {_age} år gammel og går på {_studies}, hvor de tar følgende fag:");
            foreach (var grade in grades)
            {
                if (grade.Student._name == _name)
                {
                    Console.WriteLine($"{grade.Course._name} med karakter {grade.GradeVal}");
                    sumGrade += grade.GradeVal;
                    gradeCount++;
                    sumCredits += grade.Course._credits;

                }
            }

            double gradeAvg = getAvg(sumGrade, gradeCount);
            Console.WriteLine($"Deres karaktersnitt er {gradeAvg} og de har {sumCredits} studiepoeng");
        }

        private double getAvg(double sumGrade, int gradeCount)
        {
            return sumGrade / gradeCount;
        }

        


    }
}
