using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Stack
    {

        private StackItem _top; // Reference to the last item added
        private int _count; // Track number of items in stack

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot add null to stack.");

            StackItem newItem = new StackItem(obj)
            {
                Next = _top // New item points to previous top
            };

            _top = newItem; // Update top reference
            _count++;
        }

        public object Pop()
        {
            if (_top == null)
                throw new InvalidOperationException("Stack is empty. Cannot pop.");

            object value = _top.Value;
            _top = _top.Next; // Move top pointer to next item
            _count--;
            return value;
        }

        public void Clear()
        {
            _top = null; // Remove all references
            _count = 0;
        }

        public bool IsEmpty()
        {
            return _count == 0;


        }


    }

}
