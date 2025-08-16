using System;

namespace Bulk.DataAccess.Repository.IRepository;

public interface IUnitOfWork
{
    ICategory Category { get; }
    void Save();
}
