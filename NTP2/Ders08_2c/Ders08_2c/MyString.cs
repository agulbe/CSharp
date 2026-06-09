using System;
using System.Collections.Generic;
using System.Text;

namespace Ders08_2c
{
    internal class MyString
    {
        public String str;
        public MyString(string s)
        {
            str = s;
        }
        public string A(int n)
        {
            string strng = str;
            for (int i = 1; i < n; i++)
                strng += str;
            return strng;
        }
    }
}
