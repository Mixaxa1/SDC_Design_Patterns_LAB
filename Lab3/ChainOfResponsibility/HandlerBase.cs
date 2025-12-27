using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class HandlerBase : IHandler
    {
        private IHandler _nextInChain;

        public virtual object Handle(object request)
        {
            if  (_nextInChain != null)
            {
                return _nextInChain.Handle(request);
            }
            else
            {
                return request;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextInChain = handler;

            return handler;
        }
    }
}
