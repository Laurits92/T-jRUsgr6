using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TøjRUsgr6.Models
{
    public class Clothing
    {
        public int ClothingID { get; set; }
        public string Title { get; set; }

        public string Category { get; set; }

        public  string Type { get; set; }

        public string Description { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public double Prize { get; set; }

        public string Image { get; set; }
    }
}
