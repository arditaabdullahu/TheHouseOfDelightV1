using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheHouseOfDelightV1.DbModel
{
    public class Types
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<FoodTypes> Foods { get; set; }
    }
}
