﻿using Microsoft.EntityFrameworkCore;
using SalesWebAPI.Models;

namespace SalesWebAPI.Data;

class DataManager<TModel> : IDataManager<TModel> where TModel : class
{
    private readonly DbSet<TModel> dbSet;

    public DataManager(ApplicationContext context)
    {
        dbSet = GetDbSet(context);
    }

    private DbSet<TModel>? GetDbSet(ApplicationContext context) //мб сделать async
    {
        foreach (var property in typeof(ApplicationContext).GetProperties())
            if (property.PropertyType.Equals(typeof(DbSet<TModel>)))
                return property.GetValue(context, null) as DbSet<TModel>;

        throw new TypeAccessException($"There is no {nameof(DbSet<TModel>)} in {nameof(ApplicationContext)}");
    }

    public IEnumerable<Task<TModel>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<TModel> Get(int id)
    {
        throw new NotImplementedException();
    }
}
