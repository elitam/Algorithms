using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Train
{

    public class Deque<T> where T : Train
    {
        private static int defaultCapacity = 16;

        private Stack<T> passengerTrains;
        private Stack<T> freightTrains;
        private Stack<T> history;

        public Deque() : this(defaultCapacity) { }
        public Deque(int capacity)
        {
            this.passengerTrains = new Stack<T>(capacity);
            this.freightTrains = new Stack<T>(capacity);
            this.history = new Stack<T>();
            this.Capacity = capacity;
        }
        public Deque(IEnumerable<T> collection)
             : this(collection.Count())
        {
            //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
        }
        public int Capacity; //показва капацитета
        public int Count; //показва броят елементи
        public void AddFront(T item)
        {
            //добавя елемент отпред
        }
        public void AddBack(T item)
        {
            //добавя елемент отзад
        }
        public T RemoveFront()
        {
            //връща и премахва елемента отпред
        }
        public T RemoveBack()
        {
            //връща и премахва елемента отзад
        }
        public T GetFront()
        {
            //връща, без да премахва, елемента отпред
        }
        public T GetBack()
        {
            //връща, без да премахва, елемента отзад
        }
    }

}
