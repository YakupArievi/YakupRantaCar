using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        class Product
        {
            public int productId { get; set; }
            public string productName { get; set; }
            public string productDescription { get; set; }
        }
        class kurslar
        {
            public string egitmenName { get; set; }
            public string kursName { get; set; }
        }
        static void Main(string[] args)
        {
            //ders2
            /*
            List<Product> products = new List<Product> 
            { 
                new Product {productId =1 ,productName="Elma" ,productDescription="amasya elması"},
                new Product {productId =2 ,productName="Armut",productDescription="deveci armut"},
                new Product {productId =3 ,productName="Karpuz",productDescription="adana karpuz"}
            };
            Console.WriteLine("Foreach");
            foreach (Product p in products)
            {
                Console.WriteLine(("Product ID :" + p.productId,"product name :" + p.productName, "Product Description :" + p.productDescription));
            }
            Console.WriteLine("For");
            
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine((products[i].productDescription, products[i].productId, products[i].productName));
            }
            Console.WriteLine(products);

            Console.WriteLine("While");
            int x = 0;
            while (x< products.Count)
            {
                Console.WriteLine(products[x].productName);
                x++;
            }
            */
            
        }
    }
}
