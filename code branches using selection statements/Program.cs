using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace code_branches_using_selection_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize variables - graded assignments
            int currentAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            // Students names
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            int[] studentScores = new int[10];

            string currentStudentLetterGrade = "";

            // Display the Report Header
            Console.WriteLine("Student\t\tGrade\n");

            foreach (string name in studentNames)
            {

                string currentStudent = name;

                if (currentStudent == "Sofia")
                    //assign Sophoia's scores to the studentScores array
                    studentScores = sophiaScores;

                else if (currentStudent == "Andrew")
                    //assign Andrew's scores to the studentScores array
                    studentScores =andrewScores;

                else if (currentStudent == "Emma")
                    //assign Emma's scores to the studentScores array
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    //assign Logan's scores to the studentScores array
                    studentScores = loganScores;

                //initialize/reset the sum of scored assignments
                int sumAssignmentScores = 0;

                // initialize/reset calculated avarage of exam + extra credit scores
                decimal currentStudentGrade = 0;

                foreach (int score in studentScores)
                {
                    // add exam score to the sum
                    sumAssignmentScores += score;
                }

                currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

                if (currentStudentGrade <= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade <= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade <= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade <= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade <= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade <= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade <= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade <= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade <= 70)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade <= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade <= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade <= 60)
                    currentStudentLetterGrade = "D-";
                 
                else
                    currentStudentLetterGrade = "F";

                Console.WriteLine($"{name}\t\t{currentStudentLetterGrade}\t?");
            }
            Console.WriteLine("Press the Enter key to contiue");
            Console.ReadLine();
        }
        
       
    }
}
