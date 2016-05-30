namespace DefiningClasses2.Structure
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class GenericList<T>
    {
        public T[] elementContainer;
        int nextIndex = 0;
        private int initialValue { get; set; }

        public GenericList(int initialSize)
        {
            this.initialValue = initialSize;
            elementContainer = new T[initialSize];
        }

        public void AddElement(T element)
        {
            elementContainer[this.nextIndex] = element;
            elementContainer = AutoGrow(elementContainer);
            nextIndex++;
        }

        public T GetElement(int index)
        {
            return elementContainer[index];
        }

        public void RemovingElement(int index)
        {
            for (int i = index; i < elementContainer.Length - 1; i++)
            {
                elementContainer[i] = this.elementContainer[i + 1];
            }
            this.nextIndex--;
            this.elementContainer[nextIndex] = default(T);
        }


        public void InsertElement(int index, T newElement)
        {

            for (int i = nextIndex; i > index && i > 0; i--)
            {
                this.elementContainer[i] = this.elementContainer[i - 1];
            }
            this.elementContainer[index] = newElement;
            this.elementContainer = AutoGrow(elementContainer);
            this.nextIndex++;
        }
        public void ClearList()
        {
            this.elementContainer = new T[initialValue];
        }
        public T FindElement(T value)
        {
            foreach (var item in elementContainer)
            {
                if (item.Equals(value))
                {
                    return item;
                }
            }
            Console.WriteLine("Your Item was not found!!!");
            return value;
        }
        public T[] AutoGrow(T[] valueHolder)
        {
            if (valueHolder[valueHolder.Length - 1].Equals(default(T)))
            {
                return valueHolder;
            }
            else
            {
                T[] temp = new T[initialValue * 2];
                for (int i = 0; i < valueHolder.Length; i++)
                {
                    temp[i] = valueHolder[i];
                }
                initialValue = initialValue * 2;
                return valueHolder = temp;
            }

        }

        public static T Min<T>(GenericList<T>array)
        {
            var minValue = default(T);
            for (var i=0;i<array.Count();i++)
            {
                if (array[i].CompareTo(minValue)>0)
                {
                    minValue = item;
                }
            }
            return minValue;
        }

    }
}
