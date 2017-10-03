using System;
using System.Collections.Generic;
using System.Data.Entity;
using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
        
        public IEnumerable<Category> rootCategories()
        {
            return this.Find(x => x.ParentUpCategoryItem == null);
        }

        public IEnumerable<Category> getDownCategories(int categoryId)
        {
            return this.Find(c => c.ParentUpCategoryItem.Id == categoryId);
        }

        public Category FindCategory(int? id)
        {
            return this.FirstOrDefault(x => x.Id == id);
        }
    }
}
