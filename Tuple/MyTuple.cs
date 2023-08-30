using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class MyTuple<T,T2,T3>
        
    {
        public T Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public MyTuple(T item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }   
        public MyTuple(T item1,T2 item2,T3 item3) :this(item1, item2)
        {
            Item3 = item3;
        }
        
        public override string ToString()
           =>$"{Item1} -> {Item2} -> {Item3}";
        


    }
}
