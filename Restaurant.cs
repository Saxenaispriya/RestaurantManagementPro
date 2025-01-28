using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantManagementPro
{
    internal class Restaurant
    {
       public List<fooditem> fooditemlst = new List<fooditem>();
       public List<table> tablelist = new List<table>();


        public void initMenu()
        {
           var itemList = new List<string>(){
                "No food", "Dal Fry", "Rice", "Kadhai Panner"
            };

           var foodPriceList = new List<int>(){
             0,100, 200, 400
            };

            for (int i =0; i< itemList.Count; i++){
                fooditemlst.Add(new fooditem() { foodItemId = i, foodItemName = itemList[i], foodPrice = foodPriceList[i] });

            }
        }

        public void initTables()
        {
            for (int i = 1; i<= 10; i++ ) {
                tablelist.Add(new table() { tableNumber = i, isTableOccupied = false });
            }
        }

        public void addTable() {
            Console.WriteLine("Add table number in the List");
            int _tableNumber=Convert.ToInt32(Console.ReadLine());
            tablelist.Add(new table()
            { tableNumber= _tableNumber, isTableOccupied = false});
        }

        public void removeTable() {
            Console.WriteLine("which table number you want to delete");
            int _tablenumber=Convert.ToInt32(Console.ReadLine());
            int i = 0;
            foreach (table t in tablelist.ToList())
            {
                if(t.tableNumber.Equals(_tablenumber) && t.isTableOccupied==false)
                {
                    tablelist.RemoveAt(i); 
                }
                i++;
            }

        }

        public void removeFooditem()
        {
            Console.WriteLine("which food item Id you want to delete");
            int _fooditem=Convert.ToInt32(Console.ReadLine());
            int i = 0;
            foreach(fooditem f in fooditemlst.ToList())
            {
                if(f.foodItemId==_fooditem)
                {
                    fooditemlst.RemoveAt(i);
                }
                i++;
            }
        }

        public void showAvailableTables()
        {
            foreach (table t in tablelist)
            {
                if (!t.isTableOccupied)
                {
                    Console.WriteLine(t.tableNumber + "\t");
                }
            }
        }

        public void showMenuesItem()
        {
            foreach (fooditem f in fooditemlst)
            { 
                Console.Write("food Id:" +  f.foodItemId +"\t");
                Console.Write("," +"food name: " + f.foodItemName +"\t");
                Console.WriteLine("," + "food Price: " + f.foodPrice);
            }
        }

        public void Do_Orders(int tableNumber)
        {
            table t = new table();
            showMenuesItem();
            bool orderComplete=true;
            while (orderComplete) {
                Console.WriteLine("enter the item number");
                int itemNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the quntity");
            int quantity=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<tablelist.Count; i++) {
                if (tablelist[i].tableNumber == tableNumber) {
                        tablelist[i].orderlist.Add(new order(itemNumber, quantity));
                        tablelist[i].isTableOccupied = true;
                }
            }
               Console.WriteLine("Do you want to add more items; just type Y or N");
               string  inp = Console.ReadLine();
                if(inp.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    orderComplete = true;
                }
                else
                {
                    orderComplete = false;
                }
            }
            Console.WriteLine("You booked a table:" + tableNumber);
            Console.WriteLine();
        }

        public void generateBill()
        {   
            Console.WriteLine("Eneter the table number");
            int tableNumber = Convert.ToInt32 (Console.ReadLine());
            int sum = 0;
            foreach (table t in tablelist)
            {
               if(t.tableNumber == tableNumber) {
                    foreach (order or in t.orderlist)
                    {
                        foreach (fooditem fd in fooditemlst)
                        {
                            if (fd.foodItemId == or._fooditemNumber) {
                                sum += fd.foodPrice * or._qunatiy;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("you need to pay amount:" + sum);
        }


    }
}
