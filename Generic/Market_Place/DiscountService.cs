using System;

namespace Generic.Market_Place
{
    public class DiscountService
    {
        public void ApplyDiscount<T>(Product<T> product, double percentage)
            where T : Category
        {
            double discount = product.Price * percentage / 100;
            product.Price -= discount;

            Console.WriteLine($"Applied Discount : {discount}");
            Console.WriteLine($"Price after Discount : {product.Price}");
        }
    }
}
