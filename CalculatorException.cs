using System;

namespace calculatorException
{
    class Calculator1
    {
        private int a, b;
        private int res;
        public void add(int a, int b)
        {
           
            try
            {
                int c = a + b;
                Console.Write("Result is" + c);

            }
            catch (OverflowException e)
            {
                Console.Write("Exceeded its range" + e);
            }

        }
        public void sub(int a, int b)
        {
            try
            {
                int c = a - b;
                Console.Write("Result is" + c);

            }
            catch (OverflowException e)
            {
                Console.Write("Exceeded its range" + e);
            }
        }
        public void mul(int a, int b)
        {
            
            try { 
                int c = a * b;
                Console.Write("Result is" + c);


            }
            catch(OverflowException e)
            {
                Console.Write("Exceeded its range" + e);
            }
        }
        public void div(int a, int b)
        {
         
            try
            {
               int c = a / b;
                Console.Write("Result is" + c);

            }
            catch (DivideByZeroException e)
            {
                Console.Write("divided by zero" + e);
            }
            
           
        }
       
        public Calculator1(int a, int b)
        {
            this.a = a;
            this.b = b;


        }
        public void calci(char op1)
        {
            if (op1 == '+')
            {
                add(a, b);

            }
            if (op1 == '-')
            {
               sub(a, b);

            }
            if (op1 == '*')
            {
                mul(a, b);

            }
            if (op1 == '/')
            {
                 div(a, b);

            }
         
        }
        static void Main(string[] args)
        {
                     
         
                char a;
                String val;
                int n1, n2;
                Console.Write("Enter integer: ");
                val = Console.ReadLine();
                n1 = Convert.ToInt32(val);
                Console.Write("Enter integer: ");
                val = Console.ReadLine();
                n2 = Convert.ToInt32(val);
                Console.Write("Enter operation: ");
                val = Console.ReadLine();
                a = Convert.ToChar(val);
                Calculator1 obj = new Calculator1(n1, n2);
                obj.calci(a);
               
            
        }
    }

}
   
