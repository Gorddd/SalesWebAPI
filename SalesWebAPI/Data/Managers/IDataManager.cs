namespace SalesWebAPI.Data;

public interface IDataManager<TModel>
{
    Task<IEnumerable<TModel>> Get();

    Task<TModel>? Get(int id);

    Task Add(TModel item);

    Task Update(TModel updatedItem);

    Task<bool> Delete(int Id);
}
