using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantManagementPro
{
    internal class Restaurant
    {
        Dictionary<int, fooditem> mydictfooditem = new Dictionary<int, fooditem>();
        Dictionary<int, table> mydicttable = new Dictionary<int, table>();


        public void initMenu()
        {
            var itemList = new List<string>(){
                "No food", "Dal Fry", "Rice", "Kadhai Panner"
            };

            var foodPriceList = new List<int>(){
             0,100, 200, 400
            };

            for (int i = 0; i < itemList.Count; i++)
            {
                fooditem foodItem = new fooditem();
                foodItem.foodItemId = i;
                foodItem.foodItemName = itemList[i];
                foodItem.foodPrice = foodPriceList[i];
                mydictfooditem.Add(i, foodItem);
            }
        }

        public void initTables()
        {
            for (int i = 1; i <= 10; i++)
            {
                table t = new table();
                t.tableNumber = i;
                t.isTableOccupied = false;
                mydicttable.Add(i, t);
            }
        }

        public void addTable()
        {
            Console.WriteLine("Add table number in the List");
            int _tableNumber = Convert.ToInt32(Console.ReadLine());
            table t = new table();
            t.tableNumber = _tableNumber;
            t.isTableOccupied = false;
            mydicttable.Add(_tableNumber, t);
        }

        public void removeTable()
        {
            Console.WriteLine("which table number you want to delete");
            int _tablenumber = Convert.ToInt32(Console.ReadLine());
            if (mydicttable.ContainsKey(_tablenumber))
            {
                mydicttable.Remove(_tablenumber);
            }
        }

        public void removeFooditem()
        {
            Console.WriteLine("which food item Id you want to delete");
            int _fooditem = Convert.ToInt32(Console.ReadLine());
            if (mydictfooditem.ContainsKey(_fooditem))
            {
                mydictfooditem.Remove(_fooditem);
            }
        }

        public void showAvailableTables()
        {
            foreach (KeyValuePair<int, table> t in mydicttable)
            {
                if (!t.Value.isTableOccupied)
                {
                    Console.WriteLine(t.Value.tableNumber + "\t");
                }
            }
        }

        public void showMenuesItem()
        {
            foreach (KeyValuePair<int, fooditem> f in mydictfooditem)
            {
                Console.Write("food Id:" + f.Value.foodItemId + "\t");
                Console.Write("," + "food name: " + f.Value.foodItemName + "\t");
                Console.WriteLine("," + "food Price: " + f.Value.foodPrice);
            }
        }

        public void Do_Orders(int tableNumber)
        {
            showMenuesItem();
            bool orderComplete = true;
            while (orderComplete)
            {
                Console.WriteLine("enter the item number");
                int itemNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the quntity");
                int quantity = Convert.ToInt32(Console.ReadLine());

                if (mydicttable.ContainsKey(tableNumber))
                {
                    table t = mydicttable[tableNumber];
                    t.orderlist.Add(new order(itemNumber, quantity));
                }
                Console.WriteLine("Do you want to add more items; just type Y or N");
                string inp = Console.ReadLine();
                if (inp.Equals("Y", StringComparison.OrdinalIgnoreCase))
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
            int tableNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if(mydicttable.ContainsKey(tableNumber))
            {
                table t=mydicttable[tableNumber];
                foreach (order or in t.orderlist)
                {
                    if(mydictfooditem.ContainsKey(or._fooditemNumber))
                    {
                        fooditem fditm=mydictfooditem[or._fooditemNumber];
                        sum += fditm.foodPrice * or._qunatiy;
                    }
                }
            } else
            {
                Console.WriteLine("table not found");
            }

            Console.WriteLine("you need to pay amount:" + sum);
        }

    }
}
