using System.Collections;
using Lab7;

namespace Lab3
{
    public class Stack<T> : IGeneralizedInterface<T>
    {
        public class Production
        {
            private readonly int _id;
            public string Name { get; set; }
            
            public Production(string organisationName)
            {
                this._id = GetHashCode();
                this.Name = organisationName;
            }
        }

        public T[] MyStack;
        public int Counter;
        public int StackCapacity;

        public Stack(int n)
        {
            MyStack = new T[n];
            Counter = 0;
            StackCapacity = n;
        }
        
        public bool IsStackFull()
        {
            if (Counter == StackCapacity)
                return true;
            else
                return false;
        }

        public object Pop()
        {
            if (MyStack.Length != 0)
                return MyStack[--Counter];
            return -1;
            Console.WriteLine("Stack is empty");
        }

        public object TopElement()
        {
            if (MyStack.Length != 0)
                return MyStack[Counter - 1];
            return 0;
        }
        
        public static Stack<T> operator *(Stack<T> givenStack, T data)
        {
            givenStack.AddItem(data);
            return givenStack;
        }

        public static Stack<T> operator / (Stack<T> givenStack, int data)
        {
            givenStack.Pop();
            return givenStack;
        }

        /*
        public static bool operator true (Stack<T> givenStack)
        {
            for (int i = 0; i < givenStack.StackCapacity; i++)
            {
                if (givenStack.MyStack[i] < 0)
                {
                    return true;
                }
            }
            return false;
        }
        */

        /*
        public static bool operator false(Stack<T> givenStack)
        {
            for (int i = 0; i < givenStack.StackCapacity; i++)
            {
                if (givenStack.MyStack[i] > 0)
                {
                    return false;
                }
            }
            return true;
        }
        */

        public static bool operator ==(Stack<T> firstStack, Stack<T> secondStack)
        {
            int counter = 0;
            
            if (firstStack.StackCapacity == secondStack.StackCapacity)
            {
                for (int i = 0; i < firstStack.StackCapacity; i++)
                {
                    if (!Equals(firstStack.MyStack[i], secondStack.MyStack[i]))
                    {
                        counter++;
                    }
                }
            }
            else
            {
                return false;
            }

            if (counter == 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Stack<T> firstStack, Stack<T> secondStack)
        {
            int counter = 0;
            
            if (firstStack.StackCapacity == secondStack.StackCapacity)
            {
                for (int i = 0; i < firstStack.StackCapacity; i++)
                {
                    if (!Equals(firstStack.MyStack[i], secondStack.MyStack[i]))
                    {
                        counter++;
                    }
                }
            }
            else
            {
                return true;
            }

            if (counter == 0)
            {
                return false;
            }

            return true;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void AddItem(T element)
        {
            if (!IsStackFull())
            {
                MyStack[Counter++] = element; 
            }
            else
            {
                Console.WriteLine("Stack is Full");
            }
        }

        public void DeleteItem(T element)
        {
        }

        public void LookUp()
        {
        }
    }    
}