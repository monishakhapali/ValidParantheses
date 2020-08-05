using System;
using System.Collections;

namespace ValidParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string s = "[()(){}]";
            int i = 0;
            Stack stack = new Stack();
            bool flag = false;
            if (s.Length % 2 != 0)
                flag = false;
            foreach (var c in s)
            {
                if (c == '(' || c == '[' || c=='{')
                {
                    stack.Push(c);
                }
                if(c ==')' && stack.Count!=0 && stack.Peek().ToString() =="(" )
                {
                    stack.Pop();
                }
                if (c == ']' && stack.Count != 0 && stack.Peek().ToString() == "[")
                {
                    stack.Pop();
                }
                if (c == '}' && stack.Count != 0 && stack.Peek().ToString() == "{")
                {
                    stack.Pop();
                }
            }
            if(stack.Count != 0)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
            Console.WriteLine(flag);
            Console.ReadLine();
        }
    }
}
