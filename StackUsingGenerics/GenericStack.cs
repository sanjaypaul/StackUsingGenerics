using System;

namespace StackUsingGenerics
{
    public class GenericStack<T>
    {
       readonly int maxSize; 
       int indexPosition = 0;
       T[] items;

       public GenericStack():this(100)
       {}

       public GenericStack(int size)
       {
          maxSize = size;
          items = new T[maxSize];
       }

       public void Push(T item)
       {
          if(indexPosition >= maxSize) 
             throw new StackOverflowException();
          items[indexPosition] = item;
          indexPosition++;
       }

       public T Pop()
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
