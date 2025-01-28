using System;

namespace RestaurantManagementPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.initMenu();
            restaurant.initTables();
            bool exit = true;
            Console.WriteLine("Table number is showing following");
            restaurant.showAvailableTables();
            Console.WriteLine();

            while (exit)
            {
                Console.WriteLine("1. Do Order");
                Console.WriteLine("2. show available Tables");
                Console.WriteLine("3. show Menu Items");
                Console.WriteLine("4. Generate bill");
                Console.WriteLine("5. Add table in the List");
                Console.WriteLine("6. Remove table  from tablelist");
                Console.WriteLine("7. Remove item from food menu");
                Console.WriteLine("8. exit");
               

                Console.WriteLine("Please press the key what you want");
                

                int input =Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter Table number you want to book");
                        int tablecount=Convert.ToInt32(Console.ReadLine());

                        restaurant.Do_Orders(tablecount);
                        break;
                    case 2:
                        restaurant.showAvailableTables();
                        break;
                    case 3:
                        restaurant.showMenuesItem();
                        break;
                    case 4:
                        restaurant.generateBill();
                        break;
                    case 5:
                        restaurant.addTable();
                        break;
                    case 6:
                        restaurant.removeTable();
                        break;
                    case 7:
                        restaurant.removeFooditem();
                        break;
                    case 8:
                        exit = false;
                        break;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
