namespace Task3.SubjectArea
{
    public class Tank : Vehicle
    {
        private int _projectileCaliber;
        public int ProjectileCaliber
        {
            get => _projectileCaliber;
            set
            {
                if (_projectileCaliber != value)
                {
                    InformChange(nameof(ProjectileCaliber),
                                 _projectileCaliber.ToString(),
                                 value.ToString());
                    _projectileCaliber = value;
                }
            }
        }

        private float _shotsPerMinute;
        public float ShotsPerMinute
        {
            get => _shotsPerMinute;
            set
            {
                if (_shotsPerMinute != value)
                {
                    InformChange(nameof(ShotsPerMinute),
                                 _shotsPerMinute.ToString(),
                                 value.ToString());
                    _shotsPerMinute = value;
                }
            }
        }

        private int _crewSize;
        public int CrewSize
        {
            get => _crewSize;
            set
            {
                if (_crewSize != value)
                {
                    InformChange(nameof(CrewSize),
                                 _crewSize.ToString(),
                                 value.ToString());
                    _crewSize = value;
                }
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Projectile caliber {this.ProjectileCaliber} Shots per minute - {this.ShotsPerMinute} Crew size - {this.CrewSize}");
        }
    }
}
