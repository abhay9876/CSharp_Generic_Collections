/*Dynamic Online Marketplace
o Concepts: Type Parameters, Generic Methods, Constraints
o Problem Statement: Build a generic product catalog for an online
marketplace supporting various product types.
o Hints:
▪ Define a generic class Product<T> where T is restricted to a
category (BookCategory, ClothingCategory).
▪ Implement a generic method void ApplyDiscount<T>(T
product, double percentage) where T : Product.
▪ Ensure type safety while allowing multiple product
categories in the catalog.*/


using System;

namespace Generic.Market_Place
{
    class MarketPlace
    {
        public void MarketPlaceDetails()
        {
            Product<BookCategory> bp =
                new Product<BookCategory>("The Zeno", 2000,
                new BookCategory("Book", "Comics"));

            bp.ShowDetails();

            DiscountService ds = new DiscountService();
            ds.ApplyDiscount(bp, 10);
        }
    }
}
