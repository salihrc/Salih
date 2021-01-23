using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> meyveler = new Dictionary<string, string>();
            meyveler.Add("elma","armut");
            Console.WriteLine(meyveler.Count);

            MyDictionary<string, string> meyveler2 = new MyDictionary<string, string>();
            meyveler2.Add("mandalina","portakal");
            Console.WriteLine(meyveler2.Count);
        }
    }
    class MyDictionary<T,X>
    {
        T[] tempArray;
        X[] tempArray2;
        X[] array2;
        T[] array;
        public MyDictionary()
        {
            array = new T[0];
            array2 = new X[0];
           
        }
        public void Add(T ithem,X ithem2)
        {
            tempArray = array;
            tempArray2 = array2;
            array = new T[array.Length + 1];
            array2 = new X[array2.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }

            array[array.Length - 1] = ithem;
            for (int e = 0; e < tempArray2.Length; e++)
            {
                array2[e] = tempArray2[e];
            }
            array2[array2.Length - 1] = ithem2;
        }   

        public int Count
        {
            get { return array.Length+array2.Length; }
        }


    }
}

