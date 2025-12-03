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
    public class ImageApiValidationProxy : IImageApi
    {
        protected IImageApi _imageApi;
        public ImageApiValidationProxy(IImageApi api)
        {
            _imageApi = api;
        }

        public List<SomeImageEntity>? GetEntitiesByFilter(Expression<Func<SomeImageEntity, bool>> filter)
        {
            return _imageApi.GetEntitiesByFilter(filter);
        }

        public string? GetImage(int id)
        {
            if(IsIdFormValid(id))
            {
                return _imageApi.GetImage(id);
            }
            return null;
        }

        public void SetImage(int entityId, string image)
        {
            if (IsIdFormValid(entityId) && image != string.Empty)
            {
                _imageApi.SetImage(entityId, image);
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
