using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPart2List
{
    class GenericList<T> where T:IComparable
    {

        private T[] elements;

        private const int defaultCapacity = 4;

        public int Count { get; private set; }

        public int Capacity { get { return elements.Length; } }

        //Indexer of the GenericList
        public T this [int index]
        {
            get
            {
                if (index >= 0 && index <= Capacity)
                {
                    return elements[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index <= Capacity)
                {
                    elements[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        } 

        //Empty constructor of the GenericList
        public GenericList()
        {
            this.elements = new T[defaultCapacity];
            this.Count = 0;
        }

        //Method for adding an element to a GenericList
        public void Add(T element)
        {
            // resize if out of capacity
            if( this.Count == this.Capacity)
            {
                this.Expand();
            }
            this.elements[Count] = element;
            this.Count++;
        }

        //Methid to remove an element at specific index from a GenericList
        public void RemoveAtIndex(int index)
        {
            if (index >= 0 && index <= Capacity)
            {
                elements[index] = default(T);
                
                if(Count >= index)
                {
                    for (int i = index; i < this.Capacity - 1; i++)
                    {
                        this.elements[index] = this.elements[index + 1];
                    }
                    this.Count--;
                }
                else
                {
                    this.Count = index;
                }

            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        //Method to insert an element at specific index from a GenericList
        public void InsertAtIndex(T item, int index)
        {
            if(index > Capacity)
            {
                do
                {
                    this.Expand();
                } while (index > Capacity);
            }

            this.elements[index] = item;
            this.Count = index;
        }

        //Private Method to auto-grow the GenericList when adding elements and the capacity is full
        // or when inserting an element at specific index which is out of the capacity
        private void Expand()
        {
            T[] newElements = new T[2 * Capacity];

            Array.Copy(elements, newElements, Capacity);

            this.elements = newElements;
        }

        // Method to delete all elements from a GenericList. After deleting all elements the capacity is set
        //back to it's default value
        public void Clear()
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                this.elements[i] = default(T);
            }

            this.Count = 0;

            this.elements = new T[defaultCapacity];
        }

        //Method for searching the index of specific value
        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if(Equals(elements[i], item))
                {
                    return i;
                }
            }

            return -1;
        }

        //Method to print all the elements of a GenericList
        public override string ToString()
        {
            string result = string.Join(", ", this.elements);
            return result;
        }

        //Method which returns the minimal element of a GenericList
        public T Min()
        {
            T minItem = elements.Min<T>();

            return minItem;
        }

        //Method which returns the maximum element of a GenericList
        public T Max()
        {
            T maxItem = elements.Max<T>();

            return maxItem;
        }
    }
}
