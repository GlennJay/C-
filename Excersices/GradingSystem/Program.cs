using System;
using System.Collections.Generic;

/*The start of the grading program
 */


namespace GradingSystem
{
    class Program
    {
        static int numberOfStudents = 3;
        static Student[] students = new Student[numberOfStudents];
        static String[] courses = new string[]{"Science", "Math", "History", "English"};

        static void Main(string[] args)
        {
            //create a student name variable
            String john = "john";
            String mary = "mary";
            String jayson = "Jayson";
            //create a grade level variable
            int nine = 9;
            int ten = 10;
            int eleven = 10;
            //create student
            Student student1 = new Student( john, nine);
            Student student2 = new Student(mary, ten);
            Student student3 = new Student(jayson, eleven);
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
           

            ShowMainMenu();
           
            


            

            Console.ReadLine();
        }
         //display menu 
        public static void ShowMainMenu()
        {
            Console.WriteLine("To create a student enter: 1");
            Console.WriteLine("To enter grades for a student enter: 2");
            int option = Convert.ToInt32(Console.ReadLine());
            
            
            //option to search for a student
            //option to search by class

            switch(option)
            {
                //option to create a student
                case 1:
                    Student student = new Student();
                    Console.WriteLine("What is the name of the student you want to enter?");
                     student.name = Console.ReadLine();

                    Console.WriteLine("What is the grade that {0} is in?", student.name);
                     student.gradeLevel = Convert.ToInt32(Console.ReadLine());
                    students[0] = student;
                    break;
                    //option to enter grades for specific student
                case 2:
                    Console.WriteLine("What is the name of the student you want to enter grades for?");
                    String name = Console.ReadLine();

                    Console.WriteLine("What is the name of the course you want to enter grades for?");
                    String course = Console.ReadLine();

                    Student FoundStudent = FindStudent(name);
                    FindCourse(course,FoundStudent);
                    break;
                 default:
                    Console.WriteLine("Not a valid option");
                    break;
            
            }
        
        }//end of menu

        public static Student FindStudent(string name)
        {
            Student foundStudent = new Student();
            bool found = false;
            while(found == false)
            {
                for(int i = 0; i < students.Length; i++)
                {
                    if(students[i].name == name)
                    {
                        
                        foundStudent = students[i];
                        found = true;
                        
                    }
                }

                if(found == false)
                {
                    Console.WriteLine("Student not found");
                    Console.WriteLine("Enter the correct student name:");
                    name = Console.ReadLine();
                }
            }
            return foundStudent;
            
            
        }

        public static void FindCourse(String course, Student name)
        {
            course = course.ToLower();
            bool foundCourse = false;
            
            while(foundCourse == false)
            {
                switch(course)
                {
                    case "history":
                        name.setHistoryGrades();
                        foundCourse = true;
                        break;

                    case "science":
                        name.setScienceGrades();
                        foundCourse = true;
                        break;

                    case "math":
                        name.setMathGrades();
                        foundCourse = true;
                        break;

                    case "english":
                        name.setEnglishGrades();
                        foundCourse = true;
                        break;

                    default:
                        Console.WriteLine("Course does not exist");
                        Console.WriteLine("Enter the correct course: ");
                        course = Console.ReadLine();
                        break;

                }
                
            }

        }
        

    }//end of class program
}//end of namespace
