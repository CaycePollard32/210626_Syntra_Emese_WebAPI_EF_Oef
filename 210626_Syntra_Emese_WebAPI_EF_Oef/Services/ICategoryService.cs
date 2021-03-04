using _210626_Syntra_Emese_WebAPI_EF_Oef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _210626_Syntra_Emese_WebAPI_EF_Oef.Services
{
    public interface ICategoryService
    {
        Category AddCategory(Category category);


        List<Category> GetCategories();

        List<Category> GetCategoriesWithProducts();

    }
}
