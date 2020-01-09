using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace App.Core.Interfaces
{
    public interface IOperations<T> where T : class
    {
        T Create(T Data);
        T Read(T Data);
        T Update(T Data);
        T Delete(T Data);
        T Find(Expression<Func<T, bool>> matchitem);
        IEnumerable<T> FindAllWhere(Expression<System.Func<T, bool>> matchitem);
        IEnumerable<T> FindAllWhereTake(Expression<System.Func<T, bool>> matchitem, int count);
        Task<IEnumerable<T>> FindAll();
        IEnumerable<T> FindAllTake(int count);
        int Count();
        Task<bool> ExistsAsync(Expression<Func<T, bool>> matchitem);
        bool Exists(Expression<Func<T, bool>> matchitem);
    }
}
