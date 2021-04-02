using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
   public class StackOfStrings : Stack<string>
    {


        public bool IsEmpty()
        {

            if(this.Count>0)
            {
                return true;
            }

            return false;

        }

        public void AddRange(Stack<string> stack)
        {

            while(stack.Count>0)
            {
                this.Push(stack.Pop());
            }

        }


    }
}
