using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* https://www.youtube.com/watch?v=GhQdlIFylQ8 */

namespace Basics
{
    //example class for later
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce(){
            Console.WriteLine("Hello my name is " + firstName + " " + lastName);
        }

    }

    public enum ShippingMethod //good practice to set values when declaring
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    
    }



    class Program
    {
        static void Main(string[] args)
        {


            //SECTION basic

            /* string characterName = "John"; //string variable
            int characterAge = 35; //int variable
            char characterInitial = 'J'; //character variable only one character
            bool isMale = true; */

            /* decimal point numbers
             * float least accurate
             * double next accurate
             * decimal most accurate
             */
            /* double characterWishedAge = 21.0;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old ");
            Console.WriteLine("He really Liked his inital being " + characterInitial);
            Console.WriteLine("But didn't like being " + characterAge);
            Console.WriteLine("He wished he could be " + characterWishedAge); */

            //SECTION enums
            //int conversion
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //casting to a number
            Console.WriteLine(method); //shows the string since console.writline is by default casting to string
           

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);//casting the key which enum inside shipping method

            //string conversion
            Console.WriteLine(method.ToString());

            //convet string to enum
            var methodName = "Express";

            //parse string
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.ReadLine(); //stops window from exiting
        }
    }
}
