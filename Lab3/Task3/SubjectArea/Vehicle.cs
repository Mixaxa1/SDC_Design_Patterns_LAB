
namespace Task3.SubjectArea
{
    public class Vehicle : IContainerSubscriber, IStatePublisher
    {
        private float _weight;
        public float Weight 
        { 
            get => _weight;
            set
            {
                if (_weight != value)
                {
                    InformChange(nameof(Weight), _weight.ToString(), value.ToString());
                    _weight = value;
                }
            } 
        }
        private float _lenght;
        public float Lenght
        {
            get => _lenght;
            set
            {
                if (_lenght != value)
                {
                    InformChange(nameof(Lenght), _lenght.ToString(), value.ToString());
                    _lenght = value;
                }
            }
        }

        private int _maxSpeed;
        public int MaxSpeed
        {
            get => _maxSpeed;
            set
            {
                if (_maxSpeed != value)
                {
                    InformChange(nameof(MaxSpeed), _maxSpeed.ToString(), value.ToString());
                    _maxSpeed = value;
                }
            }
        }

        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    InformChange(nameof(Name), _name, value);
                    _name = value;
                }
            }
        }

        public List<IStateSubscriber> Subscribers { get; } = [];

        public void InformChange(string fieldName, string oldVal, string newVal)
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.ChangeUpdate(fieldName, oldVal, newVal);
            }
        }

        public void Unsubscribe(IStateSubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void PrintClass()
        {
            Console.WriteLine($"Class is: {this.GetType().Name}");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{this.GetType()}\nName - {this.Name} Weight - {this.Weight} Lenght - {this.Lenght} Max speed - {this.MaxSpeed}");
        }

        public void Subscribe(IStateSubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }
    }
}