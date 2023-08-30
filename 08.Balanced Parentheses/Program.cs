using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpute = Console.ReadLine();
            Stack<char> parantheses = new Stack<char>();
            bool isBalanced = true;
            foreach (var item in inpute)
            {
                if(item == '(' || item =='[' || item== '{')
                {
                    parantheses.Push(item);
                    continue;
                }
                if(parantheses.Count == 0)
                {
                    isBalanced = false;
                    break;
                }
                if(item == ')' && parantheses.Peek() =='(')
                {
                    parantheses.Pop(); 
                }
                else if (item == ']' && parantheses.Peek() == '[')
                {
                    parantheses.Pop();
                }
                else if (item == '}' && parantheses.Peek() == '{')
                {
                    parantheses.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
                
            }
            if (!isBalanced || parantheses.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
