using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Storage.Data;

namespace Storage.Services
{
    public class CategorySelectListService : ICategorySelectListService
    {
        private readonly StorageContext storageContext;

        public CategorySelectListService(StorageContext storageContext)
        {
            this.storageContext = storageContext;
        }


        public async Task<IEnumerable<SelectListItem>> GetCategorysAsync()
        {
            return await storageContext.Product.Select(p => p.Category).Distinct().Select(c => new SelectListItem
            {
                Text = c.ToString(),
                Value = c.ToString()
            }).ToListAsync();

        }
    }
}
