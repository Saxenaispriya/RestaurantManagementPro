using System;
using System.Collections.Generic;

namespace RestaurantManagementPro
{
    internal class Restaurant
    {
       public List<fooditem> fooditemlst = new List<fooditem>();
       public List<table> tablelist = new List<table>();
       public List<order> orderlist = new List<order>();


        public void addMenusItem()
        {
            fooditemlst.Add(new fooditem() { foodItemId = 0, foodItemName = "No food", foodPrice = 0 });
            fooditemlst.Add(new fooditem() { foodItemId = 1, foodItemName = "Dal Fry", foodPrice = 200 });
            fooditemlst.Add(new fooditem() { foodItemId = 2, foodItemName = "Rice", foodPrice = 180 });
            fooditemlst.Add(new fooditem() { foodItemId = 3, foodItemName = "Kadai Paneer", foodPrice = 300 });
            fooditemlst.Add(new fooditem() { foodItemId = 4, foodItemName = "Virgin Mohito", foodPrice = 250 });
            fooditemlst.Add(new fooditem() { foodItemId = 5, foodItemName = "Panner Tikka", foodPrice = 400 });
        }

        public void addTableNumber()
        {
            tablelist.Add(new table() { tableNumber = 102, isTableOccupied = false });
            tablelist.Add(new table() { tableNumber = 103, isTableOccupied = false });
            tablelist.Add(new table() { tableNumber = 104, isTableOccupied = false });
            tablelist.Add(new table() { tableNumber = 105, isTableOccupied = false });
            tablelist.Add(new table() { tableNumber = 101, isTableOccupied = false });
            tablelist.Add(new table() { tableNumber = 106, isTableOccupied = false });
            tablelist.Add(new table() { tableNumber = 107, isTableOccupied = false });
            tablelist.Add(new table() { tableNumber = 108, isTableOccupied = false });
            tablelist.Add(new table() { tableNumber = 109, isTableOccupied = false });
        }
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

        public void Do_Orders(int tableno)
        {
            int total=0;
            List<int> foodids = new List<int>();
            order o = new order();
            table tablebook = new table();
            //for (int i = 0; i <tableno; i++)
            //{
            //    tablelist[i].isTableOccupied = true;
            //}
            Console.WriteLine("Select Menues items and type foodId for food");
            showMenuesItem();

            //while (0 <o._fooditem.foodItemId)
            //{
            //    o._fooditem.foodItemId = Convert.ToInt32(Console.ReadLine());
            //    foodids.Add(o._fooditem.foodItemId);
            //}

            //    foreach (int x in foodids)
            //    {
            //        foreach(fooditem f in fooditemlst)
            //        {
            //            if(f.foodItemId==x)
            //            {
            //                total=total+f.foodPrice;
            //            }
            //        }
            //    }
                Console.WriteLine("you need to pay"+": "+ total);

        }
    }
}
