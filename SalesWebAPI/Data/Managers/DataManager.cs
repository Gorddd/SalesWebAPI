using Microsoft.EntityFrameworkCore;
using SalesWebAPI.Models;

namespace SalesWebAPI.Data;

class DataManager<TModel> : IDataManager<TModel> where TModel : class, IModel
{
    private readonly ApplicationContext context;

    private readonly DbSet<TModel> dbSet;

    public DataManager(ApplicationContext context)
    {
        this.context = context;
        dbSet = GetDbSet(context);
    }

    private DbSet<TModel>? GetDbSet(ApplicationContext context) //мб сделать async
    {
        foreach (var property in typeof(ApplicationContext).GetProperties())
            if (property.PropertyType.Equals(typeof(DbSet<TModel>)))
                return property.GetValue(context, null) as DbSet<TModel>;

        throw new TypeAccessException($"There is no {nameof(DbSet<TModel>)} in {nameof(ApplicationContext)}");
    }

    /// <summary>
    /// Add the object to database
    /// </summary>
    /// <param name="item">object to add</param>
    /// <returns></returns>
    public async Task Add(TModel item)
    {
        await dbSet.AddAsync(item);
        await context.SaveChangesAsync();
    }

    /// <summary>
    /// Delete the object from database
    /// </summary>
    /// <param name="id">Id of the object to delete</param>
    /// <returns>true if the object has been deleted; false if the object with the id hasn't been found</returns>
    public async Task<bool> Delete(int id)
    {
        var itemToDelete = await dbSet.FirstOrDefaultAsync(item => item.Id == id);
        if (itemToDelete is null)
            return false;

        dbSet.Remove(itemToDelete);
        await context.SaveChangesAsync();
        return true;
    }

    /// <summary>
    /// Get all objects from database
    /// </summary>
    /// <returns>all items</returns>
    public async Task<IEnumerable<TModel>> Get()
    {
        return await dbSet.ToListAsync();
    }

    /// <summary>
    /// Get object by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>object or null if object hasn't been found</returns>
    public async Task<TModel>? Get(int id)
    {
        return await dbSet.FirstOrDefaultAsync(item => item.Id == id);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id">id of item to update</param>
    /// <returns>true if object has been updated or false if hasn't been found</returns>
    public async Task Update(TModel updatedItem)
    {
        dbSet.Update(updatedItem);
        await context.SaveChangesAsync();
    }
}
