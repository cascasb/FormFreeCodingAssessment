using System;

namespace FreeFormAssessment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList intList = new SinglyLinkedList();
            SinglyLinkedList stringList = new SinglyLinkedList();
            SinglyLinkedList emptyList = new SinglyLinkedList();

            for (int x = 0; x < 10; x++)
            {
                intList.Append(x + 1);
                stringList.Append("String" + (x + 1));
            }

            intList.PrintList();
            Console.WriteLine(intList.FindFifthFromEnd());
            stringList.PrintList();
            Console.WriteLine(stringList.FindFifthFromEnd());
            emptyList.PrintList();
            Console.WriteLine(emptyList.FindFifthFromEnd());
        }

        public class SinglyLinkedList
        {
            //this class creates a simple singly linked list
            Node root;
            public class Node
            {
                //two different nodes can be created
                //these nodes hold either an int or a string 
                public object data;
                public Node next;

                public Node (int input)
                {
                    data = input;
                    next = null;
                }
                public Node(string input)
                {
                    data = input;
                    next = null;
                }
            }
            public void Append(int x)
            {
                //This method allows a new integer node to be added to the end of a list
                //If the list is empty then the added node will be the root node
                Node node = new Node(x);
                if(root == null)
                {
                    root = node;
                }
                else
                {
                    Node current = root;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = node;
                }
            }

            public void Append(string input)
            {
                //This method allows a new string node to be added to the end of a list
                //If the list is empty then the added node will be the root node
                Node node = new Node(input);
                if (root == null)
                {
                    root = node;
                }
                else
                {
                    Node current = root;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = node;
                }
            }

            public void PrintList()
            {
                //this method prints the list out to the console
                Node current = root;
                if (current == null)
                {
                    Console.WriteLine("The list is empty.");
                }
                else
                {
                    while (current != null)
                    {
                        Console.Write(current.data + " ");
                        current = current.next;
                    }
                    Console.WriteLine();
                }
            }

            public string FindFifthFromEnd()
            {
                //This method finds the fifth element from the end of the list
                //it is returned in a string format to be printed in Main.
                Node current = root;

                Node end = null;
                Node SecondFromEnd = null;
                Node ThirdFromEnd = null;
                Node FourthFormEnd = null;
                Node FifthFormEnd = null;

                if(current == null)
                {
                    return "The list is empty.";
                }


                while (current != null)
                {
                    if(end == null)
                    {
                        end = current;
                        
                    }
                    else if (SecondFromEnd == null)
                    {
                        SecondFromEnd = end;
                        end = current;
                    }
                    else if (ThirdFromEnd == null)
                    {
                        ThirdFromEnd = SecondFromEnd;
                        SecondFromEnd = end;
                        end = current;
                    }
                    else if (FourthFormEnd == null)
                    {
                        FourthFormEnd = ThirdFromEnd;
                        ThirdFromEnd = SecondFromEnd;
                        SecondFromEnd = end;
                        end = current;
                    }
                    else if (FifthFormEnd == null)
                    {
                        FifthFormEnd = FourthFormEnd;
                        FourthFormEnd = ThirdFromEnd;
                        ThirdFromEnd = SecondFromEnd;
                        SecondFromEnd = end;
                        end = current;
                    }
                    else
                    {
                        FifthFormEnd = FourthFormEnd;
                        FourthFormEnd = ThirdFromEnd;
                        ThirdFromEnd = SecondFromEnd;
                        SecondFromEnd = end;
                        end = current;
                    }
                    current = current.next;
                }

                if (FifthFormEnd == null)
                {
                    return "The List was not 5 nodes long";
                }
                else
                {
                    return "The fifth element form the end is: " + Convert.ToString(FifthFormEnd.data);
                }
            }
        }
    }
}
