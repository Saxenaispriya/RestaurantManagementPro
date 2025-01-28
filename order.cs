using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementPro
{

    internal class order
    {
        public order() { }

        public order(int fooditemNumber, int quanty)
        {
            this._fooditemNumber = fooditemNumber;
            this._qunatiy = quanty;
        }

        public int orderId { get; set; }
        public int _fooditemNumber { get; set; }
        public int _qunatiy { get; set; }
    }
}
