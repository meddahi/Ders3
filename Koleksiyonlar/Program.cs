﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# da ve java genellikle array kullanılmaz,koleksiyonlar kullanılır
            //string[] isimler = new string[] { "Engin", "murat","halil", "mehmet"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //isimler[4] = "kemal";
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string> { "Engin", "murat", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("selami");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);




        }
    }
}