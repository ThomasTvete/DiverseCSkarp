using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adminastrasjonssystem
{
    internal class Course
    {
        private int _id;
        internal string _name;
        internal int _credits;

        public Course(int id, string name, int credits)
        {
            _id = id;
            _name = name;
            _credits = credits;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{_name} har ID {_id} og gir {_credits} studiepoeng");
        }
    }
}
