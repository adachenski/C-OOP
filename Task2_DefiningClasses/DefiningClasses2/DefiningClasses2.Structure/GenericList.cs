namespace DefiningClasses2.Structure
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class GenericList<T>
    {
        const int DefaultCapacity = 10;
        public List<T> listOfElements;
        private T[] ElementContainer;
        private int count = 0;
        private int currentCapacity { get; set; }

        public GenericList(int capacity)
        {
            this.currentCapacity = capacity;
            this.ElementContainer = new T[capacity];
            this.listOfElements = new List<T>(capacity);
        }
        public void AddElement(T element)
        {
            if (listOfElements.Count > currentCapacity-1)
            {
                Console.WriteLine("Maximu capacity of {0} reached!!!",currentCapacity);
                Console.WriteLine("Element Not Added!!!");
                return;
            }
            else
            {
                this.listOfElements.Add(element);
                this.ElementContainer[count] = element;
                count++;
            }
        }
        public T GetElementByIndex(int index)
        {
            if (index>ElementContainer.Length)
            {
                throw new IndexOutOfRangeException(String.Format("Maximum count of ements in the collection is {0} !!!",currentCapacity));
            }
            return ElementContainer[index];
        }
        public void RemoveElement(int index)
        {
            listOfElements.RemoveAt(index);
            for (int i = index; i < currentCapacity; i++)
            {
                ElementContainer[i] = listOfElements[i];
            }
        }
    }
}
