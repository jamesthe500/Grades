﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook() // constructor, custom. Default (doesn't take parameters)
        {
            grades = new List<float>(); // This is brought from below. new instance of List FIELD with every instance of GradeBook.
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade); // Slick way to avoid writing an if
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name; // public classes start with a cap, private = lower case. 

        private List<float> grades; //  = new List<float>(); // must initialize a new instance of List, insure it points to an obj.
    }
}
