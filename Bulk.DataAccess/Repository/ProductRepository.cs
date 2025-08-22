using System;
using Bulk.DataAccess.Data;
using Bulk.DataAccess.Repository.IRepository;
using Bulk.Models;

namespace Bulk.DataAccess.Repository;

public class ProductRepository : Repository<Product>, IProduct
{
    private readonly BulkDbContext _context;

    public ProductRepository(BulkDbContext context) : base(context)
    {
        _context = context;
    }

    
    public void Update(Product product)
    {
        // Detach any existing tracked entity with the same Id to avoid conflicts
        var existingEntry = _context.Entry(product);
        if (existingEntry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)
        {
            var trackedEntity = _context.Products.Local.FirstOrDefault(p => p.Id == product.Id);
            if (trackedEntity != null)
            {
                _context.Entry(trackedEntity).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
        }
        
        _context.Products.Update(product);
    }
}
