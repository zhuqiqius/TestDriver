using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.StacksQueues
{
    // Describe how you could use a single array to implement three stack
    public class Stack1FromSingleArray
    {
        public Object[] array;

        public Object pop()
        {
            int size = array.Count();
            Object obj = array[size - 1];
            List<Object> list = array.ToList();
            list.RemoveAt(size - 1);
            array = list.ToArray();
            return obj;
        }

        public void push (Object obj)
        {
            List<Object> list = array.ToList();
            list.Add(obj);
            array = list.ToArray();
        }
    }
}
