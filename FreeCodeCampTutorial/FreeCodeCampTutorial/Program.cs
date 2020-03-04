using System;

namespace FreeCodeCampTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRINGS
            /*string phrase = "This world can be so cold!";

            Console.WriteLine("the length of the string is " + phrase.Length);
            Console.WriteLine("all upper case " + phrase.ToUpper() + " Now lower case " + phrase.ToLower());
            Console.WriteLine("phrase contains world " + phrase.Contains("world"));
            Console.WriteLine(phrase.IndexOf("be"));
            Console.WriteLine(phrase.Substring(11, 3));*/

            //NUMBERS

            /*Console.WriteLine("adding a int with a decimal will give a decimal");
            Console.WriteLine("60.5 + 67 = " + (60.5 + 67));
            Console.WriteLine(Math.Abs(-58));
            Console.WriteLine(Math.Pow(3, 2)); // raised to the second power
            Console.WriteLine("which is bigger 90 or 76 " + Math.Max(90,76));*/

            //GETTING USER INPUT
            //console.write() outputs on the same line and doesn't go to next line
            /*Console.WriteLine("Hey User whats your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Oh what is you last name as well? ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"So your full name is {firstName} {lastName}");*/

            //BASIC CALCULATOR

            //int num = Convert.ToInt32("45"); demo purpose to convert into int

            /* Console.WriteLine("Enter a number");
             int num1 = Convert.ToInt32( Console.ReadLine());

             Console.WriteLine("what is your second number");
             int num2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("total sum is " + (num1 + num2));*/

            //ARRAYS

            /*int[] luckyNumbers = { 6, 7, 29, 49 };
            Console.WriteLine(luckyNumbers[2]);
            string[] friends = new string[3];

            foreach(int number in luckyNumbers){
                Console.WriteLine(number);
            }

            Console.WriteLine("tell me 3 friends");
  
            for(int i = 0; i < friends.Length; i++)
            {
                
                friends[i] = Console.ReadLine();
            }

            Console.WriteLine("your friends names are ");
            foreach (string name in friends)
            {
                Console.WriteLine(name);
            }*/


            //METHODS, RETURN STATEMENTS
            /*sayHello("john");

            Console.WriteLine("lets cube any number you want");
            double num = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine(cubeNum(num));


            Console.ReadLine();
        }

        static void sayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static double cubeNum(double num)
        {
            return num * num * num;
        }*/


            //2D ARRAY
            /*int[,] numberGrid =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            //by specifying just the size
            int[,] secondArray = new int [2, 2];

            Console.WriteLine(numberGrid[1,1]);//print the number 5
            int rowLength = secondArray.GetLength(0);
            int colLength = secondArray.GetLength(1);
            Console.WriteLine("row " + rowLength);
            Console.WriteLine("col " + colLength);
            int indexNum = 0;

            for (int i = 0; i < rowLength; i++)
            {
                for(int j = 0; j < colLength; j++)
                {
                    
                    secondArray[i, j] = indexNum;
                    indexNum++;
                    
                }
            }

            foreach(int i in secondArray)
            {
                Console.WriteLine("{0}", i);
            }*/



            //EXCEPTION HANDLING use a try catch block
            //example is with dividing by 0 or entering a string
            /*try
            {
                Console.WriteLine("enter a number ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e) //specific for divide by zero
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e) //Exception is a data type that will be used
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally always run");
            }*/


            //INTRO TO CLASSES AND OBJECTS
            //dogs for example
            Canine dog1 = new Canine();

            dog1.GetDogInfo();
            dog1.DisplayDogInfo();









            Console.ReadLine();

        }
    }
}
