using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceService
{
    public class ProductList
    {
        List<Product> products = new List<Product>();
        Product p = new Product();
        Length length = new Length();
        Size size = new Size();
        Colour colour = new Colour();

        public double SetPrice(string l)
        {
            switch (length.LengthName) {
                case "Short":
                    return p.Price = 10;
                case "Medium":
                    return p.Price = 12.50;
                case "Long":
                    return p.Price = 15;
                default:
                    return p.Price = 10;
            }

        }

        public void AddProduct(string name, string desc, string image)
        {
            p.Name = name;
            p.Desc = desc;
            p.Price = SetPrice(p.Length);
            p.Length = length.LengthName;
            p.Size = size.SizeName;
            p.Colour = colour.ColourName;
            p.Image = image;
            products.Add(p);
        }

        public void RemoveProduct()
        {
            products.Remove(p);
        }

    }
}