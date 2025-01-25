using System;
using System.Collections.Generic;

namespace RestaurantManagementPro
{
    internal class Restaurant
    {
       public List<fooditem> fooditemlst = new List<fooditem>();
       public List<table> tablelist = new List<table>();


        public void initMenu()
        {
            itemList = new List<string>{
                "No food", "Dal Fry", "Rice", "Kadhai Panne"
            }

            foodPriceList = new List<int>{
             100, 200, 400, 500
            }

            for (int i = ; i< itemlist.count(); i++){
                fooditemlst.Add(new fooditem() { foodItemId = i, foodItemName = itemList[i], foodPrice = fooditemList[i] });

            }
        }

        public void initTables()
        {
            for (int i = 0; i< 10; i++ ) {
                tablelist.Add(new table() { tableNumber = i, isTableOccupied = false });
            }
        }

        public addTable(tableNumber int) {
            tablelist.Add(new table (){ tableNumber: tableNumber, isTableOccupied = false })
        }

        public removeTable() {

        }

        public fooditem() {

        }

        public removeFooditem()

        public void showAvailableTables()
        {
            foreach (table t in tablelist)
            {
                if (!t.isTableOccupied)
                {
                    Console.WriteLine(t.tableNumber);
                    Console.WriteLine(t.isTableOccupied);
                }
            }
        }

        public void showMenuesItem()
        {
            foreach (fooditem f in fooditemlst)
            {
                Console.WriteLine(f.foodItemId);
                Console.WriteLine(f.foodItemName);
                Console.WriteLine(f.foodPrice);
            }
        }

        public void Do_Orders(int tableNumber)
        {
            showMenuesItem()
            bool orderComplete
            while (orderComplete) {
            "enter the item number"
            itemNumber 
            "enter the quntity"
            quantity

            for (int i := 0; i< tablelist; i++) {
                if tabllist[i].number == tableNumber {
                    tablelist[i].orders.Add( new order(itemnumber, quntity))
                }
            }
            'Do you want to add more items';
            orderComplete = false
            }

        }

        public void generateBill(int tableNumber) {
            int sum = 0
            foreach(table t  in tablelist) {
                T.Number == tableNumber {
                    foreach(order or in t.orders) {
                        foreach(fooditem fd in fooditemlist) {
                            if fd.foodItemId == or.fooditemNumber { 
                                sum += fd.foodPrice * or.quanity
                            }
                        }
                    }
                }
            }
        }

        
    }
}
