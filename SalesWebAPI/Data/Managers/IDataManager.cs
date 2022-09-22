namespace SalesWebAPI.Data;

interface IDataManager<TModel>
{
    IEnumerable<Task<TModel>> Get();

    Task<TModel> Get(int id);

    Task Add(TModel item);

    Task Update(int id, TModel updatedItem);

    Task Delete(int Id);
}
