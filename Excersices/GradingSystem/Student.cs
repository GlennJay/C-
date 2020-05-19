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

        //student GPA
        public float studentGpa;

        //Math grades
        public int[] mathGrades;

        //Science grades
        public int[] scienceGrades;

        //English grades
        public int[] englishGrades;

        //History grades
        public int[] historyGrades;


        //Student Constructor
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
            Console.WriteLine("The current grades for {0} are as follows:", name);

            foreach(int grade in mathGrades)
            {
                Console.WriteLine(grade);
            }
        }

        //set Science grades
        public void setScienceGrades()
        {
            int numberOfGrades;

            Console.WriteLine("How many scores do you need to enter {0}", name);
            numberOfGrades = Convert.ToInt32(Console.ReadLine());

            mathGrades = new int[numberOfGrades];

            Console.WriteLine("Please enter the Math grades for {0}", name);

            for (int i = 0; i < scienceGrades.Length; i++)
            {
                scienceGrades[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //get science grades
        public void getScienceGrades()
        {
            Console.WriteLine("The current grades for {0} are as follows:", name);

            foreach (int grade in scienceGrades)
            {
                Console.WriteLine(grade);
            }
        }

        //set english grades
        public void setEnglishGrades()
        {
            int numberOfGrades;

            Console.WriteLine("How many scores do you need to enter {0}", name);
            numberOfGrades = Convert.ToInt32(Console.ReadLine());

            englishGrades = new int[numberOfGrades];

            Console.WriteLine("Please enter the Math grades for {0}", name);

            for (int i = 0; i < englishGrades.Length; i++)
            {
                englishGrades[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //get english grades
        public void getEnglishGrades()
        {
            Console.WriteLine("The current grades for {0} are as follows:", name);

            foreach (int grade in englishGrades)
            {
                Console.WriteLine(grade);
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
            Console.WriteLine("The current grades for {0} are as follows:", name);

            foreach (int grade in historyGrades)
            {
                Console.WriteLine(grade);
            }
        }



    }
}
