using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            Product product1 = new Product() { _name="Tshirt",_Price=25};
            Product product2 = new Product() { _name = "jacket", _Price = 55 };
            Product product3 = new Product() { _name = "Tshirt", _Price = 10 };
            Product product4 = new Product() { _name = "Shooe", _Price = 75 };
            Product product5 = new Product() { _name = "Under Wear", _Price = 20 };
            
            product.Add(product1);
            product.Add(product2);
            product.Add(product3);
            product.Add(product4);
            product.Add(product5);


            Console.WriteLine("Find a product using first");
            Console.WriteLine("=====================================================");

            Product prod=product.First(x=>x._name=="Shooe");
                Console.WriteLine(prod._name+"  "+prod._Price+"\n");



            Console.WriteLine("Find a product using FindAll");
            Console.WriteLine("=====================================================\n");

            List<Product> prod1 = product.FindAll(x => x._name == "Tshirt");

            foreach(Product p in prod1)
            {

                Console.WriteLine(p._name + "  " + p._Price);
               
            }
            Console.WriteLine("\nBefore sorting ");
            Console.WriteLine("=====================================================\n");


            foreach(Product e in product)
            {

                Console.WriteLine(e._name+" "+e._Price);
            }

            Console.WriteLine("\nAfer sorting using the Comparision deligate ");
            Console.WriteLine("=====================================================\n");


            Comparison<Product> ProductComp = new Comparison<Product>(CompareProducts);


            product.Sort(ProductComp);
            foreach (Product p in product)

            {
                Console.WriteLine(p._name+" "+p._Price);

            }
        }

        private static int CompareProducts(Product x, Product y)
        {
            
            {

                return x._Price.CompareTo(y._Price);
                
            }
        }
    }
}
