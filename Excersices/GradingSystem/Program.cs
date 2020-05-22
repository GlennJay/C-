using System;

/*The start of the grading program
 */


namespace GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //create student
            Student john = new Student("John", 9);
            Student mary = new Student("mary", 9);
            

            john.setEnglishGrades();
            john.getEnglishGrades();
            john.CalculateGrade();


            Console.ReadLine();
        }
    }
}
