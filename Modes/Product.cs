using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHometask2.Modes
{
    public class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double TotalIncome { get; set; }

        public Product(string name)
        {
            this.Name = name;
        }

        public void Sell(int buyingCount)
        {

            if (this.Count>= buyingCount)
            {
                this.Count -= buyingCount;
                this.TotalIncome+=this.Price* buyingCount; 
                Console.WriteLine($"{buyingCount} piece {this.Name} succesfully selled");
            }
            else
            {
                Console.WriteLine("The product is not in stock !");
            }
        }
    }
}
