using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Softuni_String
{
    class SoftuniString
    {
        private int index = 0;
        private char[] array;
        public SoftuniString()
        {
            array = new char[4];
        }
        public void Append(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                array[index++] = text[i];
            }
        }
        public override string ToString()
        {
            return new string(array);
        }
    }
}
