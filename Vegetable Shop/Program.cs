using System;

using System.Collections.Generic;

namespace Vegetable_Shop
{
    
    abstract class Product
    {
        public string Name { get; }
        public double BasePrice { get; private set; } 

        public Product(string name, double basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        public abstract double GetPrice(); 
    }

    
    class Carrot : Product
    {
        public Carrot(double basePrice) : base("Carrot", basePrice) { }

        public override double GetPrice()
        {
            return BasePrice;
        }
    }

   
    class Potato : Product
    {
        public double Count { get; } 

        public Potato(double basePrice, double count) : base("Potato", basePrice)
        {
            Count = count;
        }

        public override double GetPrice()
        {
            return BasePrice * Count;
        }
    }

    
    class Cucumber : Product
    {
        public double Count { get; } 

        public Cucumber(double basePrice, double count) : base("Cucumber", basePrice)
        {
            Count = count;
        }

        public override double GetPrice()
        {
            return BasePrice * Count;
        }
    }

   
    class VegetableShop
    {
        private List<Product> products = new List<Product>();

        
        public void AddProducts(List<Product> newProducts)
        {
            products.AddRange(newProducts);
        }

        
        public void PrintProductsInfo()
        {
            double totalPrice = 0;

            foreach (var product in products)
            {
                if (product is Potato potato)
                {
                    Console.WriteLine($"Product: {potato.Name}, Price: {potato.BasePrice}, Count: {potato.Count}, Total price: {potato.GetPrice()}");
                }
                else if (product is Cucumber cucumber)
                {
                    Console.WriteLine($"Product: {cucumber.Name}, Price: {cucumber.BasePrice}, Count: {cucumber.Count}, Total price: {cucumber.GetPrice()}");
                }
                else
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.GetPrice()}");
                }
                totalPrice += product.GetPrice();
            }

            Console.WriteLine($"Total products price: {totalPrice}");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {

            var products = new List<Product>()

            {
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2)

            };


          
            VegetableShop shop = new VegetableShop();
            shop.AddProducts(products);

           
            shop.PrintProductsInfo();
        }
    }

}
