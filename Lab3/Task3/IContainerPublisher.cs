using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.SubjectArea;

namespace Task3
{
    public interface IContainerPublisher
    {
        public List<IContainerSubscriber> Subscribers { get;}

        public void Subscribe(IContainerSubscriber subscriber);

        public void Unsubscribe(IContainerSubscriber subscriber);
    }
}
