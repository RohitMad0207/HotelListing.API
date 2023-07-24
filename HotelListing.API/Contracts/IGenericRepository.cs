namespace HotelListing.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddASync(T entity);
        Task UpdateASync(T entity);
        Task DeleteASync(int id);
        Task<bool> Exists(int id);
    }
}
