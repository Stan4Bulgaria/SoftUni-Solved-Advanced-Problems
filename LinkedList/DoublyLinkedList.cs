using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DoublyLinkedList
    {
        private bool IsReversed = false;
        public int Count { get; set; }
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public void Reversed()
        {
            IsReversed = true;
        }
        public void ForEach(Action<Node> action)
        {
            var node = Head;
            if(IsReversed == true)
            {
                node = Tail;
            }
            while (node != null)
            {
                action(node);
                if(IsReversed == true)
                {
                    node = node.Previous;
                }
                else
                node = node.Next;
            }
        }
        public Node[] ToArray()
        {
            Node[] nodeArray = new Node[Count];
            var node = Head;
            int index = 0;
            while (node != null)
            {
                nodeArray[index++] = node;
                node = node.Next;
            }
            return nodeArray;

        }
        public Node RemoveFirst()
        {
            var previuousHead = Head;
            var nextHead = Head.Next;
            if(nextHead != null)
            {
                nextHead.Previous = null;
            }
            Head = nextHead;
            return previuousHead;
        }
        public Node RemoveLast()
        {
            var currentTail = Tail;
            var previuousTail = Tail.Previous;
            if(previuousTail != null)
            {
                previuousTail.Next = null;
            }
            Tail = previuousTail;
          
            return currentTail;
        }

        public void AddFirst(Node node)
        {
            //check if first element is added to the list of nodes//
            Count++;
            if (!CheckIfFirstElement(node))
            {
                Node previousHead = Head;
                Head = node;
                previousHead.Previous = Head;
                Head.Next = previousHead;
            }
        }
        public void AddLast(Node node)
        {
            Count++;
           if(!CheckIfFirstElement(node))
           {
                Node previousTail = Tail;
                Tail = node;
                previousTail.Next = Tail;
                Tail.Previous = previousTail;
           }
        }
        private bool CheckIfFirstElement(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return true;
            }
            return false;
        }
        
    }
}
