using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task2.Db;
using Task2.Db.Entities;

namespace Task2.Api
{
    public class ApiController : IApi
    {
        protected readonly AppDbContext _dbContext;
        protected readonly DbSet<SomeEntity> _entities;

        public ApiController()
        {
            _dbContext = new AppDbContext();
            _entities = _dbContext.SomeEntities;
        }

        public void Create(SomeEntity entity)
        {
            _entities.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(SomeEntity entity)
        {
            _entities.Update(entity);
            _dbContext.SaveChanges();
        }

        public SomeEntity? GetOneById(int id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);
        }

        public List<SomeEntity>? GetMany()
        {
            return _entities.ToList();
        }

        public SomeEntity? GetByFilter(Expression<Func<SomeEntity, bool>> filter)
        {
            return _entities.Where(filter).FirstOrDefault();
        }

        public void Delete(SomeEntity entity)
        {
            _entities.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void DeleteMany(List<SomeEntity> entityRange)
        {
            _entities.RemoveRange(entityRange);
            _dbContext.SaveChanges();
        }

        public void PrintById(int id)
        {
            var entity = _entities.FirstOrDefault(x =>x.Id == id);

            if (entity != null)
            {
                Console.WriteLine(entity.ToString());
            }
        }

        public void PrintMany()
        {
            var entities = _entities.ToList();

            if (entities.Count > 0)
            {
                foreach(var entity in entities)
                {
                    Console.WriteLine(entity.ToString());
                }
            }
        }

        public void SetStatus(int entityId, string status)
        {
            var newStatus = (EntityStatus)Enum.Parse(typeof(EntityStatus), status, true);
            var dbEntity = _entities.FirstOrDefault(x => x.Id == entityId);

            if (dbEntity != null)
            {
                dbEntity.Status = newStatus;
                _entities.Update(dbEntity);
                _dbContext.SaveChanges();
            }
        }

        public void Activate(int entityId)
        {
            SetStatus(entityId, "Active");
        }

        public void Deactivate(int entityId)
        {
            SetStatus(entityId, "Inactive");
        }
    }
}
