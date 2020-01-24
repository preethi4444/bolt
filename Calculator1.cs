using System;

namespace Calculator
{
    public class Calculator1
    {
        private int a, b;
        private int res;
        public int add(int a,int b)
        {
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
            {
                throw new System.OverflowException("can not add");

            }
            else if ((a == int.MinValue && b < 0) || (b == int.MinValue && a < 0))
            {
                throw new System.OverflowException("cannot add");
            }
            else
            {
                int c = a + b;
                return c;
            }
        }
        public int sub(int a, int b)
        {
            if ((a == int.MaxValue && b < 0) || (b == int.MaxValue && a < 0))
            {
                throw new System.OverflowException("can not subtract");

            }
            else if ((a == int.MinValue && b > 0) || (b == int.MinValue && a > 0))
            {
                throw new System.OverflowException("cannot subtract");
            }
            else
            {
                int c = a - b;
                return c;
            }
        }
        public int mul(int a, int b)
        {
            if ((a == int.MaxValue &&(b!=1 || b!=0 || b!=-1)) || (b == int.MaxValue && (a!=1 || a!=0 || a!=-1)))
            {
                throw new System.OverflowException("can not product");

            }
            else if ((a == int.MinValue && (b != 1 || b != 0 || b != -1)) || (b == int.MinValue && (a != 1 || a != 0 || a != -1)))
            {
                throw new System.OverflowException("cannot product");
            }
            else
            {
                int c = a * b;
                return c;
            }
        }
        public int div(int a, int b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException("can not divide");
            }
            else
            {
                int c = a / b;
                return c;
            }
        }
        public Calculator1()
        {

        }
        public Calculator1(int a,int b)
        {
            this.a = a;
            this.b = b;
        

        }
        public int calci(char op1)
        {
            if (op1 == '+')
            {
                res = add(a,b);

            }
            if (op1 == '-')
            {
                res = sub(a,b);

            }
            if (op1 == '*')
            {
                res = mul(a,b);

            }
            if (op1 == '/')
            {
                res =  div(a,b);

            }
            return res;
        }
        static void Main(string[] args)
        {
            char a;
            String val;
            int n1, n2,ans;
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
            ans = obj.calci(a);
            Console.WriteLine("Result is " + ans);
        }
    }
}
