using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _210626_Syntra_Emese_WebAPI_EF_Oef.DTO
{
    public class ResponseCategoryWithProductsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ResponseProductDTO> Products { get; set; }
    }
}
