using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* https://www.youtube.com/watch?v=GhQdlIFylQ8 */

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John"; //string variable
            int characterAge = 35; //int variable
            char characterInitial = 'J'; //character variable only one character
            bool isMale = true;

            /* decimal point numbers
             * float least accurate
             * double next accurate
             * decimal most accurate
             */
            double characterWishedAge = 21.0;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old ");
            Console.WriteLine("He really Liked his inital being " + characterInitial);
            Console.WriteLine("But didn't like being " + characterAge);
            Console.WriteLine("He wished he could be " + characterWishedAge);

            Console.ReadLine(); //stops window from exiting
        }
    }
}
