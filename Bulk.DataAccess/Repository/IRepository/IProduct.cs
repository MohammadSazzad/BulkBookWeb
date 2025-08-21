using System;
using Bulk.Models;

namespace Bulk.DataAccess.Repository.IRepository;

public interface IProduct : IRepository<Product>
{
    void Update(Product product);
}
