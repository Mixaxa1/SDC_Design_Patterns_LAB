using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task2.Db.Entities;

namespace Task2.Api
{
    public interface IImageApi
    {
        public string? GetImage(int id);

        public void SetImage(int entityId, string image);

        public List<SomeImageEntity>? GetEntitiesByFilter(Expression<Func<SomeImageEntity, bool>> filter);
    }
}
