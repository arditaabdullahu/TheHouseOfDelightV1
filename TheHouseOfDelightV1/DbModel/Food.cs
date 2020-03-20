using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheHouseOfDelightV1.DbModel
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public int TotatTime { get; set; }
        public int Servings { get; set; }
        public string Author { get; set; }
        public virtual List<FoodTypes> Types { get; set; }
        public virtual List<FoodProducts> Products { get; set; }

    }
}
