using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public void BuildChair(IChairBuilder builder)
        {
            builder.AddBack();
            builder.AddLegs();
            builder.AddSeat();
        }

        public void BuildStool(IChairBuilder builder)
        {
            builder.AddLegs();
            builder.AddSeat();
        }
    }
}
