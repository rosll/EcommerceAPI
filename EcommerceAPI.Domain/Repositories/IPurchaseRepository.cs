using EcommerceAPI.Domain.Entities;

namespace EcommerceAPI.Domain.Repositories
{
    public interface IPurchaseRepository
    {
        Task<Purchase> GetByIdAsync(int id);
        Task<ICollection<Purchase>> GetAllAsync();
        Task<ICollection<Purchase>> GetByProductIdAsync(int productId);
        Task<ICollection<Purchase>> GetByPersonIdAsync(int personId);
        Task<Purchase> CreateAsync(Purchase purchase);
        Task DeleteAsync(Purchase purchase);
        Task EditAsync(Purchase purchase);
    }
}
