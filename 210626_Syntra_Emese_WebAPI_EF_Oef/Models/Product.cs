using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _210626_Syntra_Emese_WebAPI_EF_Oef.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }

        public int CategoryID { get; set; }
        public List<Category> Categories { get; set; }

    }
}
