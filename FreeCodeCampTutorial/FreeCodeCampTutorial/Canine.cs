using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCodeCampTutorial
{
    class Canine
    {
        public string dogName;
        public string dogBreed;
        public int dogAge;
        public int dogHeightFeet;
        public int dogHeightInches;
        public int dogWeight;
        private int dogIDNum;

        //Canine constructor
        public Canine(string canineName, string canineBreed, int canineAge, int canineHeightFeet, int canineHeightInches, int canineWeight, int canineIDNum)
        {
            dogName = canineName;
            dogBreed = canineBreed;
            dogAge = canineAge;
            dogHeightFeet = canineHeightFeet;
            dogHeightInches = canineHeightInches;
            dogWeight = canineWeight;
            DogID = canineIDNum;

        }

        public Canine() // constructor to allow user input for Canine
        {

        }

        public void GetDogInfo()
        {
            Console.WriteLine("what is your dogs name?");
            dogName = Console.ReadLine();

            Console.WriteLine("what is the breed of {0}", dogName);
            dogBreed = Console.ReadLine();

            Console.WriteLine("Enter {0}'s age ", dogName);
            dogAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0}'s height in feet ", dogName);
            dogHeightFeet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0}'s height in inches ", dogName);
            dogHeightInches = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0}'s weight in pound whole numbers ", dogName);
            dogWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Also finally what is the ID of {0}", dogName);
            DogID = Convert.ToInt32(Console.ReadLine());
        }


        public void DisplayDogInfo()
        {
            Console.WriteLine("To confirm your dogs information:");
            Console.WriteLine(dogName);
            Console.WriteLine(dogAge);
            Console.WriteLine(dogHeightFeet + "'" + dogHeightInches);
            Console.WriteLine(dogWeight);
            Console.WriteLine(dogIDNum);
        }


        public int DogID //getter and setter
        {
            get { return dogIDNum; }
            set { 
                if(value >= 1 && value <= 100)
                {
                    dogIDNum = value;
                }
                else
                {
                    Console.WriteLine("Invalid ID number for the dog");
                }
            }
        }


    }
}
