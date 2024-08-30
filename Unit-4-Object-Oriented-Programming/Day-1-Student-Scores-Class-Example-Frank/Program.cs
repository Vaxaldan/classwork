using System;
using System.Collections.Generic;

namespace Day_1_Student_Scores_Class_Example
{

    // This is an application that uses and manipulates objects of a class

    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a Student with a name and no test scores
            Student student1 = new Student("Dog");

            // Define a Student with some test scores
            // Define a List of test scores to send to the constructor
            List<double> theScores = new List<double>();
            theScores.Add(100);
            theScores.Add(50);

            Student student2 = new Student("Fish", theScores);

            // Add test scores to for student
            //
            // We need to use a method provided by the class to do so

            student1.ScoreAdd(75);
            student1.ScoreAdd(85);
            student1.ScoreAdd(95);
            student1.ScoreAdd(35);

            student2.ScoreAdd(80);

            // Display the data associated with each Student using a method provided by the Class
            //         because the Class owns the data and knows how to display we
            //         so we don't to do any work as the user of the class to display

            Console.WriteLine("Student1 is: " + student1);  // DOES NOT display the content of the object
                                                            // it displays:  namespace.classname

            student1.ShowStudent();  // Use the object of the class to run a method of the class
            student2.ShowStudent();  // Use the object of the class to run a method of the class



            Console.WriteLine("\n]\nPress enter to end");
            Console.ReadLine();
        }
    }
}
