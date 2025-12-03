using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task2.Api;
using Task2.Db.Entities;

namespace Task2.Proxy
{
    public class ApiValidationProxy : IApi
    {
        protected IApi _api;

        public ApiValidationProxy(IApi api)
        {
            _api = api;
        }

        public void Activate(int entityId)
        {
            if (IsIdFormValid(entityId))
            {
                _api.Activate(entityId);
            } 
        }

        public void Create(SomeEntity entity)
        {
            if (entity.IsValid())
            {
                _api.Create(entity);
            }
        }

        public void Deactivate(int entityId)
        {
            if (IsIdFormValid(entityId))
            {
                _api.Deactivate(entityId);
            }
        }

        public void Delete(SomeEntity entity)
        {
            if (entity.IsValid() && IsIdFormValid(entity.Id))
            {
                _api.Delete(entity);
            }
        }

        public void DeleteMany(List<SomeEntity> entityRange)
        {
            foreach (var entity in entityRange)
            {
                if (!entity.IsValid() || !IsIdFormValid(entity.Id))
                {
                    return;
                }
            }

            _api.DeleteMany(entityRange);
        }

        public SomeEntity? GetByFilter(Expression<Func<SomeEntity, bool>> filter)
        {
            return _api.GetByFilter(filter);
        }

        public List<SomeEntity>? GetMany()
        {
            return _api.GetMany();
        }

        public SomeEntity? GetOneById(int id)
        {
            if (IsIdFormValid(id))
            {
                return _api.GetOneById(id);
            }
            
            return null;
        }

        public void PrintById(int id)
        {
            if (IsIdFormValid(id))
            {
                _api.PrintById(id);
            }
        }

        public void PrintMany()
        {
            _api.PrintMany();
        }

        public void SetStatus(int entityId, string newStatus)
        {
            if (IsIdFormValid(entityId) && Enum.TryParse<EntityStatus>(newStatus, true, out _))
            {
                _api.SetStatus(entityId, newStatus);
            }
        }

        public void Update(SomeEntity entity)
        {
            if (IsIdFormValid(entity.Id) && entity.IsValid()) 
            {
                if (_api.GetOneById(entity.Id) != null)
                {
                    _api.Update(entity);
                }
            }
            
        }

        public bool IsIdFormValid(int id)
        {
            if (id < 0)
            {
                return false;
            }
            return true;
        }
    }
}
