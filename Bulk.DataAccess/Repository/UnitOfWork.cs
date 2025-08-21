using System;
using Bulk.DataAccess.Data;
using Bulk.DataAccess.Repository.IRepository;

namespace Bulk.DataAccess.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly BulkDbContext _context;
    public ICategory Category { get; private set; }
    public IProduct Product { get; private set; }

    public UnitOfWork(BulkDbContext context)
    {
        _context = context;
        Category = new CategoryRepository(_context);
        Product = new ProductRepository(_context);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}
