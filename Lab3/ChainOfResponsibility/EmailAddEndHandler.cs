using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class EmailAddEndHandler : HandlerBase
    {
        public override object Handle(object request)
        {
            if (request is string)
            {
                return base.Handle(request.ToString() + "\nBest regards 'Nameless CO'");
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
