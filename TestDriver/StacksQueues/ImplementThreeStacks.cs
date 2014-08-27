using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.StacksQueues
{
    // Describe how you could use a single array to implement three stack
    public static class ThreeStacksFromSingleArray
    {
        public static Object[] objects;
        public static int arraySize;
    }
    public class Stack1
    {
        // Pop from the end of the array
        public Object pop()
        {
            Object obj = ThreeStacksFromSingleArray.objects.ElementAt(ThreeStacksFromSingleArray.arraySize - 1);
            return obj;
        }

        // Push to the end of the array
        public void push(Object obj)
        {
            List<Object> list = ThreeStacksFromSingleArray.objects.ToList();
            list.Add(obj);
            ThreeStacksFromSingleArray.objects = list.ToArray();
            ThreeStacksFromSingleArray.arraySize = list.Count();
        }
    }

    public class Stack2
    {
        // Pop from the front of the array
        public Object pop()
        {
            Object obj = ThreeStacksFromSingleArray.objects.ElementAt(0);
            return obj;
        }

        // Push to the front of the array
        public void push(Object obj)
        {
            List<Object> list = ThreeStacksFromSingleArray.objects.ToList();
            List<Object> newList = new List<object>();
            newList.Add(obj);
            newList.AddRange(list);
            ThreeStacksFromSingleArray.objects = newList.ToArray();
            ThreeStacksFromSingleArray.arraySize = newList.Count();
        }
    }

    public class Stack3
    {
        // 0-based index 
        private int top;

        // Pop from the nth element of the array
        public Object pop()
        {
            Object obj = ThreeStacksFromSingleArray.objects.ElementAt(top);
            return obj;
        }

        // Push to the front of the array
        public void push(Object obj)
        {
            List<Object> list = ThreeStacksFromSingleArray.objects.ToList();
            List<Object> front = list.GetRange(0, top);
            List<Object> end = list.GetRange(top + 1, ThreeStacksFromSingleArray.arraySize - 1);
            List<Object> newList = new List<object>();
            newList.AddRange(front);
            newList.Add(obj);
            newList.AddRange(end);
            ThreeStacksFromSingleArray.objects = newList.ToArray();
            ThreeStacksFromSingleArray.arraySize = newList.Count();
            top++;
        }
    }
}
