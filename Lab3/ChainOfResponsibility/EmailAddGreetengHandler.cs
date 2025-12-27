using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class EmailAddGreetengHandler : HandlerBase
    {
        public override object Handle(object request)
        {
            if (request is string)
            {
                return base.Handle($"Dear customer \n" + request.ToString());
            }
            else return base.Handle(request);
        }
    }
}
