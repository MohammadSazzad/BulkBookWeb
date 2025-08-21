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
        _context.Products.Update(product);
    }
}
