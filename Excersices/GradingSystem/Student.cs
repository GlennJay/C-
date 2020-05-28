using System;
using System.Collections.Generic;
using System.Text;

namespace GradingSystem
{
    class Student
    {
        //student name
        public string name;

        //student grade level
        public int gradeLevel;

        //student classes
        public String[] attendedClasses;

        

        //student grade average
        public int gradeAverage;

        //Math grades
        public int[] mathGrades;
        //student letter grade
        public string mathGrade;

        //Science grades
        public int[] scienceGrades;
        public string scienceGrade;

        //English grades
        public int[] englishGrades;
        public string englishGrade;

        //History grades
        public int[] historyGrades;
        public string historyGrade;


        //Student Constructor
        public Student()
        {
            name = "empty";
            gradeLevel = 0;
        }
        public Student(String studentName , int studentGradeLevel)
        {
            name = studentName;
            gradeLevel = studentGradeLevel;
        }

        //set Math Grades
        public void setMathGrades()
        {
            int numberOfGrades;

            Console.WriteLine("How many scores do you need to enter {0}", name);
            numberOfGrades = Convert.ToInt32(Console.ReadLine());

            mathGrades = new int[numberOfGrades];

            Console.WriteLine("Please enter the Math grades for {0}", name);

            for(int i = 0; i < mathGrades.Length; i++)
            {
                mathGrades[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //get Math grades
        public void getMathGrades()
        {
            
            if(mathGrades != null)
            {
                foreach (int grade in mathGrades)
                {
                    Console.WriteLine("The current grades for {0} are as follows:", name);
                    Console.WriteLine(grade);
                }
            }
            else
            {
                Console.WriteLine("Sorry this student does not have any grades entered");
            }
            
        }

        //set Science grades
        public void setScienceGrades()
        {
            int numberOfGrades;

            Console.WriteLine("How many scores do you need to enter {0}", name);
            numberOfGrades = Convert.ToInt32(Console.ReadLine());

            scienceGrades = new int[numberOfGrades];

            Console.WriteLine("Please enter the Math grades for {0}", name);

            for (int i = 0; i < scienceGrades.Length; i++)
            {
                scienceGrades[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //get science grades
        public void getScienceGrades()
        {
            if(scienceGrades != null)
            {
                Console.WriteLine("The current grades for {0} are as follows:", name);
                foreach (int grade in scienceGrades)
                {
                    Console.WriteLine(grade);
                }
            }
            else
            {
                Console.WriteLine("Sorry this student does not have any grades entered");
            }
            
        }

        //set english grades
        public void setEnglishGrades()
        {
            int numberOfGrades;

            Console.WriteLine("How many scores do you need to enter {0}", name);
            numberOfGrades = Convert.ToInt32(Console.ReadLine());

            englishGrades = new int[numberOfGrades];

            Console.WriteLine("Please enter the English grades for {0}", name);

            for (int i = 0; i < englishGrades.Length; i++)
            {
                englishGrades[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //get english grades
        public void getEnglishGrades()
        {
            if(englishGrades != null)
            {
                Console.WriteLine("The current grades for {0} are as follows:", name);
                foreach (int grade in englishGrades)
                {
                    Console.WriteLine(grade);
                }
            }
            else
            {
                Console.WriteLine("Sorry this student does not have any grades entered");
            }
            
        }


        //set history grades
        public void setHistoryGrades()
        {
            int numberOfGrades;

            Console.WriteLine("How many scores do you need to enter {0}", name);
            numberOfGrades = Convert.ToInt32(Console.ReadLine());

            historyGrades = new int[numberOfGrades];

            Console.WriteLine("Please enter the Math grades for {0}", name);

            for (int i = 0; i < historyGrades.Length; i++)
            {
                historyGrades[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //get history grades
        public void getHistoryGrades()
        {
            if(historyGrades != null)
            {
                Console.WriteLine("The current grades for {0} are as follows:", name);
                foreach (int grade in historyGrades)
                {
                    Console.WriteLine(grade);
                }
            }
            else
            {
                Console.WriteLine("Sorry this student does not have any grades entered");
            }
            
        }

        //Calculate letter grade
        public void CalculateGrade(String course)
        {
            //string course;
            int sumOfGrades = 0;
            

            //ask for which class to calculate
            //Console.WriteLine("Which course would you like to get the final grade for: {0} {1} {2} {3} ", "history", "math", "science", "english");
            //course = Console.ReadLine();

            //calculate grade
            if(course == "history")
            {
                foreach(int grade in historyGrades)
                {
                    sumOfGrades = sumOfGrades + grade;
                }
                gradeAverage = sumOfGrades / historyGrades.Length;
                historyGrade = getLetterGrade();

            }
            else if (course == "math")
            {
                foreach (int grade in mathGrades)
                {
                    sumOfGrades = sumOfGrades + grade;
                }
                gradeAverage = sumOfGrades / mathGrades.Length;
                mathGrade = getLetterGrade();
            }
            else if (course == "science")
            {
                foreach (int grade in scienceGrades)
                {
                    sumOfGrades = sumOfGrades + grade;
                }
                gradeAverage = sumOfGrades / scienceGrades.Length;
                scienceGrade = getLetterGrade();
            }
            else if (course == "english")
            {
                foreach (int grade in englishGrades)
                {
                    sumOfGrades = sumOfGrades + grade;
                }
                gradeAverage = sumOfGrades / englishGrades.Length;
                englishGrade = getLetterGrade();
            }
            else
            {
                Console.WriteLine("Please enter a valid selection");
            }
            
        }

        //set alphabetical grade
        public string getLetterGrade()
        {
            string studentGrade = "";

            if(gradeAverage >= 90)
            {
                studentGrade = "A";
            }else if (gradeAverage >= 80 && gradeAverage <= 89)
            {
                studentGrade = "B";
            }else if (gradeAverage >= 70 && gradeAverage <= 79)
            {
                studentGrade = "C";
            }else if (gradeAverage >= 60 && gradeAverage <= 69)
            {
                studentGrade = "D";
            }else if (gradeAverage <= 59)
            {
                studentGrade = "F";
            }
            return studentGrade;
        }

        //Display student grades for all classes and final grade for each
        public void FinalReport()
        {
            Console.WriteLine("Report Card for {0}", name);
            Console.Write("Final grade for English is " + englishGrade);
            getEnglishGrades();

        }

       


    }
}
