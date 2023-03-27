﻿namespace invoiceManager.Data
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool SaveChanges();
        IQueryable<T> table { get; }
    }
}
