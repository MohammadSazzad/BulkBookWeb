using System;
using Bulk.Models;

namespace Bulk.DataAccess.Repository.IRepository
{
    public interface ICategory : IRepository<Category>
    {
        void Update(Category category);
    }
}
