using System;
using System.Collections.Generic;
using System.Text;

namespace D4O5
{
    class MyDictionary<T>
    {
        T[] array = new T[0];
        
        public T[] Add(T item) 
        {
            T[] tempArray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            array[array.Length - 1] = item;

            return array;
        }

        
    }
}
