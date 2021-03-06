using System;
using System.Collections.Generic;

namespace Task_3
{
    namespace A
    {
        class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                Data = data;
            }
            public override string ToString()
            {
                return $"{Data}";
            }
        }

        class LinkedList
        {
            Node head;
            Node tail;

            public int Count { get; set; }

            public void Add(int data)
            {
                Node node = new Node(data);

                if (head == null)
                    head = node;

                else
                    tail.Next = node;
                tail = node;

                Count++;
            }

            public void AddFirst(int data)
            {
                Node node = new Node(data);

                node.Next = head;
                head = node;

                if (Count == 0)
                    tail = head;

                Count++;
            }
            public void Clear()
            {
                Count = 0;
                head = null;
                tail = null;
            }
            public bool Contains(int data)
            {
                Node current = head;

                while (current != null)
                {
                    if (current.Data == data)
                        return true;
                    current = current.Next;
                }

                return false;
            }
            public void Print()
            {
                Node current = head;

                int i = 1;

                while (current != null)
                {
                    Console.WriteLine($"{i} - {current}");
                    current = current.Next;
                    i++;
                }
            }

            public Node Max()
            {
                Node current = head;
                Node result = head;

                while (current != null)
                {
                    if (current.Data > result.Data)
                        result = current;

                    current = current.Next;
                }

                return result;
            }

            public Node Min()
            {
                Node current = head;
                Node result = head;

                while (current != null)
                {
                    if (current.Data < result.Data)
                        result = current;

                    current = current.Next;
                }

                return result;
            }

            public Node Middle()
            {
                int index = 0;
                Node current = head;

                while (index != (Count + 1) / 2)
                {
                    current = current.Next;
                    index++;
                }

                return current;
            }

            public bool Remove(int data)
            {
                Node current = head;
                bool isFounded = false;

                while(current != null)
                {
                    if(current.Data == data)
                    {
                        isFounded = true;
                        break;
                    }

                    current = current.Next;
                }

                if (isFounded)
                {
                    if(current == head)
                        head = current.Next;

                    else if(current == tail)
                    {
                        tail = null;
                        current = head;

                        while(current != null)
                        {
                            if (current.Next == null)
                                tail = current;

                            current = current.Next;
                        }
                    }

                    else
                    {
                        Node previos = head;

                        while (previos.Next != current)
                            previos = previos.Next;

                        previos.Next = current.Next;
                    }

                    Count--;
                    return true;
                }
                else return false;
            }
        }

        class MainClass
        {
            public static void Main()
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Add(1);
                linkedList.Add(2);
                linkedList.AddFirst(3);
                linkedList.Add(4);
                linkedList.Print();
            }
        }
    }
}