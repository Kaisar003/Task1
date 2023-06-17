namespace Contractor.API.Repositories
{
    public interface IContractorRepository
    {
        Task<Entities.Contractor> GetAsync(Guid contractorId);

        Task<IEnumerable<Entities.Contractor>> GetAllAsync();
    }
}
