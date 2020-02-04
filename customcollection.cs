using System;

using System.Collections;

using System.Collections.Generic;

namespace CustomCollection

{

    public class Node

    {

        public int data;

        public Node next;

        public Node(int val)

        {

            data = val;

            next = null;

        }

    }



   

    public class Nikitha

    {

        Node head = null;

        public int count = 0;  

        ///adds elements into th list

        public int Add(int value)

        {

            Node n = new Node(value);

            if (head == null)

                head = n;

            else

            {

                Node curr = head;

                while (curr.next != null)

                {

                    curr = curr.next;

                }

                curr.next = n;

            }

            count++;

            Console.WriteLine("Element added");

            return count - 1;

        }

        /// removes the element with "value" from the list

        public void Remove(int value)

        {



            Node cur = head;

            if (head == null)

            {

                Console.WriteLine("Element not found");

                return;

            }

            else if (value.Equals(head.data))

            {

                head = head.next;

                Console.WriteLine("Element deleted");

                return;

            }



            Node prev = null;



            while (cur != null )

            {

                if(value.Equals(cur.data))

                {

                    prev.next=cur.next;

                }

                prev = cur;

                cur = cur.next;

            }



            

        }

        ///displays the list

        public void Display()

        {

            Node curr = head;

            while (curr != null)

            {

                Console.WriteLine(curr.data);

               

                    curr = curr.next;

            }

        }

        /// returns true if the given value is present in the list.

        public bool Contains(int value)

        {

            Node curr = head;

            while (curr != null)

            {

                if (value.Equals(curr.data))

                    return true;

                else

                    curr = curr.next;

            }

            return false;

        }

        /// returns the index value of a particular value

        public int IndexOf(int value)

        {

            int index = -1;

            Node curr = head;

            while (curr != null)

            {

                index++;

                if (value.Equals(curr.data))

                    return index;

                else

                    curr = curr.next;

            }

            return -1;

        }

        /// sorts the given list in an ascending order

        public void Sort()

        {

            Node temp1 = null, temp2 = null;

            int tempData;

            for(temp1=head;temp1.next!=null;temp1=temp1.next)

            {

                for (temp2 = temp1.next; temp2!= null; temp2 = temp2.next)

                {

                    if((temp1.data)>temp2.data)

                    {

                        tempData = temp1.data;

                        temp1.data = temp2.data;

                        temp2.data = tempData;

                    }

                }

            }

        }

        /// main method

        public static void Main(String[] args)

        {

            Nikitha n = new Nikitha();

            n.Add(5);

            n.Add(6);

            n.Add(7);

            n.Add(1);

            n.Add(2);

            n.Add(3);

            n.Add(4);

            n.Remove(4);

            n.Remove(2);

            Console.WriteLine("index of 6 is {0}",n.IndexOf(6));

            Console.WriteLine("is 7 present {0}",n.Contains(7));

            n.Sort();

            n.Display();

            Console.ReadKey();

        }

        



    }

   

}