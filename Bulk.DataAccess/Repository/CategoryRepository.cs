using System;
using System.Linq;
using Bulk.DataAccess.Data;
using Bulk.DataAccess.Repository.IRepository;
using Bulk.Models;

namespace Bulk.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategory
    {
        private BulkDbContext _context;
        public CategoryRepository(BulkDbContext context) : base(context)
        {
            _context = context;
        }
        
        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
