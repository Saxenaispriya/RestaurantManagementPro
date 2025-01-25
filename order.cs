using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementPro
{
   
    internal class order
    {
        Restaurant restaurant = new Restaurant();
        public order() { }

        public int orderId {  get; set; }
        public string orderName { get; set; }
        public fooditem _fooditem { get; set; }
        public table _table {  get; set; }
    }
}
