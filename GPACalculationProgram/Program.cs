using System;

namespace GPACalculationProgram
{
    class Program
    {
        public struct CoursesDetails
        {
            public string grade;
            public string name;
            public int credits;
            public double gpa;
        }
        static void Main(string[] args)
        {
            int totalCreditHours = 0;
            double totalPoints = 0,gpa=0;
            Console.WriteLine("  ***ABASYN UNIVERSITY ISLAMABAD CAMPUS***\n\n");
            Console.WriteLine("***GPA Calculation Program by Sohaib Javed***\n\n");

            Console.Write("Please Enter Number of Courses :");
            byte courses = byte.Parse(Console.ReadLine());
            
            CoursesDetails[] student = new CoursesDetails[courses];
            Console.WriteLine("\nEnter your details\n");
            for (int i = 0; i < courses; i++)
            {
                Console.Write("{0}: Enter Course Name :",(i+1));
                student[i].name = Console.ReadLine();
                Console.Write("Enter Credit hours of {0} :",student[i].name);
                student[i].credits = int.Parse(Console.ReadLine());
                Console.Write("Enter Grade of {0} :",student[i].name);
                student[i].grade = Console.ReadLine();
                totalCreditHours += student[i].credits;
                switch (student[i].grade)
                {
                    case "a":
                    case "A":
                        student[i].gpa = 4.0 * student[i].credits;
                        break;
                    case "a-":
                    case "A-":
                        student[i].gpa = 3.67 * student[i].credits;
                        break;
                    case "b+":
                    case "B+":
                        student[i].gpa = 3.33 * student[i].credits;
                        break;
                    case "b":
                    case "B":
                        student[i].gpa = 3.00 * student[i].credits;
                        break;
                    case "b-":
                    case "B-":
                        student[i].gpa = 2.67 * student[i].credits;
                        break;
                    case "c+":
                    case "C+":
                        student[i].gpa = 2.33 * student[i].credits;
                        break;
                    case "c":
                    case "C":
                        student[i].gpa = 2.00 * student[i].credits;
                        break;
                    case "c-":
                    case "C-":
                        student[i].gpa = 1.37 * student[i].credits;
                        break;
                    case "d+":
                    case "D+":
                        student[i].gpa = 1.33 * student[i].credits;
                        break;
                    case "d":
                    case "D":
                        student[i].gpa = 1.00 * student[i].credits;
                        break;
                    case "f":
                    case "F":
                        student[i].gpa = 0.00 * student[i].credits;
                        break;
                    case "i":
                    case "I":
                        student[i].gpa = 0.00 * student[i].credits;
                        break;
                    default:
                        break;
                }
                totalPoints += student[i].gpa;
                Console.WriteLine("\n");
            }
            gpa = totalPoints / totalCreditHours;
            Console.WriteLine("\n\nYour GPA is {0}",gpa);

        }
    }
}
