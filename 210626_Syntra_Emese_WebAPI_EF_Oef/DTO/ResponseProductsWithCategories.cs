using _210626_Syntra_Emese_WebAPI_EF_Oef.Controllers;
using _210626_Syntra_Emese_WebAPI_EF_Oef.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _210626_Syntra_Emese_WebAPI_EF_Oef.DTO
{
    public class ResponseProductsWithCategories
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }

        public List<ResponseCategoryDTO> categories { get; set; }
    }
}
