using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Classes
{
    class Customer
    {
        public int CustomerPosition { get; set; }
        int SpawnType(int type)
        {
            Random rng = new Random();
            int customerType = rng.Next(1,3);
            type = customerType;
            return type;
        }
        
    }
}
