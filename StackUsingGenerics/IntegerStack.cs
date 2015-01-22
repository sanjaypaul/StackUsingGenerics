using System;

namespace StackUsingGenerics
{
    class IntegerStack
    {
       readonly int maxSize; 
       int indexPosition = 0;
       int[] items;

       public IntegerStack():this(100)
       {
           
       }

       public IntegerStack(int size)
       {
          maxSize = size;
          items = new int[maxSize];
       }

       public void Push(int item)
       {
          if(indexPosition >= maxSize) 
             throw new StackOverflowException();       
          items[indexPosition] = item;
          indexPosition++;
       }

       public int Pop()
       {
           indexPosition--;
           if (indexPosition >= 0)
           {
               return items[indexPosition];
           }
           else
           {
               indexPosition = 0;
               throw new InvalidOperationException("Cannot pop an empty stack");
           }
       }
    }
}
