using BlazorEntity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<Product>> GetProducts();
    }
}