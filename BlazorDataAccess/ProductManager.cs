using BlazorEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDataAccess
{
    public class ProductManager:IProductManager
    {
        private readonly ISqlDataAccess _dataAccess;
        public ProductManager(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<Product>> GetProducts()
        {
            return _dataAccess.GetProducts();
        }
    }
}
