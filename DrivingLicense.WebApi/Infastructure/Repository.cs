using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DrivingLicense.WebApi.Infastructure.Interfaces;
using DrivingLicense.WebApi.Models;
using DrivingLicense.WebApi.Models.BaseTypes;
using System.Data.SqlClient;

namespace DrivingLicense.WebApi.Infastructure
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DataContext _context;
        private DbSet<T> _entities;
        private string _errorMessage = String.Empty;

        public Repository(DataContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
                throw new ArgumentException("Entity is broken");
            }

            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            return _entities.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("entity");
            }

            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }

            _entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _context.SaveChanges();
        }
    }
}
