using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Task2v2.Db.Entities;

namespace Task2v2.SecondController
{
    public interface IFirstApiOperations
    {
        public Task<SomeImageEntity?> Create(SomeImageEntity entity);

        public Task<SomeImageEntity?> Update(SomeImageEntity entity);

        public Task<SomeImageEntity?> GetOneById(Guid id);

        public Task<List<SomeImageEntity>?> GetMany();

        public Task<SomeImageEntity?> GetByFilter(Expression<Func<SomeImageEntity, bool>> filter);

        public Task Delete(Guid id);

        public Task DeleteMany(List<Guid> entityRange);

        public Task PrintById(Guid id);

        public Task PrintMany();

        public Task SetStatus(Guid entityId, string status);

        public Task Activate(Guid entityId);

        public Task Deactivate(Guid entityId);
    }
}
