using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrivingLicense.WebApi.Models.BaseTypes;

namespace DrivingLicense.WebApi.Infastructure.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        Task Insert(T entity);
        void Update(T entity);
        Task Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
