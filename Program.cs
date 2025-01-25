using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("1. Do Order");
                Console.WriteLine("2. show available Tables");
                Console.WriteLine("3. show Menu Items");
                Console.WriteLine("4. exit");
               

                Console.WriteLine("Please press the key what you want");
                

                int input =Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("How many Table you want to book");
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
                        exit = false;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
