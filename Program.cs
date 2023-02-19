using System;
using System.Collections;

namespace CSharpProj_Shimon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArrayList arr = new ArrayList();
            
            arr.Add(new Product("Milk",5));
            arr.Add(new Product("Cookies", 8));
            arr.Add(new Product("Bread", 7));
            arr.Add(new Product("Eggs",29));
            arr.Add(new Product("Cheese",18));

            arr.Sort();

            foreach (Product i in arr)
                Console.WriteLine(i.ToString());
           



        }
    }
}
