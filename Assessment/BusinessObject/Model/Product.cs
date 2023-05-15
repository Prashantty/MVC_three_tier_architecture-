using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Model
{
    public class Product
    {

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }  

        public User user { get; set; }
    }
}
