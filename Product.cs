using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSharpProj_Shimon
{
    public class Product : IComparable
    {
        private string name; 
        private double price;

        public Product(string name,double price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name { get => this.name; set => this.name = value; }
        public double Price { get => this.price; set => this.price = value; }

        public int CompareTo(object obj)
        {
            if (this.price > ((Product)obj).price)
                return 1;
            else if (this.price < ((Product)obj).price)
                return -1;
            else return 0;
        }

        public override string ToString()
        {
            return $"Name: {this.name} Price: {this.price}";
        }
    }
}
