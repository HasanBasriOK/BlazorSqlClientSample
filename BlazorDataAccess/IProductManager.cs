using BlazorEntity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDataAccess
{
    public interface IProductManager
    {
        Task<List<Product>> GetProducts();
    }
}