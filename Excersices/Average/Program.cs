using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int average;
            int num;
            int[] numbers;
            int sum = 0;
            Console.WriteLine("How many numbers do you want to average?");
            num = Convert.ToInt32(Console.ReadLine());
            numbers = new int[num];

            Console.WriteLine("Please enter {0} numbers to average", num);

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            average = sum / num;

            Console.WriteLine("The average of ");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("is {0}", average);
            

        }
    }
}
