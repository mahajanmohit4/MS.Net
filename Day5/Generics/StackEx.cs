using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class StackEx
    {
        static void Main1()
        {
            IntegerStack iS = new IntegerStack(4);
            iS.Push(11);
            iS.Pop();
            iS.Push(23);
            iS.Push(33);
            iS.Pop();
            iS.Pop();
            iS.Pop();

            Console.ReadLine();
        }
        static void Main()
        {
            MyStack<int> iS = new MyStack<int>(3);
            iS.Push(11);
            iS.Pop();
            iS.Push(23);
            iS.Push(33);
            iS.Pop();
           // iS.Pop();
            // iS.Pop();

            Console.ReadLine();
        }
    }
    class MyStack<T>
    // where T : class
    {
        T[] arr;
        public MyStack(int Size)
        {
            //T obj = new T();

            arr = new T[Size];
        }
        int Pos = -1;
        public void Push(T i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public T Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }
    class IntegerStack
    {
        int[] arr;
        public IntegerStack(int Size)
        {
            arr = new int[Size];
        }
        int Pos = -1;
        public void Push(int i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public int Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }
}
