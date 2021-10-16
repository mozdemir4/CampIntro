﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Desk";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Pen",
                UnitsInStock = 4,
                UnitPrice = 12
            };

            ProductManager.Add(product1);
            ProductManager.Add(product2);
            ProductManager.Update(product1);
            ProductManager.Update(product2);
            
        }
    }
}
