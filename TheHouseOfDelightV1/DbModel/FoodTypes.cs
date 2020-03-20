using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheHouseOfDelightV1.DbModel
{
    public class FoodTypes
    {
        
        public int FoodID { get; set; }
        public Food Food { get; set; }
        public Types Type { get; set; }
        public int TypeID { get; set; }
    }
}
