using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IStatePublisher
    {
        public List<IStateSubscriber> Subscribers { get;}

        public void Subscribe(IStateSubscriber subscriber);
        public void Unsubscribe(IStateSubscriber subscriber);
        public void InformChange(string fieldName, string oldVal, string newVal);
    }
}
