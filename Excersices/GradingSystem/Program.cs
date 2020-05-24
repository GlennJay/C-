using System;

/*The start of the grading program
 */


namespace GradingSystem
{
    class Program
    {
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





            Console.ReadLine();
        }
    }
}
