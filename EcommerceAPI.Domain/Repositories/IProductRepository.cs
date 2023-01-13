using EcommerceAPI.Domain.Entities;

namespace EcommerceAPI.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<ICollection<Product>> GetProductAsync();
        Task<Product> CreateAsync(Product product);
        Task EditAsync(Product product);
        Task DeleteAsync(Product product);
    }
}
