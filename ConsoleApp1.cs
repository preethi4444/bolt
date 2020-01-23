using System;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// this method  finds given <paramref name="n"/>  is prime or not
        /// </summary>
        /// <remarks>
        /// this method finds prime or not for only integers</remarks>
        /// <param name="n">integer</param>
        /// <exception cref="System.Exception">
        /// when n is max value</exception>
        /// <returns>
        /// prime or not</returns>
        /// <value>
        /// returns the bool value of prime</value>
        public static bool Prime(int n)
        {
            //initialise cnt variable
            bool cnt = false;
            //iterate in the loop to check it is prime
            for (int i = 2; i <= (n / 2); i++)
            {
                if (n % i == 0)
                {
                    cnt = true;
                }
            }
            //return the result
            return cnt;

        }
        static void Main(string[] args)
        {
        
            int n;
            String s;
            Console.WriteLine("enter a number");
            //read the string
            s = Console.ReadLine();
            //convert it to the integer
            n = Convert.ToInt32(s);
            //store the return value in cnt1
            bool cnt1= Prime(n);            
            if (cnt1 == false)
            {
                //prints the result to the console
                Console.WriteLine("it is prime");
            }
            else
            {
                //prints the result to console
                Console.WriteLine("it is not prime");
            }
        }
    }
}
