using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Work2
{
    internal class SuperStack<T> : Stack<T>
    {
        public static bool operator ==(SuperStack<T> a, SuperStack<T> b)
        {
            //if (a.Count == 0 || b.Count == 0)
            //{
            //throw InsufficientExecutionStackException;
            //}

            if (a.Count != b.Count)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool operator !=(SuperStack<T> a, SuperStack<T> b)
        {
            if(a.Count != b.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
