using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Task2.Db;
using Task2.Db.Entities;

namespace Task2.Api
{
    public class ImageApiController : IImageApi
    {
        protected readonly AppDbContext _dbContext;
        protected readonly DbSet<SomeImageEntity> _entities;

        public ImageApiController()
        {
            _dbContext = new AppDbContext();
            _entities = _dbContext.SomeImageEntities;
        }

        public string? GetImage(int id)
        {
            var entity = _entities.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return entity.ImageUrl;
            }
            return string.Empty;
        }

        public void SetImage(int entityId, string image)
        {
            var dbEntity = _entities.FirstOrDefault(x => x.Id == entityId);

            if (dbEntity != null)
            {
                dbEntity.ImageUrl = image;
                _entities.Update(dbEntity);
                _dbContext.SaveChanges();
            }
        }

        public List<SomeImageEntity>? GetEntitiesByFilter(Expression<Func<SomeImageEntity, bool>> filter)
        {
            return _entities.Where(filter).ToList();
        }
    }
}
