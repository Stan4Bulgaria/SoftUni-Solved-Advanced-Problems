using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingStackAndQueue
{
    public class CustomStack<T>
    {
        
        private T[] elements { get; set; }
        public int Count { get; private set; }
        private const int DefaultCapacity = 4;
        public CustomStack()
        {
            elements = new T[DefaultCapacity];
        }
        public void Push(T element)
        {
            if(Count == elements.Length)
            {
                Resize();
            }
            elements[Count] = element;
            Count++;  
        }
        private void Resize()
        {
            T[] newArray = new T[elements.Length + 1];
            for (int i = 0; i < elements.Length; i++)
            {
                newArray[i] = elements[i];
            }
            elements = newArray;
        }
        public T Pop()
        {
            if(elements.Length == 0)
            {
                throw new InvalidOperationException();
            }
            var lastOnTheStack = elements[Count - 1];
            //T[] array = new T[elements.Length - 1];
            //for (int i = 0; i < elements.Length-1; i++)
            //{
            //    array[i] = elements[i];
            //}
            //elements = array;
            Count--;
            return lastOnTheStack;
        }
        public T Peek()
        {
            if (elements[0] == null)
            {
                throw new InvalidOperationException();
            }
            return elements[Count - 1];
        }
        public void ForEach(Action <T> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(elements[i]);
            }
        }


       
        
    }
}
