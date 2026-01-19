using System;

namespace Generic.Market_Place
{
    public class Product<T> where T : Category
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public T Category { get; set; }

        public Product(string name, double price, T category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Product : {Name}, Price : {Price}, Category : {Category.name}");
        }
    }
}
