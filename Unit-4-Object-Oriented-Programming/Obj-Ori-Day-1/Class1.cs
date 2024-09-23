using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace Obj_Ori_Day_1
{
    // Removed the internal attribute which would limit where we can use this class
    class Student
    {
        // Define data we want to store for a student
        public string studentName;
        public List<double> testScores; // Define and assign a default list for test scores

        // Methods for the class
        //
        // Constructors
        //
        // Do we need a default constructor? (Does the default student make sense?)
        //    No 0 so no 0-arg Constructor needed
        //
        // Do we want to create a student with just a name? (with no test scores?)
        //    Yes - Create a 1-argument constructor that takes a Student Name.
        //
        // Do we want to create a student with just test scores? (no student name)
        //    No - No 1-arg constructor that takes test scores only
        //
        // Do we want to create a student that already has test scores? 
        //    Yes - Create a 2-arg constructor that takes a Student Name and their scores
        //
        //  Create a 1-argument constructor that takes a Student Name.
        public Student(string name)
        {
            studentName = name;
            testScores = new List<double>();
        }

        //Create a 2-arg constructor that takes a Student Name and their scores
        public Student(string name, List<double> scores)
        {
            studentName = name;
            testScores = scores;
        }

        // ---------- Additional methods to support the Class ----------

        // Display the data in an object
        public void ShowStudent()
        {
            Console.WriteLine($"\nName:  {studentName}  Test Scores: "); 
             foreach (double aScore in testScores)
             {
                Console.Write($" {aScore} ");
             }
        }

        // Allow user to add scores to testScores
        public void ScoreAdd(double score)
        {
            testScores.Add(score); // Add the score we are given to testScores
        }





    } // End of Student Class
}
