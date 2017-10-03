using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PlataformaRPHD.Domain.Interfaces.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category, int>
    {
        IEnumerable<Category> rootCategories();

        IEnumerable<Category> getDownCategories(int categoryId);

        Category FindCategory(int? id);
    }
}
