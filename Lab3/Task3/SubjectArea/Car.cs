using Task3.SubjectArea.Enum;

namespace Task3.SubjectArea
{
    public class Car : Vehicle
    {
        private WheelDrive _wheelDrive;
        public WheelDrive WheelDrive
        {
            get => _wheelDrive;
            set
            {
                if (_wheelDrive != value)
                {
                    InformChange(nameof(WheelDrive),
                                 _wheelDrive.ToString(),
                                 value.ToString());
                    _wheelDrive = value;
                }
            }
        }

        private CarClass _class;
        public CarClass Class
        {
            get => _class;
            set
            {
                if (_class != value)
                {
                    InformChange(nameof(Class),
                                 _class.ToString(),
                                 value.ToString());
                    _class = value;
                }
            }
        }

        private string _color = string.Empty;
        public string Color
        {
            get => _color;
            set
            {
                if (_color != value)
                {
                    InformChange(nameof(Color),
                                 _color,
                                 value);
                    _color = value;
                }
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Whell drive - {this.WheelDrive.ToString()} Class - {this.Class.ToString()} Color - {this.Color}");
        }
    }
}
