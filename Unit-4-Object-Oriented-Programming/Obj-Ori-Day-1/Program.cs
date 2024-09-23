using System;
using System.Collections.Generic;


namespace Obj_Ori_Day_1
{
    // This is an application that uses and manipulates objects of a class
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a Student with a name and no test scores
            Student student1 = new Student("Dog");

            // Define a Student with some test scores
            List<double> theScores = new List<double>();
            theScores.Add(100);
            theScores.Add(50);

            Student student2 = new Student("Fish", theScores);

            // Add test scores for the student
            //
            // We need to use a method provided by the class

            student1.ScoreAdd(75);
            student1.ScoreAdd(50);
            student1.ScoreAdd(95);
            student1.ScoreAdd(68);

            student2.ScoreAdd(30);
            


            // Display the data associated with each Student using a method provided by the class
            //         because the Class owns the data and knows how to display it
            //         so we don't have to do any work as the user of the Class to display

            student1.ShowStudent(); // Use the object of the class to run a method of the class
            student2.ShowStudent(); 


        }
    }
}
