using System;

/*The start of the grading program
 */


namespace GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Student john = new Student("John", 9);
            john.setEnglishGrades();
            john.getEnglishGrades();
            

            Console.ReadLine();
        }
    }
}
