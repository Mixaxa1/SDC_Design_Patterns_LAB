using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task2.Db.Entities;

namespace Task2.Api
{
    public interface IApi
    {
        public void Create(SomeEntity entity);
        public void Update(SomeEntity entity);
        public SomeEntity? GetOneById(int id);
        public List<SomeEntity>? GetMany();
        public SomeEntity? GetByFilter(Expression<Func<SomeEntity, bool>> filter);
        public void Delete(SomeEntity entity);
        public void DeleteMany(List<SomeEntity> entityRange);
        public void PrintById(int id);
        public void PrintMany();
        public void SetStatus(int entityId, string newStatus);
        public void Activate(int entityId);
        public void Deactivate(int entityId);
    }
}
