using System.Linq.Expressions;
using Task2v2.Db.Entities;

namespace Task2v2.SecondController
{
    public interface ISecondApiOperations
    {
        public void SetImage(Guid id, string imagePath);
        public string GetImage(Guid id);
        public List<SomeImageEntity> GetEntitiesByFilter(Expression<Func<SomeImageEntity, bool>> filter);
    }
}
