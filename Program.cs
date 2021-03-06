﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
           
          

          
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! I'm going to speak your grades.");

            GradeBook book = new GradeBook(); //constructor, new kw is invoking a new instance of GradeBook
            book.AddGrade(91);
            book.AddGrade(89.5f); //The f instructs to make this a float.
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.HighestGrade); // SNIPPET - cw (tab tab) 
            Console.WriteLine(stats.AverageGrade);

        }
    }

}
