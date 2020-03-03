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

            Console.WriteLine("adding a int with a decimal will give a decimal");
            Console.WriteLine("60.5 + 67 = " + (60.5 + 67));
            Console.WriteLine(Math.Abs(-58));
            Console.WriteLine(Math.Pow(3, 2));

            //left off at 58:26

            Console.ReadLine();
        }
    }
}
