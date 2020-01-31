using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    /*
     * https://www.youtube.com/watch?v=GhQdlIFylQ8
     */
    class Program
    {
        static void Main(string[] args)
        {
            /*String Characteristics:
                It is a reference type.
                It’s immutable( its state cannot be altered).
                It can contain nulls.
                It overloads the operator(==).
             */

            string phrase = "I still haven't seen the new Star Wars movie";
            Console.WriteLine(phrase.Length);

            Console.ReadLine();




        }
    }
}
