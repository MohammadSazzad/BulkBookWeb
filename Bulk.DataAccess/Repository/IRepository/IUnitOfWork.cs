using System;

namespace Bulk.DataAccess.Repository.IRepository;

public interface IUnitOfWork
{
    ICategory Category { get; }
    IProduct Product { get; }
    void Save();
}
