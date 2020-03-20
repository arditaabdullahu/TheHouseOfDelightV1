using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheHouseOfDelightV1.DbModel
{
    public class FoodProducts
    {
        
        public int FoodID { get; set; }
        public Food Food { get; set; }
        public Product Product { get; set; }
        public int ProductID { get; set; }
    }
}
