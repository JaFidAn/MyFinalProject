using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Burada T uchun xususi shertler qoyulur
    //1. Where T:class - yeni ancaq class ola biler
    //2. T ancaq class ola biler hem de IEntity ve IEntity referans ala bilen class olmalidir
    //3. En sonda new() yazmaqla bildiririk ki, ancaq IEntity implement ede bilen class olsun, IEntity - nin ozu new lene bilmediyi uchun onu qebul etmeyecek.
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
