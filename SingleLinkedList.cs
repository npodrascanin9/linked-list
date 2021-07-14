using System;

namespace Linked_Lists
{
    internal sealed class SingleLinkedList
    {
        private Node start;
        public SingleLinkedList()
        {
            start = null;
        }

        public void CreateList()
        {
            Console.Write("Enter the number of nodes: ");
            var n = Convert.ToInt32(Console.ReadLine());

            if (n is 0) return;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                var data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void DisplayList()
        {
            Node p;

            if (start is null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            Console.Write("List is: ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }

            Console.WriteLine();
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }

            Console.WriteLine($"Number of nodes in the list = {n}.");
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;

            while (p != null)
            {
                if (p.info == x)
                {
                    break;
                }

                position++;
                p = p.link;
            }

            var isFound = p != null;
            Console.WriteLine(isFound ? $"{x} is found at the {position}. position" : $"{x} is not found in the list!");
            return isFound;
        }

        public void InsertAtBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (start is null)
            {
                start = temp;
                return;
            }

            p = start;
            while (p.link != null)
            {
                p = p.link;
            }

            p.link = temp;
        }

        public void InsertAfter(int data, int x)
        {
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p is null)
            {
                Console.WriteLine($"{x} not present in the list!");
            }

            Node temp = new Node(data);
            temp.link = p.link;
            p.link = temp;
        }

        public void InsertBefore(int data, int x)
        {
            Node temp;

            if (start is null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            if (x == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link is null)
            {
                Console.WriteLine($"{x} is not present in the list!");
            }

            temp = new Node(data);
            temp.link = p.link;
            p.link = temp;
        }

        public void InsertAtPosition(int data, int k)
        {
            Node temp;
            int i;

            if (k == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            for (i = 0; i < k - 1 && p != null; i++)
            {
                p = p.link;
            }

            if (p is null)
            {
                Console.WriteLine($"You can insert only upto {i} the position!");
            }

            temp = new Node(data);
            temp.link = p.link;
            p.link = temp;
        }

        public void DeleteFirstNode()
        {
            if (start is null)
            {
                return;
            }

            start = start.link;
        }

        public void DeleteLastNode()
        {
            if (start is null)
            {
                return;
            }

            if (start.link is null)
            {
                start = null;
                return;
            }

            Node p = start;
            while (p.link.link != null)
            {
                p = p.link;
            }

            p.link = null;
        }

        public void DeleteNode(int x)
        {
            if (start is null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (start.info == x)
            {
                start = start.link;
                return;
            }

            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link is null)
                Console.WriteLine($"Element {x} is not in the list!");
            p.link = p.link.link;
        }
    }
}
