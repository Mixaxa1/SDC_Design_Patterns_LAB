namespace Task3.SubjectArea
{
    public class Cargo : Vehicle
    {
        private int _tonnage;
        public int Tonnage
        {
            get => _tonnage;
            set
            {
                if (_tonnage != value)
                {
                    InformChange(nameof(Tonnage),
                                 _tonnage.ToString(),
                                 value.ToString());
                    _tonnage = value;
                }
            }
        }

        private int _tankVolume;
        public int TankVolume
        {
            get => _tankVolume;
            set
            {
                if (_tankVolume != value)
                {
                    InformChange(nameof(TankVolume),
                                 _tankVolume.ToString(),
                                 value.ToString());
                    _tankVolume = value;
                }
            }
        }

        private int _axelsAmount;
        public int AxelsAmount
        {
            get => _axelsAmount;
            set
            {
                if (_axelsAmount != value)
                {
                    InformChange(nameof(AxelsAmount),
                                 _axelsAmount.ToString(),
                                 value.ToString());
                    _axelsAmount = value;
                }
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Tonnage - {this.Tonnage} Tanl volume - {this.TankVolume} Axels amount - {this.AxelsAmount}");
        }
    }
}
