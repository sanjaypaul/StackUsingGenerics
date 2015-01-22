using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStack aObjectStack = new ObjectStack();
            aObjectStack.Push("ABCD");
            aObjectStack.Push(10);
            int firstItem = (int) aObjectStack.Pop();
            int lastItem = (int) aObjectStack.Pop(); // Boom...

            IntegerStack aIntegerStack = new IntegerStack();
            aIntegerStack.Push(12);
            //aIntegerStack.Push("ABCD"); //Compile error: good.
            // But for others data type you have to write seperate stacks ...;=((

            GenericStack<int> intGenericStack = new GenericStack<int>();
            intGenericStack.Push(1212);
            //intGenericStack.Push("ABCD"); //Compile error

            GenericStack<string> stringGenericStack = new GenericStack<string>(); //Wow. Can configure the type
            stringGenericStack.Push("ABCD");
            //stringGenericStack.Push(2323);

            GenericStack<Student> studentStack = new GenericStack<Student>(); //..Great it can be used for user defined type
            Student student1 = new Student("001", "Pinki");
            Student student2 = new Student("003", "Pavel");

            studentStack.Push(student1);
            studentStack.Push(student2);


            GenericStack<int> gsk = new GenericStack<int>();
            gsk.Push(23);

        }
    }
}
