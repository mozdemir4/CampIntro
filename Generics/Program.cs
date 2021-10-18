using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities1 = new List<string>();
            cities1.Add("Adana");
            cities1.Add("Rize");
            cities1.Add("Bayburt");
            cities1.Add("Kastamonu");

            Console.WriteLine(cities1.Count);
           

            MyList<string> cities2 = new MyList<string>();
            cities2.Add("Artvin");
            cities2.Add("Çanakkale");
            cities2.Add("Bursa");
            cities2.Add("Balıkesir");
            cities2.Add("Samsun");
            Console.WriteLine(cities2.Count);

        }
    }

    class MyList<T> // generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
      

        public int Count
        {
            get { return _array.Length; }
       
        }

    }
    
}
