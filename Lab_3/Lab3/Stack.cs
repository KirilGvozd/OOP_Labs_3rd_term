using System.Collections;

namespace Lab3
{
    public class Stack
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
        
        public class Developer
        {
            private readonly int _id;
            public string Name { get; set; }
            public string Department { get; set; }

            public Developer(string developerName, string department)
            {
                _id = GetHashCode();
                this.Name = developerName;
                this.Department = department;
            }
        }


        public int[] MyStack;
        public int Counter;
        public int StackCapacity;

        public Stack(int n)
        {
            MyStack = new int[n];
            Counter = 0;
            StackCapacity = n;
        }

        public void Push(int item)
        {
            if (!IsStackFull())
            {
                MyStack[Counter++] = item;
            }
            else
                Console.WriteLine("Stack is Full");
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
        
        public static Stack operator *(Stack givenStack, int data)
        {
            givenStack.Push(data);
            return givenStack;
        }

        public static Stack operator / (Stack givenStack, int data)
        {
            givenStack.Pop();
            return givenStack;
        }

        public static bool operator true (Stack givenStack)
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

        public static bool operator false(Stack givenStack)
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

        public static bool operator ==(Stack firstStack, Stack secondStack)
        {
            int counter = 0;
            
            if (firstStack.StackCapacity == secondStack.StackCapacity)
            {
                for (int i = 0; i < firstStack.StackCapacity; i++)
                {
                    if (firstStack.MyStack[i] != secondStack.MyStack[i])
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

        public static bool operator !=(Stack firstStack, Stack secondStack)
        {
            int counter = 0;
            
            if (firstStack.StackCapacity == secondStack.StackCapacity)
            {
                for (int i = 0; i < firstStack.StackCapacity; i++)
                {
                    if (firstStack.MyStack[i] != secondStack.MyStack[i])
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
    }    
}