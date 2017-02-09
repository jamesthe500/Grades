using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook(); //constructor, new kw is invoking a new instance of GradeBook
            book.AddGrade(91);
            book.AddGrade(89.5f); //The f instructs to make this a float.
        }
    }

}
