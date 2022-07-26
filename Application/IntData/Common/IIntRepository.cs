namespace Application.IntData.Common;

public interface IIntRepository
{
    public Task<List<int>> GetAllAsync();
    
}