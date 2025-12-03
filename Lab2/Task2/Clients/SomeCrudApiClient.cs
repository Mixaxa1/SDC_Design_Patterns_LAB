using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Db.Entities;
using Task2.Proxy;

namespace Task2.Clients
{
    public class SomeCrudApiClient
    {
        private ApiValidationProxy _proxy;

        public SomeCrudApiClient(ApiValidationProxy proxy)
        {
            _proxy = proxy;
        }

        public void Create(string name, string description, string status)
        {
            var someEntity = new SomeEntity
            {
                Name = name,
                Description = description,
                Status = (EntityStatus)Enum.Parse(typeof(EntityStatus), status, true)
            };

            _proxy.Create(someEntity);
        }

        public SomeEntity? Get(int id)
        {
            return _proxy.GetOneById(id);
        }

        public List<SomeEntity>? GetAll()
        {
            return _proxy.GetMany();
        }

        public void Delete(int id)
        {
            var entitty = Get(id);
            if (entitty != null)
            {
                _proxy.Delete(entitty);
            }
        }

        public void Update(int entityId, string newName = "", string newDesc = "", string newStatus = "")
        {
            if (newName == string.Empty || newDesc == string.Empty || newStatus == string.Empty)
            {
                return;
            }

            var entity = _proxy.GetOneById(entityId);
            if (entity != null)
            {
                entity.Name = newName == string.Empty ? entity.Name : newName;
                entity.Description = newDesc == string.Empty ? entity.Description : newDesc;
                entity.Status = newStatus == string.Empty ? entity.Status : (EntityStatus)Enum.Parse(typeof(EntityStatus), newStatus, true);

                _proxy.Update(entity);
            }
        }
    }
}
