using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.SubjectArea;

namespace Task3
{
    public class VechicleContainer : IContainerPublisher, IStateSubscriber
    {
        public List<IContainerSubscriber> Subscribers { get;} = [];

        public void ChangeUpdate(string fieldName, string oldVal, string newVal)
        {
            Console.WriteLine($"Field change: name {fieldName}, old value {oldVal}, new value {newVal}");
        }

        public void Subscribe(IContainerSubscriber subscriber)
        {


            Subscribers.Add(subscriber);

            subscriber.PrintClass();
        }

        public void Unsubscribe(IContainerSubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }
    }
}
