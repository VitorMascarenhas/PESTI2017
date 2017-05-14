﻿using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Domain.Interfaces.Interfaces;

namespace PlataformaRPHD.Infrastructure.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}