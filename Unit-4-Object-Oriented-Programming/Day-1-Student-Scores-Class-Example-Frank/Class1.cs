using System;
using System.Collections.Generic;
using System.IO;

namespace Day_1_Student_Scores_Class_Example
{
    // We removed the internal attribute which would limit where we can use this class
     class Student
    {
        // Define data we want to store for a student
        public string       studentName;
        public List<double> testScores;

        // Methods for the class
        //
        // Constructors
        //
        // Do we need a default constructor? Does a default student makes sense?
        //    No - so no 0-arg Constructor needed
        //
        // Do we want to create a student with just a name (with no test scores)? 
        //    Yes - Create a 1-arg constructor that takes a Student Name?
        //
        // Do we want to create a student with just a just test scores (no name)? 
        //    No - No 1-arg constructor that takes test scores only
        // 
        // Do we want to create a student that already has test scores? 
        //    Yes - Create a 2-arg constructor that takes a Student Name and their scores?
        //

        // Create a 1-arg constructor that takes a Student Name
        public Student(string name)
        {
            studentName = name;
            testScores  = new List<double>(); // Define and assign a default List for testScores
        }

        // Create a 2-arg constructor that takes a Student Name and their scores
        public Student(string name, List<double> scores)
        {
            studentName = name;
            testScores  = scores;
        }

        // Additional methods to support the class

        // Allow user to add a score to testScores
        public void ScoreAdd(double score)
        {
            testScores.Add(score); // Add the score we are give to testScores
        }


        // Display the data in an object
        public void ShowStudent()
        {
            // Notice use of foreach for the List to get it in a displayable format
            Console.Write($"\nName: {studentName}  Test Scores: ");
            foreach(double aScore in testScores)
            {
                Console.Write($"{aScore}  ");
            }
   
        }



    } // End of Student Class
}
