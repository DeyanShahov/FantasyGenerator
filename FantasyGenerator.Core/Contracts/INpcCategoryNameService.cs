namespace FantasyGenerator.Core.Contracts
{
    public interface INpcCategoryNameService
    {
        Task<string> GetAllNpcCategoryNames();
    }
}
