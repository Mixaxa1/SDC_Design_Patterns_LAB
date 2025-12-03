using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.DecoratedClass;

namespace Decorator.Decorators
{
    public class PremiumPrerollAdDecorator : VideoDecorator
    {
        public PremiumPrerollAdDecorator(YoutubeVideo video) : base(video)
        {
        }

        public override string ShowVideo()
        {
            string preroll = "Some nonsense AD even for premium users\n";
            return preroll + base.ShowVideo();
        }
    }
}
