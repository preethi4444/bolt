using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace IEnumerator

{

    class Program

    {

        static void Main(string[] args)

        {

            List<string> Month = new List<string>();

            Month.Add("January");

            Month.Add("February");

            Month.Add("March");

            Month.Add("April");

            Month.Add("May");

            Month.Add("June");

            Month.Add("July");

            Month.Add("August");

            Month.Add("September");

            Month.Add("October");

            Month.Add("November");

            Month.Add("December");

            IEnumerator<string> iEnumeratorOfString = Month.GetEnumerator();

            iEnumeratorMethodOne(iEnumeratorOfString);

            Console.ReadKey();

        }

        ///this method prints only upto june month and sends the iterator value to second method

        static void iEnumeratorMethodOne(IEnumerator<string> i)

        {

            while (i.MoveNext())

            {

                Console.WriteLine(i.Current);



                if (i.Current == "June")

                {

                    iEnumeratorMethodTwo(i);

                }

            }

        }

        /// this method prints from june as enumerator remebers the current iterating value

        static void iEnumeratorMethodTwo(IEnumerator<string> i)

        {

            Console.WriteLine("after june");

            while (i.MoveNext())

            {

                Console.WriteLine(i.Current);

            }

        }

    }

}