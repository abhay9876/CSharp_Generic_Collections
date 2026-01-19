using System;
namespace Generic.WarehouseSystem{
    class Electronics : WarehouseItem{
       
        public override void Display(){
            Console.WriteLine($"Item Type : Electronics    Item Name : {name}");
        }
    }

    class Grocery : WarehouseItem{
        public override void Display(){
            Console.WriteLine($"Item Type : Grocery    Item Name : {name}");
        }
    }

    class Furniture : WarehouseItem{
        public override void Display(){
            Console.WriteLine($"Item Type : Furniture    Item Name : {name}");
        }
    }
}