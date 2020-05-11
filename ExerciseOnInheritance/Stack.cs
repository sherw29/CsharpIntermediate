using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Stack
    {
        private List<Object> _myStack = new List<object>();
        Object lastElement = new object();
        int count;

        public void Push(Object obj)
        {
            if (obj != null)
            {
                _myStack.Add(obj);
                Console.WriteLine("Pushed " + obj + " onto the stack.");
            }
            else
                Console.WriteLine("please enter a valid object");
        }

        public object Pop()
        {
            count = _myStack.Count-1;
            lastElement = _myStack[count];
            _myStack.RemoveAt(count);
            return "last element "+ lastElement + " popped from stack";
        }

        public void ClearStack()
        {
            _myStack.Clear();
            Console.WriteLine("stack was cleared");
        }

        public void Display_Stack()
        {
            foreach(object obj in _myStack)
                Console.WriteLine(obj);
        }
    }
}
