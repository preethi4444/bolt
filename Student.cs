using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace IComparableIComparer 

{

   /// class student implementing IComparable interface

    class Student : IComparable<Student>

    {

        

        public int roll { get; set; }

        public string name { get; set; }

        public int marks { get; set; }



        public  static void Main(string[] args)

        {

            Student s1 = new Student {roll= 2,name= "n2",marks= 300};

            Student s2 = new Student {roll = 1, name = "n1", marks = 500 };

            Student s3 = new Student {roll = 3, name = "n3", marks = 100 };



            List<Student> student = new List<Student>() {s1,s2,s3 };

            student.Sort();

            Console.WriteLine("sorted by roll num");

            foreach (Student s in student)

            {

                Console.WriteLine(s.roll + " " + s.name + " " + s.marks);



            }

            Console.WriteLine("sorted by salary");

            Compararer obj = new Compararer();

            student.Sort(obj);

            foreach (Student s in student)

            {

                Console.WriteLine(s.roll + " " + s.name + " " + s.marks);



            }

            Console.ReadKey();



        }

        ///defining CompareTo method of interface and sorting on roll.

        public int CompareTo(Student other)

        {

            if(this.roll<other.roll)

            {

                return -1;

            }

            else if(this.roll>other.roll)

            {

                return 1;

            }

            else

            {

                return 0;

            }

        }

    }

    ///class implementing IComparer interface 

    class Compararer : IComparer<Student>

    {

        ///defining Compare method of interface to sort on marks

        public int Compare(Student x, Student y)

        {

            if (x.marks< y.marks)

            {

                return -1;

            }

            else if (x.marks > y.marks)

            {

                return 1;

            }

            else

            {

                return 0;

            }

        }



    }

}