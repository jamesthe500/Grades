using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook() // constructor, custom. Default (doesn't take parameters)
        {
            grades = new List<float>(); // This is brought from below. new instance of List with every instance of GradeBook.
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades; //  = new List<float>(); // must initialize a new instance of List, insure it points to an obj.
    }
}
