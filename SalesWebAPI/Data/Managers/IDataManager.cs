namespace SalesWebAPI.Data;

interface IDataManager<TModel>
{
    IEnumerable<Task<TModel>> Get();
    Task<TModel> Get(int id);
}
