using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // T koyuyoruz aşağıda da ben hangi tip koyarsam o şekilde kullan diyoruz
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //tempArray = geçiçi dizi
            T[] tempArray = items;
            //items.Length Eleman sayısını verir
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

    }
}
