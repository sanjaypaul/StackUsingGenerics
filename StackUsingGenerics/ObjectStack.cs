using System;

namespace StackUsingGenerics
{
    public class ObjectStack
    {
       readonly int maxSize; 
       int indexPosition = 0;
       object[] items;

       public ObjectStack():this(100)
       {
           
       }

       public ObjectStack(int size)
       {
          maxSize = size;
          items = new object[maxSize];
       }

       public void Push(object item)
       {
          if(indexPosition >= maxSize) 
             throw new StackOverflowException();       
          items[indexPosition] = item;
          indexPosition++;
       }

       public object Pop()
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
