using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class StackItem : Stack
    {
        public object Value { get; }
        public StackItem Next { get; set; } // Pointer to the next item in the stack

        public StackItem(object value)
        {
            Value = value;
        }


    }    
}    

