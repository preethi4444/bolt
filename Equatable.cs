using System;

using System.Collections;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Equatable

{

   /// class implementing IEquatable interface 

    public class Employee : IEquatable<Employee>

    {

            public int Account;

            public string Name;



            public Employee(int account, string name)

            {

                this.Account = account;

                this.Name = name;

            }

        ///defining Equals method of IEquatable to check for equal name

            public bool Equals(Employee other)

            {

                if (other == null) return false;

                return (this.Name.Equals(other.Name));

            }

    }

    class Bank

    {

        public static void Main()

        {

            Employee emp1 = new Employee(1, "nikitha");



            ArrayList employees = new ArrayList();

            employees.Add(emp1);



            Employee emp2 = new Employee(2, "nikitha");

            Console.WriteLine("both employs have same name: {0}", emp1.Equals(emp2));

            Console.ReadKey();

        }

    }

}