using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _210626_Syntra_Emese_WebAPI_EF_Oef.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string categorieName { get; set; }

        public List<Product> Products { get; set; }
    }
}
