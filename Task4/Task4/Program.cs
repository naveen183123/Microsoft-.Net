﻿using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Threading;
namespace SailsList
{
    public class Task2 : IEnumerable
    {
        //declare delegate
        public delegate SailsList<int> DelOneAndThree(SailsList<int> List);
        public static void Main(string[] args)
        {
            SailsList<int> slist = new SailsList<int>();
            SailsList<int> templist = new SailsList<int>();
            Console.WriteLine("Adding Elements to SailsList");
            slist.AddEle(1);
            slist.AddEle(2);
            slist.AddEle(3);
            slist.AddEle(1);
            slist.AddEle(4);
            foreach (int element in slist)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Deleting Elements to SailsList");
            slist.DeleteAt(1);
            foreach (int element in slist)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Adding array of elements on SailsList");
            int[] eleme = new int[5] { 4, 2, 3, 4, 5 };
            
            slist.AddArray(eleme);
            foreach (int element in slist)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------------------------------------");
            //Ability to enumerate
            Console.WriteLine("Ability to enumerate on SailsList");
            IEnumerator e = slist.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Count Elements of an Array");
            int[] vs = new int[] { 1, 2, 3, 4, 5, 1, 1, 3, 6 };
            int size = vs.Length;
            slist.countElem(vs,size);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Printing the Repeated Elements in an Array");
            
            slist.printE(vs);
            Console.WriteLine("--------------------------------------------");
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        //Custom List 
        public class SailsList<T> : IEnumerable
        {
            private T[] data;
            private int size = 0;
            private int capacity;
            public SailsList(int initialCapacity = 8)
            {
                if (initialCapacity < 1) initialCapacity = 1;
                this.capacity = initialCapacity;
                data = new T[initialCapacity];
            }
            public int Size { get { return size; } }
            public bool IsEmpty { get { return size == 0; } }
            //Delete value with index
            public void DeleteAt(int index)
            {
                ThrowIfIndexOutOfRange(index);
                for (int i = index; i < size - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                data[size - 1] = default(T);
                size--;
            }
            //Add elements to list
            public void AddEle(T newElement)
            {
                if (size == capacity)
                {
                    Resize();
                }
                data[size] = newElement;
                size++;
            }
            //Resize
            public void Resize()
            {
                T[] resized = new T[capacity * 2];
                for (int i = 0; i < capacity; i++)
                {
                    resized[i] = data[i];
                }
                data = resized;
                capacity = capacity * 2;
            }
            //Adding Array of elements
            public void AddArray(T[] SArray)
            {
                int arrLength = SArray.Length;
                if (size + arrLength <= capacity)
                {
                    var existingCount = size;
                    for (int i = 0; i < arrLength; i++)
                    {
                        data[existingCount + i] = SArray[i];
                        size++;
                    }
                }
                else
                {
                    T[] resized = new T[capacity + arrLength];
                    for (int i = 0; i < size; i++)
                    {
                        resized[i] = data[i];
                    }
                    capacity = capacity + arrLength;
                    var oldSize = size;
                    for (int i = 0; i < arrLength; i++)
                    {
                        resized[i + oldSize] = SArray[i];
                        size++;
                        
                    }
                    data = resized;
                }
            }
            public void countElem(int[] arr, int n)
            {
                bool[] visited = new bool[n];
                for (int i = 0; i < n; i++)
                {
                    if (visited[i] == true)
                        continue;
                    int count = 1;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            visited[j] = true;
                            count++;
                        }
                    }
                    Console.WriteLine(arr[i] + " " + count);
                }
            }
            public void printE(int[] array1)
            {
                List<int> data = new List<int>();
                foreach(int pen in array1)
                {
                    data.Add(pen);
                }
                var query = from element in data where element == 1 || element == 3 select element;
                foreach(var elements in query)
                {
                    Console.Write(elements + " ");
                }
                Console.WriteLine();
            }
            private void ThrowIfIndexOutOfRange(int index)
            {
                if (index > size - 1 || index < 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The current size of the array is{0}", size));
                }
            }
            public IEnumerator GetEnumerator()
            {
                return data.GetEnumerator();
            }
        }
    }
}