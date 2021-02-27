using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2
{
    class MyDictionary<T, A>
    {

        T[] keyItem;
        A[] valueItem;
        public MyDictionary()
        {
            keyItem = new T[0];
            valueItem = new A[0];
        }
        public void add(T item1, A item2)
        {
            T[] tempArrayKey = keyItem;
            A[] tempArrayValue = valueItem;
            keyItem = new T[keyItem.Length + 1];
            valueItem = new A[valueItem.Length + 1];
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keyItem[i] = tempArrayKey[i];
            }
            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                valueItem[i] = tempArrayValue[i];
            }

            keyItem[keyItem.Length - 1] = item1;
            valueItem[valueItem.Length - 1] = item2;            
        }
        public void list()
        {
            for (int i = 0; i < keyItem.Length; i++)
            {
                Console.WriteLine("Adı: " + keyItem[i] + " Id: "+ valueItem[i]);
            }
        }
    }
}


