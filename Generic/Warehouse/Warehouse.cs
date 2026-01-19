/*Smart Warehouse Management System
o Concepts: Generic Classes, Constraints, Variance
o Problem Statement: Develop a warehouse system that manages
different types of items (Electronics, Groceries, Furniture).
o Hints:
▪ Create an abstract class WarehouseItem that all items
extend (Electronics, Groceries, Furniture).
▪ Implement a generic class Storage<T> where T :
WarehouseItem to store items safely.
▪ Implement a method to display all items using List<T>.*/



using System;
namespace Generic.WarehouseSystem{
    class Warehouse{
        public void WarehouseDetail(){
            StorageWarehouse<Electronics> elecStorage = new StorageWarehouse<Electronics>();
            elecStorage.AddItems(new Electronics{name = "Fan"});
            elecStorage.AddItems(new Electronics{name = "AC"});
            elecStorage.ShowAllItems();

            StorageWarehouse<Grocery> grocStorage = new StorageWarehouse<Grocery>();
            grocStorage.AddItems(new Grocery{name = "Rice"});
            grocStorage.AddItems(new Grocery{name = "Water"});
            grocStorage.ShowAllItems();

            StorageWarehouse<Furniture> furnStorage = new StorageWarehouse<Furniture>();
            furnStorage.AddItems(new Furniture{name = "Chair"});
            furnStorage.AddItems(new Furniture{name = "Table"});
            furnStorage.ShowAllItems();

            
        }
    }
}