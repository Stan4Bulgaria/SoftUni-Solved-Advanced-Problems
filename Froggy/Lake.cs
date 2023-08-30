﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake :IEnumerable<int>
    {
        private readonly List<int> elements;
        public Lake(List<int> elements)
        {
            this.elements = elements;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if(elements[i] % 2 != 0)
                {
                    yield return elements[i];
                }
            }
            for (int i = elements.Count-1; i >= 0; i--)
            {
                if (elements[i] % 2 == 0)
                {
                    yield return elements[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
