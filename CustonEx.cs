using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace CustomException
{
    class UnwantedCharException : Exception
    {
        //create custruction and pass a error message to 
        //base class i.e.System exception class
        public UnwantedCharException(String msg) : base(msg) { }
    }
    class CustonEx
    {
        static void Main(string[] args)
        {
            try
            {
                string s = GetInputString();

                //process further if no exception.
                Console.WriteLine(s);

            }
            catch (UnwantedCharException ex)
            {
                //Get custom exception
                Console.WriteLine(ex.Message);

            }
        }
        static string GetInputString()
        {
            string s = Console.ReadLine();
            //User String is not alphnumeric, throw Exception.
            if (!IsAlphaNumeric(s))
            {
                throw new UnwantedCharException("Only Alphanumeric string is allowed");
            }

            return s;
        }
        public static bool IsAlphaNumeric(String strToCheck)
        {
            Regex objAlphaNumericPattern = new Regex("[^a-zA-Z0-9]");
            return !objAlphaNumericPattern.IsMatch(strToCheck);
        }
    }
}


    //custom exception class or user defined Exception class.
   

    //Test Program
    



