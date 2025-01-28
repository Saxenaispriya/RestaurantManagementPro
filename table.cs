using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementPro
{
    internal class table
    {
        public table() { }
        public table(int _tableNumber)
        {
            tableNumber = _tableNumber;
            orderlist = new List<order>();
        }
        public int tableNumber {  get; set; }
        public bool isTableOccupied { get; set; }= false;

       public List<order> orderlist=new List<order>();
    }
}
