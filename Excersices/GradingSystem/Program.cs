using System;
using System.Collections.Generic;

/*The start of the grading program
 */


namespace GradingSystem
{
    class Program
    {
        int numberOfStudents = 10;
        Student[] students = new Student[numberOfStudents];
        String[] courses = new string[]{"Science", "Math", "History", "English"};

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
                    var student = new Student();
                    Console.WriteLine("What is the name of the student you want to enter?");
                     student.name = Console.ReadLine();

                    Console.WriteLine("What is the grade that {0} is in?", name);
                     student.gradeLevel = Console.ReadLine();
                    students.Add(student);
                    break;
                    //option to enter grades for specific student
                case 2:
                    Console.WriteLine("What is the name of the student you want to enter grades for?");
                    String name = Console.ReadLine();

                    Console.WriteLine("What is the name of the course you want to enter grades for?");
                    String course = Console.ReadLine();

                    Student FoundStudent = FindStudent(name);
                    FindCourse(course,name);
                    break;
                case default:
                    Console.WriteLine("Not a valid option");
                    break;
            
            }
        
        }//end of menu

        public static Student FindStudent(string name)
        {
            bool found = false;
            while(found == false)
            {
                for(int i = 0; i < students.Length; i++)
                {
                    if(students[i] == name)
                    {
                        found = true;
                        return  students[i];
                        
                    }
                }

                if(found == false)
                {
                    Console.WriteLine("Student not found");
                    Console.WriteLine("Enter the correct student name:");
                    name = Console.ReadLine();
                }
            }
            
            
        }

        public static String FindCourse(String course, Student name)
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

                    case "history":
                        name.setHistoryGrades();
                        foundCourse = true;
                        break;

                    default:
                        Console.WriteLine("Course does not exist");
                        break;

                }
                Console.WriteLine("Enter the correct course: ");
                course = Console.ReadLine();
            }

        }
        

    }//end of class program
}//end of namespace
