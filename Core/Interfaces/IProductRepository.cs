using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Core.Entities;


namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductsByIdAsync(int Id);

        Task<IReadOnlyList<Product>> GetProductsAsync();

        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();

        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}
