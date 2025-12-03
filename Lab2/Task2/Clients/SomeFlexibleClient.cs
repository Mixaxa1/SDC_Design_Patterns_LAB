using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LinqKit;
using Task2.Db.Entities;
using Task2.Proxy;

namespace Task2.Clients
{
    public class FlexibleClient
    {
        private ApiValidationProxy _someProxy;
        private ImageApiValidationProxy _imgProxy;
        public FlexibleClient(ApiValidationProxy someProxy, ImageApiValidationProxy imgProxy)
        {
            _someProxy = someProxy;
            _imgProxy = imgProxy;
        }

        public SomeEntity? SomeFlexibleSearch(string name = "", string description = "", string status = "")
        {
            Expression<Func<SomeEntity, bool>> expr = p => true;

            if (name != string.Empty)
            {
                expr = expr.And(x => x.Name == name);
            }
            if (description != string.Empty)
            {
                expr = expr.And(x => x.Description == description);
            }
            if (status != string.Empty)
            {
                expr = expr.And(x => x.Status == (EntityStatus)Enum.Parse(typeof(EntityStatus), status));
            }

            return _someProxy.GetByFilter(expr);
        }

        public List<SomeImageEntity>? ImgFlexibleSearch(string name = "", string description = "", string status = "")
        {
            Expression<Func<SomeImageEntity, bool>> expr = p => true;

            if (name != string.Empty)
            {
                expr = expr.And(x => x.Name == name);
            }
            if (description != string.Empty)
            {
                expr = expr.And(x => x.Description == description);
            }
            if (status != string.Empty)
            {
                expr = expr.And(x => x.Status == (EntityStatus)Enum.Parse(typeof(EntityStatus), status));
            }

            return _imgProxy.GetEntitiesByFilter(expr);
        }
    }
}
