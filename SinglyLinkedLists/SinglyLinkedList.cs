﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        private SinglyLinkedListNode firstNode;
        public SinglyLinkedList()
        {
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            throw new NotImplementedException();
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddAfter(string existingValue, string value)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(string value)
        {
            throw new NotImplementedException();
        }

        public void AddLast(string value)
        {
            if (firstNode == null)
            {
                firstNode = new SinglyLinkedListNode(value);
            }
            else
            {
               LastNode().Next = new SinglyLinkedListNode(value);
            }
                
        }
        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
            throw new NotImplementedException();
        }

        public string ElementAt(int index)
        {
            SinglyLinkedListNode currentNode = firstNode;
            //Solution 1:
            //for (int i = 0; i < index; i++)
            //{
            //    if (currentNode.IsLast())
            //    {
            //        throw new ArgumentOutOfRangeException();
            //    }
            //    currentNode = currentNode.Next;
            //}
            //soloution 2:
                //for (int if = 0; if < index; i++) {
                //    currentNode = (currentNode == null) ? null : currentNode.Next;
                //}
            //solutuion  3:
             while (index > 0 && currentNode != null)
                {
                    index--;
                    currentNode = currentNode.Next;
                }
             if (currentNode == null)
             {
                 throw new ArgumentOutOfRangeException();
             }
                return currentNode.Value;

        }     

        public string First()
        {
            if (firstNode == null)
            {
                return null;
            }
            else
            {
                return firstNode.Value;
            }
        }

        public int IndexOf(string value)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }

        // HINT 1: You can extract this functionality (finding the last item in the list) from a method you've already written!
        // HINT 2: I suggest writing a private helper method LastNode()
        // HINT 3: If you highlight code and right click, you can use the refactor menu to extract a method for you...
        public string Last()
        {
            var lastNode = LastNode();
            return (lastNode == null) ? null : lastNode.Value;
        }
        private SinglyLinkedListNode LastNode()
        {
            if (firstNode == null)
            {
                return null;
            }

            SinglyLinkedListNode lastNode = firstNode;

            while (!lastNode.IsLast())
            {
                lastNode = lastNode.Next;
            }
            return lastNode;
        }

        public void Remove(string value)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
            return new string [] { };
        }
        public override string ToString() 
        {
            SinglyLinkedListNode node = firstNode;
            if (node == null)
            {
                return "{ }";
            }
            //else
            //{

            //    return "{ \"" + node.Value + "\" }";
            //}   
            else if (node.Next == null)
            {
                return "{ \"" + node.Value + "\" }";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder sb1 = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                sb1 = sb;
                sb2 = sb1;
                sb.Append("{ "+'"' + node.Value+'"' + ", ");
                sb1.Append('"' + node.Next.Value + '"' + ", ");
                sb2.Append('"' + node.Next.Next.Value + '"'+" }");
                return (sb.ToString());

                //return "{ \""+ node.Value+'"' +"," + " "+ '"'+node.Next.Value+'"' +","+" "+ '"'+node.Next.Next.Value + "\" }";
            }
        }

    }
}
