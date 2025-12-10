using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Task2v2.Db;
using Task2v2.Db.Entities;

namespace Task2v2.SecondController
{
    public class SecondApiOperations : ISecondApiOperations
    {
        private AppDbContext _dbContext;
        private DbSet<SomeImageEntity> _imageEntities;
        public SecondApiOperations()
        {
            _dbContext = new AppDbContext();
            _imageEntities = _dbContext.SomeImageEntities;
        }

        public List<SomeImageEntity> GetEntitiesByFilter(Expression<Func<SomeImageEntity, bool>> filter)
        {
            return _imageEntities.Where(filter).ToList();
        }

        public string GetImage(Guid id)
        {
            return _imageEntities.FirstOrDefault(x => x.Id == id).ImageUrl;    
        }

        public void SetImage(Guid id, string imagePath)
        {
            var entity = _imageEntities.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                entity.ImageUrl = imagePath;
                _imageEntities.Update(entity);
                _dbContext.SaveChanges();
            }
        }
    }
}
