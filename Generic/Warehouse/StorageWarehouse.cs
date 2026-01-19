using System;
namespace Generic.WarehouseSystem{
     class StorageWarehouse<T> where T : WarehouseItem {
        
            private List<T> storage = new List<T>();

            public void AddItems(T item){
                storage.Add(item);
            }

            public void ShowAllItems(){
                foreach(T item in storage){
                    item.Display();
                }
            }
        }
    }
