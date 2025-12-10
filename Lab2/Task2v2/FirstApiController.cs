using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task2v2.Db;
using Task2v2.Db.Entities;

namespace Task2v2
{
    [ApiController]
    [Route("[controller]")]
    public class FirstApiController : ControllerBase
    {
        private DbSet<SomeEntity> _entities;
        private AppDbContext _dbContext;

        public FirstApiController()
        {
            _dbContext = new AppDbContext();
            _entities = _dbContext.SomeEntities;
        }

        [HttpPost]
        public SomeEntity? Create(SomeEntity entity)
        {
            entity.Id = Guid.NewGuid();
            _entities.Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        [HttpPut]
        public SomeEntity? Update(SomeEntity entity)
        {
            _entities.Update(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        [HttpGet("{id}")]
        public SomeEntity? GetOneById(Guid id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);
        }

        [HttpGet]
        public List<SomeEntity>? GetMany()
        {
            return _entities.ToList();
        }

        [HttpGet("byFilter/")]
        public SomeEntity? GetByFilter([FromQuery] Expression<Func<SomeEntity, bool>> filter)
        {
            return _entities.Where(filter).FirstOrDefault();
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var entity = _entities.FirstOrDefault(x => x.Id == id);

            if (entity != null)
            {
                _entities.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        [HttpDelete("many/")]
        public void DeleteMany([FromQuery] List<Guid> entityRange)
        {
            var entities = _entities.Where(x => entityRange.Contains(x.Id)).ToList();

            _entities.RemoveRange(entities);
            _dbContext.SaveChanges();
        }

        [HttpGet("print/{id}")]
        public void PrintById(Guid id)
        {
            var entity = _entities.FirstOrDefault(x => x.Id == id);

            if (entity != null)
            {
                Console.WriteLine(entity.ToString());
            }
        }

        [HttpGet("print/")]
        public void PrintMany()
        {
            var entities = _entities.ToList();

            if (entities.Count > 0)
            {
                foreach (var entity in entities)
                {
                    Console.WriteLine(entity.ToString());
                }
            }
        }

        [HttpGet("changeStatus/{id}")]
        public void SetStatus(Guid entityId, [FromQuery] string status)
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


        [HttpGet("changeStatus/activate/{entityId}")]
        public void Activate(Guid entityId)
        {
            SetStatus(entityId, "Active");
        }

        [HttpGet("changeStatus/deactivate/{entityId}")]
        public void Deactivate(Guid entityId)
        {
            SetStatus(entityId, "Inactive");
        }
    }
}
